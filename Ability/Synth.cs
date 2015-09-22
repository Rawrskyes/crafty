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


        public static Composite UseSynth()
        {
            SpellData Spell_Data;
            ff14bot.Managers.DataManager.SpellCache.TryGetValue(basic_synth, out Spell_Data);
            return new Action(r => ff14bot.Managers.Actionmanager.DoAction(Spell_Data, null)); 
        }
    }
}
