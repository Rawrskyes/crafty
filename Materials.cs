using ff14bot.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crafty
{
    static class Materials
    {
        public class Material
        {
            public uint qty, qtyreq;
            public string itemname;

            public Material(string name, uint qtyreq)
            {
                this.itemname = name;
                this.qtyreq = qtyreq;
                this.qty = 0;
            }
        }

        private static List<Material> mats = new List<Material>();

        public static void AddMaterial(string itemname, uint qty)
        {
            for(int i = 0; i < mats.Count(); i++)
            {
                //Check for item already existing.
                if (mats[i].itemname.Equals(itemname))
                {
                    mats[i].qtyreq += qty;
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

        public static async Task<bool> FetchMaterials(uint craftingID, uint qty)
        {
            bool isKnown = await CraftingManager.SetRecipe(craftingID);
            if(isKnown == true)
            {
                RecipeData recipe = CraftingManager.CurrentRecipe;
                foreach(RecipeIngredientInfo i in recipe.Ingredients)
                {
                    string iname = DataManager.GetItem(i.ItemId).EnglishName;
                    uint totalreq = i.TotalNeeded * qty;
                    AddMaterial(iname, totalreq);
                }
                return true;
            } else
            {
                return false;
            }
        }

        public static void CountStock()
        {
            for(int i = 0; i < mats.Count; i++)
            {
                Item mat = DataManager.GetItem(mats[i].itemname);
                mats[i].qty = InventoryManager.ItemCount(mat);
            }
        }
    }
}
