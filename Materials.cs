using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Buddy.Coroutines;
using ff14bot;
using ff14bot.Helpers;
using ff14bot.Managers;

namespace crafty
{
    internal static class Materials
    {
        private static readonly List<Material> Mats = new List<Material>();

        private static void AddMaterial(string itemname, uint qty)
        {
            for (var i = 0; i < Mats.Count(); i++)
            {
                //Check for item already existing.
                if (Mats[i].Itemname.Equals(itemname))
                {
                    Mats[i].Qtyreq += qty;
                    return;
                }
            }
            //Add it if it doesn't exist.
            Mats.Add(new Material(itemname, qty));
        }

        public static void ClearList()
        {
            Mats.Clear();
        }

        public static Material[] GetList()
        {
            return Mats.ToArray();
        }

        public static bool FetchMaterials(uint craftingId, uint qty, bool expand = false)
        {
            using (Core.Memory.TemporaryCacheState(false))
            {
                RaptureAtkUnitManager.Update();
                GameObjectManager.Update();
                var isKnown = (CraftingManager.CurrentRecipeId == (ushort) craftingId);
                Logging.Write(CraftingManager.CurrentRecipeId);
                if (!isKnown)
                {
                    var coroutine = new Coroutine(() => CraftingManager.SetRecipe(craftingId));
                    while (!coroutine.IsFinished)
                    {
                        Thread.Sleep(33);
                        coroutine.Resume();
                    }
                }
                RaptureAtkUnitManager.Update();
                GameObjectManager.Update();
                isKnown = (CraftingManager.CurrentRecipeId == (ushort) craftingId);
                Logging.Write(isKnown);
                if (isKnown)
                {
                    var recipe = CraftingManager.CurrentRecipe;
                    foreach (var i in recipe.Ingredients)
                    {
                        if (i.ItemId != 0) //Keep getting a 0 ID ingredient here for some reason?!
                        {
                            var iname = DataManager.GetItem(i.ItemId).EnglishName;
                            var totalreq = i.TotalNeeded*qty;
                            if (expand) //Check if we're expanding the recipe
                            {
                                var rec = Recipes.Recipes.getRecipe(iname, Core.Me.CurrentJob);
                                //See if we know it in current job.
                                if (rec.Id != 0)
                                {
                                    if (FetchMaterials(rec.Id, totalreq, true))
                                    {
                                        Crafty.OrderForm.AddOrder(rec.Id, rec.Name, totalreq,
                                            Recipes.Recipes.GetJob(rec.Id)); //Add it if we know it!
                                    }
                                }
                                else if (Recipes.Recipes.getRecipe(iname).Count > 0)
                                    //Check if we've got it on our other jobs
                                {
                                    foreach (var r in Recipes.Recipes.getRecipe(iname))
                                    {
                                        if (FetchMaterials(r.Id, totalreq, true))
                                        {
                                            Crafty.OrderForm.AddOrder(r.Id, r.Name, totalreq,
                                                Recipes.Recipes.GetJob(r.Id));
                                            break;
                                        }
                                    }
                                }
                                else //Add the material if we don't know how to make it.
                                {
                                    AddMaterial(iname, totalreq);
                                }
                            }
                            else
                            {
                                AddMaterial(iname, totalreq);
                            }
                        }
                    }
                    return true;
                }
                return false;
            }
        }

        public static void CountStock()
        {
            using (Core.Memory.TemporaryCacheState(false))
            {
                GameObjectManager.Update();
                for (var i = 0; i < Mats.Count; i++)
                {
                    Logging.Write("Counting item " + Mats[i].Itemname);
                    var mat = DataManager.GetItem(Mats[i].Itemname);
                    Mats[i].Qty = mat.ItemCount() + Crafty.OrderForm.CountOrders(Mats[i].Itemname);
                }
            }
        }

        public class Material
        {
            public readonly string Itemname;
            public uint Qty, Qtyreq;

            public Material(string name, uint qtyreq)
            {
                Itemname = name;
                Qtyreq = qtyreq;
                Qty = 0;
            }
        }
    }
}