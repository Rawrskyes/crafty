using crafty.Ability;
using ff14bot;
using ff14bot.Helpers;
using ff14bot.Managers;
using ff14bot.RemoteWindows;
using TreeSharp;

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
            var selectRecipe = new Action(a => CraftingManager.SetRecipe(100));
            var canCast = new Decorator(s => CraftingManager.AnimationLocked, new Sleep(1000));
            var canCraft = new Decorator(s => CanICraftIt(), StopBot("Can't Craft the item. Stopping!"));
            var beginSynth = new Action(a =>
            {
                Character.CurrentRecipeLvl = CraftingManager.CurrentRecipe.RecipeLevel;
                Mend.Available = true;
                CraftingLog.Synthesize();
            });
            var continueSynth = new Decorator(s => CraftingManager.IsCrafting, Strategy.GetComposite());
            return new PrioritySelector(new Sleep(350), canCast, continueSynth, canCraft, beginSynth);
        }

        public static Composite StopBot(string reason)
        {
            return new Action(a =>
            {
                Logging.Write(reason);
                TreeRoot.Stop();
                return RunStatus.Success;
            });
        }

        private static bool CanICraftIt()
        {
            return !CraftingManager.CanCraft;
        }

        private static Composite WaitForAnimation()
        {
            return new Action(a =>
            {
                if (CraftingManager.AnimationLocked)
                {
                    return RunStatus.Running;
                }
                return RunStatus.Success;
            });
        }
    }
}