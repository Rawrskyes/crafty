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
        public orderform orderform;
        public List<order> orderlist = new List<order>();
        public struct order
        {
            public int item;
            public int qty;

            public order(int item, int qty)
            {
                this.item = item;
                this.qty = qty;
            }
        }

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

        public override bool WantButton
        {
            get
            {
                return true;
            }
        }

        public override void OnButtonPress()
        {
            if (orderform == null || orderform.IsDisposed)
            {
                orderform = new orderform();
            }
            try
            {
                orderform.Show();
                orderform.Activate();
            } catch (ArgumentOutOfRangeException e)
            {
                Logging.Write("Error displaying the orderform!!");
                Logging.Write(e.ToString());
            }
        }


        public override Composite Root
        {
            get
            {
                orderlist = orderform.getOrders();
                return root_ ?? (root_ = CraftyComposite.getBase(orderlist));
            }
        }

    }
}
