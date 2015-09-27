using ff14bot.Enums;
using ff14bot.Objects;
using TreeSharp;
using Action = TreeSharp.Action;

namespace crafty.Ability
{
    public static class Synth
    {
        static readonly ClassSynths[] Jobs = {
            new ClassSynths(ClassJobType.Armorer, 100030, 100037),
            new ClassSynths(ClassJobType.Alchemist, 100090, 100096),
            new ClassSynths(ClassJobType.Blacksmith, 100015, 100021),
            new ClassSynths(ClassJobType.Carpenter, 100001, 100007),
            new ClassSynths(ClassJobType.Culinarian, 100105, 100111),
            new ClassSynths(ClassJobType.Goldsmith, 100075, 100080),
            new ClassSynths(ClassJobType.Leatherworker, 100045, 100051),
            new ClassSynths(ClassJobType.Weaver, 100060, 100067)
            };

        private struct ClassSynths
        {
            public ClassJobType Job;
            public uint Synth1;
            public uint Synth2;

        public ClassSynths(ClassJobType job, uint synth1, uint synth2)
            {
                this.Job = job;
                this.Synth1 = synth1;
                this.Synth2 = synth2;
            }
        }

        public static SpellData GetBestBasic()
        {
            uint x = 0;
            foreach (ClassSynths c in Jobs)
            {
                if (c.Job == ff14bot.Core.Me.CurrentJob)
                {
                    if (ff14bot.Managers.Actionmanager.CurrentActions.ContainsKey(c.Synth2))
                    {
                        x = c.Synth2;
                        break;
                    }
                    if (ff14bot.Managers.Actionmanager.CurrentActions.ContainsKey(c.Synth1))
                    {
                        x = c.Synth1;
                        break;
                    }
                }
            }
            SpellData spell;
            ff14bot.Managers.DataManager.SpellCache.TryGetValue(x, out spell);
            return spell;
        }


        public static Composite UseSynth()
        {
            return new Action(r =>
            {
                ff14bot.Managers.Actionmanager.DoAction(GetBestBasic(), null);

            }
            ); 
        }
    }
}
