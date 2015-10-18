using ff14bot.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Buddy.Coroutines;
using ff14bot;
using ff14bot.Behavior;
using ff14bot.Helpers;
using TreeSharp;

namespace crafty
{
    static class Materials
    {
        public class Material
        {
            public uint Qty, Qtyreq;
            public readonly string Itemname;

            public Material(string name, uint qtyreq)
            {
                this.Itemname = name;
                this.Qtyreq = qtyreq;
                this.Qty = 0;
            }
        }

        private static readonly List<Material> Mats = new List<Material>();

        private static void AddMaterial(string itemname, uint qty)
        {
                for (int i = 0; i < Mats.Count(); i++)
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
                bool isKnown = (CraftingManager.CurrentRecipeId == (ushort) craftingId);
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
                if (isKnown == true)
                {
                    RecipeData recipe = CraftingManager.CurrentRecipe;
                    foreach (RecipeIngredientInfo i in recipe.Ingredients)
                    {
                        if (i.ItemId != 0) //Keep getting a 0 ID ingredient here for some reason?!
                        {
                            string iname = DataManager.GetItem(i.ItemId).EnglishName;
                            uint totalreq = i.TotalNeeded*qty;
                            if (expand)
                            {
                                var rec = Recipes.Recipes.getRecipe(iname, Core.Me.CurrentJob);
                                if (rec.Id != 0)
                                {
                                    if (FetchMaterials(rec.Id, totalreq, true))
                                    {
                                        Crafty.OrderForm.AddOrder(rec.Id, rec.Name, totalreq,
                                            Recipes.Recipes.GetJob(rec.Id));
                                    }
                                }else if (Recipes.Recipes.getRecipe(iname).Count > 0)
                                {
                                    foreach (var r in Recipes.Recipes.getRecipe(iname))
                                    {
                                        if (FetchMaterials(r.Id, totalreq, true))
                                        {
                                            Crafty.OrderForm.AddOrder(r.Id, r.Name, totalreq, Recipes.Recipes.GetJob(r.Id));
                                        }
                                            
                                    }
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
                else
                {
                    return false;
                }
            }
        }

        public static void CountStock()
        {
            using (Core.Memory.TemporaryCacheState(false))
            {
                GameObjectManager.Update();
                for (int i = 0; i < Mats.Count; i++)
                {
                    Logging.Write("Counting item " + Mats[i].Itemname);
                    Item mat = DataManager.GetItem(Mats[i].Itemname);
                    Mats[i].Qty = mat.ItemCount();
                }
            }
        }

    }
}
