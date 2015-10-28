using System;
using crafty.Ability;
using ff14bot;
using ff14bot.Helpers;
using ff14bot.Managers;
using ff14bot.RemoteWindows;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TreeSharp;
using Action = TreeSharp.Action;
using Buddy.Coroutines;

namespace crafty
{
    internal static class CraftyComposite
    {
        public static List<Crafty.Order> Orders = new List<Crafty.Order>();

        public static Composite GetBase()
        {
                //foreach(Crafty.Order o in orders)
                // {
                //     Logging.Write("Order item: " + o.Item + ". Qty Required: " + o.Qty);
                // }

            var setRecipeCoroutine = new ActionRunCoroutine(r=> SetRecipeTask(Orders[0].ItemId));
            var setRecipe = new Decorator(s=>IsRecipeSet(Orders[0].ItemId), setRecipeCoroutine);
                var canCast = new Decorator(s => CraftingManager.AnimationLocked, new Sleep(1000));
                var canCraft = new Decorator(s => CanICraftIt(), StopBot("Can't Craft the item. Stopping!"));
                var beginSynth = new Action(a =>
                {
                    Character.CurrentRecipeLvl = CraftingManager.CurrentRecipe.RecipeLevel;
                    Mend.Available = true;
                    CraftingLog.Synthesize();
                    Orders[0].Qty--;
                    Logging.Write("Crafting " + Orders[0].ItemName + ". Remaining: " + Orders[0].Qty);
                    while(Orders[0].Qty == 0)Orders.RemoveAt(0);
                });
                var continueSynth = new Decorator(s => CraftingManager.IsCrafting, Strategy.GetComposite());
                var correctJob = new Decorator(s => Character.ChangeRequired(Orders[0].Job),
                    Character.ChangeJob(Orders[0].Job));
                return new PrioritySelector(new Sleep(350), canCast, setRecipe, continueSynth,
                    correctJob, canCraft, beginSynth);
        }

        private static bool IsRecipeSet(uint id)
        {
            return CraftingManager.CurrentRecipeId != id;
        }

        internal static async Task<bool> SetRecipeTask(uint id)
        {
            return await CraftingManager.SetRecipe(id);
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