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
using Clio.Utilities;
using ff14bot.Enums;
using ff14bot.NeoProfiles.Tags;

namespace crafty
{
    internal static class CraftyComposite
    {
        public static List<Crafty.Order> Orders = new List<Crafty.Order>();

        public static Composite GetBase()
        {
            Orders = Crafty.OrderForm.GetOrders(); // Get what we want to craft

            if (Orders.Count == 0)
            {
                Orders.Add(new Crafty.Order(0, "Orders Empty", 0, ClassJobType.Adventurer));
                //Adding an item if it's blank.
            }

            //Pace the selector
            var sleep = new Sleep(400);

            //Animation Locked
            var animationLocked = new Decorator(condition => CraftingManager.AnimationLocked, new Sleep(1000));

            //Currently Synthing
            var continueSynth = new Decorator(condition => CraftingManager.IsCrafting, Strategy.GetComposite());

            //Orders Empty Check
            var ordersEmpty = new Decorator(condition => CheckOrdersEmpty(), StopBot("Looks like we've completed all the orders!"));

            //Incorrect Job
            var correctJob = new Decorator(condition => Character.ChangeRequired(GetJob()), Character.ChangeJob());

            //Recipe not Selected
            var selectRecipe = new Decorator(condition => IsRecipeSet(GetID()), new ActionRunCoroutine(action => SetRecipeTask(GetID())));

            //Can't Craft the item
            //var cantCraft = new Decorator(condition => CanICraftIt(), StopBot("Can't craft the item " + GetName() + ". Stopping!"));

            //Begin crafting
            var beginCrafting = BeginSynthAction();

            //Base Composite that we'll return
            return new PrioritySelector(sleep, animationLocked, continueSynth, ordersEmpty, correctJob, selectRecipe, beginCrafting);


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

        public static ClassJobType GetJob()
        {
            return Orders[0].Job;
        }

        public static String GetName()
        {
            return Orders[0].ItemName;
        }

        public static uint GetID()
        {
            return Orders[0].ItemId;
        }

        public static Action BeginSynthAction()
        {
            return new ActionRunCoroutine(async act =>
            {
                Character.CurrentRecipeLvl = CraftingManager.CurrentRecipe.RecipeLevel;
                Mend.Available = true;
                var syn = new Synthesize();
                syn.RecipeId = CraftingManager.CurrentRecipeId;
                var hqitemcounts = new List<int>();
                hqitemcounts.Clear();
                foreach (var i in CraftingManager.CurrentRecipe.Ingredients)
                {
                    if (i.TotalNeeded > i.NqSelected)
                    {
                        hqitemcounts.Add(Math.Min(i.HqInInventory, (i.TotalNeeded - i.NqSelected)));
                    }
                    else
                    {
                        hqitemcounts.Add(0);
                    }
                        
                }
                syn.HQMats = hqitemcounts.ToArray();
                var result = await syn.StartCrafting();
                if (result)
                {
                    Orders[0].Qty--;
                    Logging.Write("Crafting " + Orders[0].ItemName + ". Remaining: " + Orders[0].Qty);
                }else
                {
                    StopBot("Can't craft the item " + GetName() + ". Stopping!");
                }
            });
        }

        private static bool CheckOrdersEmpty()
        {
            while (Orders[0].Qty == 0)
            {
                Logging.Write("Removed item from list");
                Orders.RemoveAt(0);
                if (Orders.Count == 0) return true;
            }
            return Orders.Count == 0;
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