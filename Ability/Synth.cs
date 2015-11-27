using ff14bot;
using ff14bot.Enums;
using ff14bot.Managers;
using ff14bot.Objects;
using TreeSharp;

namespace crafty.Ability
{
    public static class Synth
    {
        private static readonly ClassSynths[] Jobs =
        {
            new ClassSynths(ClassJobType.Armorer, 100030, 100037),
            new ClassSynths(ClassJobType.Alchemist, 100090, 100096),
            new ClassSynths(ClassJobType.Blacksmith, 100015, 100021),
            new ClassSynths(ClassJobType.Carpenter, 100001, 100007),
            new ClassSynths(ClassJobType.Culinarian, 100105, 100111),
            new ClassSynths(ClassJobType.Goldsmith, 100075, 100080),
            new ClassSynths(ClassJobType.Leatherworker, 100045, 100051),
            new ClassSynths(ClassJobType.Weaver, 100060, 100067)
        };

        public static double GetFactor(uint spellId)
        {
            foreach (var j in Jobs)
            {
                if (j.Synth1 == spellId) return 1;
                if (j.Synth2 == spellId) return 1.5;
            }
            return 0;
        }

        public static SpellData GetBestBasic()
        {
            uint x = 0;
            foreach (var c in Jobs)
            {
                if (c.Job == Core.Me.CurrentJob)
                {
                    if (Actionmanager.CurrentActions.ContainsKey(c.Synth2) && Core.Me.CurrentCP >= DataManager.GetSpellData(c.Synth2).Cost)
                    {
                        x = c.Synth2;
                        break;
                    }
                    if (Actionmanager.CurrentActions.ContainsKey(c.Synth1) && Core.Me.CurrentCP >= DataManager.GetSpellData(c.Synth1).Cost)
                    {
                        x = c.Synth1;
                        break;
                    }
                }
            }
            SpellData spell;
            DataManager.SpellCache.TryGetValue(x, out spell);
            return spell;
        }


        public static Composite UseSynth()
        {
            return new Action(r => { Actionmanager.DoAction(GetBestBasic(), null); }
                );
        }

        public static bool ExpectFinish()
        {
            var prog = Character.GetExpectedProgress(Character.CurrentRecipeLvl);
            var factor = GetFactor(GetBestBasic().Id);
            var correctedProg = factor*prog;

            return correctedProg >=
                   (CraftingManager.ProgressRequired - CraftingManager.Progress);
        }

        private struct ClassSynths
        {
            public readonly ClassJobType Job;
            public readonly uint Synth1;
            public readonly uint Synth2;

            public ClassSynths(ClassJobType job, uint synth1, uint synth2)
            {
                Job = job;
                Synth1 = synth1;
                Synth2 = synth2;
            }
        }
    }
}