using ff14bot.Enums;
using TreeSharp;

namespace crafty.Ability
{
    public static class Buff
    {
        public struct ClassBuffs
        {
            public ClassJobType Job;
            public uint Steady;

            public ClassBuffs(ClassJobType job, uint steady)
            {
                this.Job = job;
                this.Steady = steady;
            }
        }

        static readonly ClassBuffs[] Jobs =
        {
            new ClassBuffs(ClassJobType.Blacksmith, 245),
            new ClassBuffs(ClassJobType.Armorer, 246),
            new ClassBuffs(ClassJobType.Carpenter, 244),
            new ClassBuffs(ClassJobType.Goldsmith, 247),
            new ClassBuffs(ClassJobType.Weaver, 248),
            new ClassBuffs(ClassJobType.Leatherworker, 249),
            new ClassBuffs(ClassJobType.Alchemist, 250),
            new ClassBuffs(ClassJobType.Culinarian, 251)
        };

        public static ClassBuffs GetJobSkills()
        {
            foreach (ClassBuffs c in Jobs)
            {
                if (c.Job == ff14bot.Core.Me.CurrentJob)
                    return c;
            }
            //Need to return something if we're not the correct job;
            return new ClassBuffs();
        }

        public static Composite GetSteadyAction()
        {
            return new Action(a =>
            {
                ff14bot.Managers.Actionmanager.DoAction(GetJobSkills().Steady, null);
            });
        }

        public static bool SteadyRequired()
        {
            if(ff14bot.Core.Me.GetAuraByName("Steady Hand")== null)
            {
                return true;
            }
            return false;
        }
    }
}
