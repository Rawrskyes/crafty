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

        private static List<Material> mats = new List<Material>();

        public static void AddMaterial(string itemname, uint qty)
        {
                for (int i = 0; i < mats.Count(); i++)
                {
                    //Check for item already existing.
                    if (mats[i].Itemname.Equals(itemname))
                    {
                        mats[i].Qtyreq += qty;
                        return;
                    }

                }
            //Add it if it doesn't exist.
            mats.Add(new Material(itemname, qty));
            return;
        }

        public static void ClearList()
        {
            mats.Clear();
        }

        public static Material[] GetList()
        {
            return mats.ToArray();
        }

        public static bool FetchMaterials(uint craftingId, uint qty)
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
                        Thread.Sleep(20);
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
                        Logging.Write("In the foreach loop");
                        string iname = DataManager.GetItem(i.ItemId).EnglishName;
                        Logging.Write("Item Selected");
                        uint totalreq = i.TotalNeeded*qty;
                        AddMaterial(iname, totalreq);
                        Logging.Write("Item Added");
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
                for (int i = 0; i < mats.Count; i++)
                {
                    Item mat = DataManager.GetItem(mats[i].Itemname);
                    mats[i].Qty = InventoryManager.ItemCount(mat);
                }
            }
        }
    }
}
