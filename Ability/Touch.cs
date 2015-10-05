using ff14bot.Enums;
using ff14bot.Managers;
using ff14bot.Objects;
using TreeSharp;

namespace crafty.Ability
{
    static class Touch
    {
        private struct ClassTouch
        {
            public ClassJobType Job;
            public uint Touch1;
            public uint Touch2;
            public uint Touch3;

            public ClassTouch(ClassJobType job, uint touch1, uint touch2, uint touch3)
            {
                this.Job = job;
                this.Touch1 = touch1;
                this.Touch2 = touch2;
                this.Touch3 = touch3;
            }
        }
        static readonly ClassTouch[] Jobs = {
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
            foreach (ClassTouch c in Jobs)
            {
                if (c.Job == ff14bot.Core.Me.CurrentJob)
                {
                    if (Actionmanager.CurrentActions.ContainsKey(c.Touch3) && Actionmanager.CanCast(c.Touch3, null))
                    {
                        x = c.Touch3;
                        break;
                    }
                    if (Actionmanager.CurrentActions.ContainsKey(c.Touch2) && Actionmanager.CanCast(c.Touch2, null))
                    {
                        x = c.Touch2;
                        break;
                    }
                    if (Actionmanager.CurrentActions.ContainsKey(c.Touch2) && Actionmanager.CanCast(c.Touch1, null))
                    {
                        x = c.Touch2;
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
            return new TreeSharp.Action(a =>
            {
                Actionmanager.DoAction(GetBestTouch(), null);
            });
        }

    }
}
