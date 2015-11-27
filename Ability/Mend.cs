using ff14bot;
using ff14bot.Enums;
using ff14bot.Managers;
using ff14bot.Objects;
using TreeSharp;

namespace crafty.Ability
{
    public static class Mend
    {
        private static readonly ClassMends[] Jobs =
        {
            new ClassMends(ClassJobType.Armorer, 100032, 100035),
            new ClassMends(ClassJobType.Alchemist, 100092, 100094),
            new ClassMends(ClassJobType.Blacksmith, 100017, 100019),
            new ClassMends(ClassJobType.Carpenter, 100003, 100005),
            new ClassMends(ClassJobType.Culinarian, 100107, 100110),
            new ClassMends(ClassJobType.Goldsmith, 100077, 100079),
            new ClassMends(ClassJobType.Leatherworker, 100047, 100049),
            new ClassMends(ClassJobType.Weaver, 100062, 100065)
        };

        public static bool Available;

        public static bool ShouldMend()
        {
            if (CraftingManager.Durability == 10 && Core.Me.ClassLevel >= 7)
            {
                return true;
            }
            return false;
        }

        public static SpellData GetBestMend()
        {
            uint x = 0;
            foreach (var c in Jobs)
            {
                if (c.Job == Core.Me.CurrentJob)
                {
                    if (Actionmanager.CurrentActions.ContainsKey(c.Mend2) && CraftingManager.DurabilityCap > 40 &&
                        Actionmanager.CanCast(c.Mend2, null))
                    {
                        x = c.Mend2;
                        break;
                    }
                    if (Actionmanager.CurrentActions.ContainsKey(c.Mend1) && Actionmanager.CanCast(c.Mend1, null))
                    {
                        x = c.Mend1;
                        break;
                    }
                }
            }
            SpellData spell;
            DataManager.SpellCache.TryGetValue(x, out spell);
            return spell;
        }

        public static Composite UseBestMend()
        {
            return new Action(a =>
            {
                Actionmanager.DoAction(GetBestMend(), null);
                Available = false;
            });
        }

        private struct ClassMends
        {
            public readonly ClassJobType Job;
            public readonly uint Mend1;
            public readonly uint Mend2;

            public ClassMends(ClassJobType j, uint mend1, uint mend2)
            {
                Job = j;
                Mend1 = mend1;
                Mend2 = mend2;
            }
        }
    }
}