using ff14bot;
using ff14bot.Enums;
using ff14bot.Managers;
using ff14bot.Objects;
using TreeSharp;

namespace crafty.Ability
{
    internal static class Touch
    {
        private static readonly ClassTouch[] Jobs =
        {
            new ClassTouch(ClassJobType.Armorer, 100031, 100034, 100038),
            new ClassTouch(ClassJobType.Alchemist, 100091, 100093, 100097),
            new ClassTouch(ClassJobType.Blacksmith, 100016, 100018, 100022),
            new ClassTouch(ClassJobType.Carpenter, 100002, 100004, 100008),
            new ClassTouch(ClassJobType.Culinarian, 100106, 100109, 100112),
            new ClassTouch(ClassJobType.Goldsmith, 100076, 100078, 100081),
            new ClassTouch(ClassJobType.Leatherworker, 100046, 100048, 100052),
            new ClassTouch(ClassJobType.Weaver, 100061, 100064, 100068)
        };

        public static SpellData GetBestTouch()
        {
            uint x = 0;
            foreach (var c in Jobs)
            {
                if (c.Job == Core.Me.CurrentJob)
                {
                    if (ActionManager.CurrentActions.ContainsKey(c.Touch3) &&
                        (DataManager.GetSpellData(c.Touch3).Cost <= Core.Me.CurrentCP) &&
                        !Core.Me.HasAura("Steady Hand"))
                    {
                        x = c.Touch3;
                        break;
                    }
                    if (ActionManager.CurrentActions.ContainsKey(c.Touch2) &&
                        (DataManager.GetSpellData(c.Touch2).Cost <= Core.Me.CurrentCP))
                    {
                        x = c.Touch2;
                        break;
                    }
                    if (ActionManager.CurrentActions.ContainsKey(c.Touch1) &&
                        (DataManager.GetSpellData(c.Touch1).Cost <= Core.Me.CurrentCP))
                    {
                        x = c.Touch1;
                        break;
                    }
                }
            }
            SpellData spell;
            DataManager.SpellCache.TryGetValue(x, out spell);
            return spell;
        }

        public static Composite UseBestTouch()
        {
            return new Action(a => { ActionManager.DoAction(GetBestTouch(), null); });
        }

        private struct ClassTouch
        {
            public readonly ClassJobType Job;
            public readonly uint Touch1;
            public readonly uint Touch2;
            public readonly uint Touch3;

            public ClassTouch(ClassJobType job, uint touch1, uint touch2, uint touch3)
            {
                Job = job;
                Touch1 = touch1;
                Touch2 = touch2;
                Touch3 = touch3;
            }
        }
    }
}