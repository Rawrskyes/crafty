using System;
using crafty.Ability;
using ff14bot;
using ff14bot.Helpers;
using ff14bot.Managers;
using ff14bot.RemoteWindows;
using System.Collections.Generic;
using System.Threading.Tasks;
using TreeSharp;
using Action = TreeSharp.Action;
using ff14bot.Enums;

namespace crafty
{
    internal static class CraftyComposite
    {
        public static List<Crafty.Order> Orders = new List<Crafty.Order>();
        
        public static Composite GetBase()
        {
            Orders = Crafty.OrderForm.GetOrders(); // Get what we want to craft

            //Pace the selector
            var sleep = new Sleep(350);
            
            //Animation Locked
            var animationLocked = new Decorator(condition => CraftingManager.AnimationLocked, new Sleep(1000));

            //Currently Synthing
            var continueSynth = new Decorator(condition => CraftingManager.IsCrafting, Strategy.GetComposite());

            //Orders Empty Check
            var ordersEmpty = new Decorator(condition => CheckOrdersEmpty(), StopBot("Looks like we've completed all the orders!"));

            //Incorrect Job
            var correctJob = new Decorator(condition => Character.ChangeRequired(Orders[0].Job), Character.ChangeJob(Orders[0].Job));

            //Recipe not Selected
            var selectRecipe = new Decorator(condition => IsRecipeSet(Orders[0].ItemId), new ActionRunCoroutine(action => SetRecipeTask(Orders[0].ItemId)));

            //Can't Craft the item
            var cantCraft = new Decorator(condition => CanICraftIt(), StopBot("Can't craft the item " + Orders[0].ItemName + ". Stopping!"));

            //Begin crafting
            var beginCrafting = BeginSynthAction();

            var mainrepeater = new 

            //Base Composite that we'll return
            return new PrioritySelector(sleep, animationLocked, continueSynth, ordersEmpty, correctJob, selectRecipe, cantCraft, beginCrafting);


            /*
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
            */
        }

        private static Action BeginSynthAction()
        {
            return new Action(act =>
            {
                Character.CurrentRecipeLvl = CraftingManager.CurrentRecipe.RecipeLevel;
                Mend.Available = true;
                CraftingLog.Synthesize();
                Orders[0].Qty--;
                Logging.Write("Crafting " + Orders[0].ItemName + ". Remaining: " + Orders[0].Qty);
            });
        }

        private static bool CheckOrdersEmpty()
        {
            while (Orders[0].Qty == 0)
            {
                Orders.RemoveAt(0);
                if (Orders.Count == 0) return true;
            }
            return false;
        }

        private static Composite AddBlankOrder()
        {
            return new Action(a =>
            {
                if (Orders.Count == 0)
                {
                    Orders.Add(new Crafty.Order(0, "Orders Empty", 0, ClassJobType.Adventurer));
                    //Adding an item if it's blank.
                }
            });
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

    }
}