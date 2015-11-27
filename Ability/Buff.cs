using ff14bot;
using ff14bot.Enums;
using ff14bot.Managers;
using TreeSharp;

namespace crafty.Ability
{
    public static class Buff
    {
        private static readonly ClassBuffs[] Jobs =
        {
            new ClassBuffs(ClassJobType.Blacksmith, 245, 253),
            new ClassBuffs(ClassJobType.Armorer, 246, 254),
            new ClassBuffs(ClassJobType.Carpenter, 244, 252),
            new ClassBuffs(ClassJobType.Goldsmith, 247, 255),
            new ClassBuffs(ClassJobType.Weaver, 248, 256),
            new ClassBuffs(ClassJobType.Leatherworker, 249, 257),
            new ClassBuffs(ClassJobType.Alchemist, 250, 258),
            new ClassBuffs(ClassJobType.Culinarian, 251, 259)
        };

        public static ClassBuffs GetJobSkills()
        {
            foreach (var c in Jobs)
            {
                if (c.Job == Core.Me.CurrentJob)
                    return c;
            }
            //Need to return something if we're not the correct job;
            return new ClassBuffs();
        }

        public static Composite GetSteadyAction()
        {
            return new Action(a => { Actionmanager.DoAction(GetJobSkills().Steady, null); });
        }

        public static bool SteadyRequired()
        {
            //Level check first
            if (Core.Me.ClassLevel < 9)
                return false;

            if (Core.Me.GetAuraByName("Steady Hand") == null && Core.Me.CurrentCP > 91)
            {
                return true;
            }
            return false;
        }

        public static bool InnerQuietAvail()
        {
            //If we've already got the aura. It might as well not be available.
            if (Core.Me.GetAuraByName("Inner Quiet") != null)
                return false;

            //If we're not at the right level we shouldn't cast either!
            if (Core.Me.ClassLevel < 11)
                return false;

            //We don't want inner quiet if we aren't expecting to progress the quality
            var prog = Character.GetExpectedProgress(Character.CurrentRecipeLvl);
            var attempts = CraftingManager.DurabilityCap/10;
            if (attempts <= 4)
            {
                attempts += 3;
            }
            else
            {
                attempts += 6;
            }

            if (attempts*prog < CraftingManager.ProgressRequired)
                return false;

            //Above math isn't perfect. But it'll do for now. Maybe I'll scrap it altogether if it's not worth.


            if (Actionmanager.CurrentActions.ContainsKey(GetJobSkills().Inner))
            {
                return true;
            }
            return false;
        }

        public static Composite GetInnerQuietAction()
        {
            return new Action(a => { Actionmanager.DoAction(GetJobSkills().Inner, null); });
        }

        public struct ClassBuffs
        {
            public readonly ClassJobType Job;
            public readonly uint Steady;
            public readonly uint Inner;

            public ClassBuffs(ClassJobType job, uint steady, uint inner)
            {
                Job = job;
                Steady = steady;
                Inner = inner;
            }
        }
    }
}