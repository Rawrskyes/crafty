using ff14bot.Enums;

namespace crafty.Ability
{
    public static class Buff
    {
        struct ClassBuffs
        {
            public ClassJobType Job;
            public uint Steady;

            ClassBuffs(ClassJobType job, uint steady)
            {
                this.Job = job;
                this.Steady = steady;
            }
        }

        public readonly ClassBuffs[] Jobs =
        {
            new ClassBuffs(ClassJobType.Blacksmith, 245),
            new ClassBuffs(ClassJobType.Armorer, 
        }
    }
}
