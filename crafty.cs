using ff14bot.AClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ff14bot.Behavior;
using TreeSharp;
using ff14bot.Helpers;

namespace crafty
{
    public class crafty : BotBase
    {
        private Composite root_;

        public override string Name
        {
            get
            {
                return "Crafty 0.1";
            }
        }

        public override PulseFlags PulseFlags
        {
            get
            {
                return PulseFlags.All;
            }
        }

        public override Composite Root
        {
            get
            {
                return root_ ?? (root_ = CraftyComposite.getBase());
            }
        }

    }
}
