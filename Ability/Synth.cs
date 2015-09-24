using ff14bot.Enums;
using ff14bot.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeSharp;
using Action = TreeSharp.Action;

namespace crafty.Ability
{
    public static class Synth
    {
        private const uint standard_synth = 100037;
        private const uint basic_synth = 100030;
        static uint[] ids = { 100037, 100030 };
        static Class_Synths[] jobs = {
            new Class_Synths(ClassJobType.Armorer, 100030, 100037),
            new Class_Synths(ClassJobType.Alchemist, 100090, 100096),
            new Class_Synths(ClassJobType.Blacksmith, 100015, 100021),
            new Class_Synths(ClassJobType.Carpenter, 100001, 100007),
            new Class_Synths(ClassJobType.Culinarian, 100105, 100111),
            new Class_Synths(ClassJobType.Goldsmith, 100075, 100080),
            new Class_Synths(ClassJobType.Leatherworker, 100045, 100051),
            new Class_Synths(ClassJobType.Weaver, 100060, 100067)
            };

        public struct Class_Synths
        {
            public ClassJobType job;
            public uint synth1;
            public uint synth2;

        public Class_Synths(ClassJobType job, uint synth1, uint synth2)
            {
                this.job = job;
                this.synth1 = synth1;
                this.synth2 = synth2;
            }
        }

        public SpellData getBestBasic()
        {
            foreach(Class_Synths c in jobs)
            {
                return c;
            }
        }


        public static Composite UseSynth()
        {
            SpellData Spell_Data;
            ff14bot.Managers.DataManager.SpellCache.TryGetValue(basic_synth, out Spell_Data);
            return new Action(r => ff14bot.Managers.Actionmanager.DoAction(Spell_Data, null)); 
        }
    }
}
