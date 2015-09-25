using TreeSharp;
using ff14bot.Managers;
using ff14bot.Helpers;
using System.Collections.Generic;
using crafty.Ability;
using ff14bot.Enums;

namespace crafty
{
    internal class CraftyComposite
    {
        public static Composite GetBase()
        {
            //List<Crafty.Order> orders
            //foreach(Crafty.Order o in orders)
            // {
            //     Logging.Write("Order item: " + o.Item + ". Qty Required: " + o.Qty);
            // }
            var selectRecipe = new Action(a=>CraftingManager.SetRecipe(100));
            var canCast = new Decorator(s=> CraftingManager.AnimationLocked, new Sleep(300));
            var canCraft = new Decorator(s=>CanICraftIt(), StopBot("Can't Craft the item. Stopping!"));
            var beginSynth = new Action(a=>ff14bot.RemoteWindows.CraftingLog.Synthesize());
            var continueSynth = new Decorator(s=> CraftingManager.IsCrafting, Synth.UseSynth());
            return new PrioritySelector(new Sleep(300), canCast, continueSynth, canCraft, beginSynth);
        }

       static Composite StopBot(string reason)
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
            return CraftingManager.CanCraft ? false : true;
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