﻿using crafty.Ability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ff14bot.Managers;
using TreeSharp;

namespace crafty
{
    static class Strategy
    {
        public static Composite GetComposite()
        {
          
          return Synth.UseSynth();
        }
    }
}
