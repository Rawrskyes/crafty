using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ff14bot.Objects;
using ff14bot.Enums;
using InTheHand.Net.Bluetooth;

namespace crafty.Ability
{
    public static class Mend
    {
        private struct ClassMends
        {
            public ClassJobType Job;
            public uint Mend1;
            public uint Mend2;

            public ClassMends(ClassJobType j, uint mend1, uint mend2)
            {
                this.Job = j;
                this.Mend1 = mend1;
                this.Mend2 = mend2;
            }
        }

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


        public static bool ShouldMend()
        {
            if (ff14bot.Managers.CraftingManager.Durability == 10)
            {
                return true;
            }
            return false;
        }

        public static SpellData GetBestMend()
        {
            uint x = 0;
            foreach (ClassMends c in Jobs)
            {
                if (c.Job == ff14bot.Core.Me.CurrentJob)
                {
                    if (ff14bot.Managers.Actionmanager.CurrentActions.ContainsKey(c.Mend2))
                    {
                        x = c.Mend2;
                        break;
                    }
                    if (ff14bot.Managers.Actionmanager.CurrentActions.ContainsKey(c.Mend1))
                    {
                        x = c.Mend1;
                        break;
                    }
                }
            }
            SpellData spell;
            ff14bot.Managers.DataManager.SpellCache.TryGetValue(x, out spell);
            return spell;
        }
    }
}
