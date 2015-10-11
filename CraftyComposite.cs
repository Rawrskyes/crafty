using TreeSharp;
using ff14bot.Managers;
using ff14bot.Helpers;
using crafty.Ability;

namespace crafty
{
    internal static class CraftyComposite
    {
        public static Composite GetBase()
        {
            //List<Crafty.Order> orders
            //foreach(Crafty.Order o in orders)
            // {
            //     Logging.Write("Order item: " + o.Item + ". Qty Required: " + o.Qty);
            // }
            var selectRecipe = new Action(a=>CraftingManager.SetRecipe(100));
            var canCast = new Decorator(s=> CraftingManager.AnimationLocked, new Sleep(1000));
            var canCraft = new Decorator(s=>CanICraftIt(), StopBot("Can't Craft the item. Stopping!"));
            var beginSynth = new Action(a =>
            {
                Character.CurrentRecipeLvl = ff14bot.Managers.CraftingManager.CurrentRecipe.RecipeLevel;
                Mend.Available = true;
                ff14bot.RemoteWindows.CraftingLog.Synthesize();
            });
            var continueSynth = new Decorator(s=> CraftingManager.IsCrafting, Strategy.GetComposite());
            return new PrioritySelector(new Sleep(350), canCast, continueSynth, canCraft, beginSynth);
        }
       public static Composite StopBot(string reason)
        {
            return new Action(a =>
            {
                Logging.Write(reason);
                ff14bot.TreeRoot.Stop();
                return RunStatus.Success;
            });
        }

        static bool CanICraftIt()
        {
            return !CraftingManager.CanCraft;
        }

        static Composite WaitForAnimation()
        {
            return new Action(a =>
            {
                if (CraftingManager.AnimationLocked)
                {
                    return RunStatus.Running;
                }
                else
                {
                    return RunStatus.Success;
                }
                
            });
        }

    }
}