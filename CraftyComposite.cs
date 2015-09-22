using TreeSharp;
using ff14bot.Managers;
using ff14bot.Helpers;
using System.Collections.Generic;

namespace crafty
{
    internal class CraftyComposite
    {
        public static Composite getBase(List<crafty.order> orders)
        {
            foreach(crafty.order o in orders)
            {
                Logging.Write("Order item: " + o.item + ". Qty Required: " + o.qty);
            }
            var SelectRecipe = new Action(a=>CraftingManager.SetRecipe(100));
            var CanCraft = new Decorator(s=>CanICraftIt(), StopBot("Can't Craft the item. Stopping!"));
            Sequence root = new Sequence(SelectRecipe, CanCraft);
            return root;
        }

       static Composite StopBot(string Reason)
        {
            return new Action(a =>
            {
                Logging.Write(Reason);
                ff14bot.TreeRoot.Stop();
                return RunStatus.Success;
            });
        }

        static bool CanICraftIt()
        {
            return CraftingManager.CanCraft ? false : true;
        }


    }
}