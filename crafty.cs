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
    public class Crafty : BotBase
    {
        private Composite _root;
        public orderform OrderForm;
        public List<Order> OrderList = new List<Order>();
        public struct Order
        {
            public int Item;
            public int Qty;

            public Order(int item, int qty)
            {
                this.Item = item;
                this.Qty = qty;
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
            if (OrderForm == null || OrderForm.IsDisposed)
            {
                OrderForm = new orderform();
            }
            try
            {
                OrderForm.Show();
                OrderForm.Activate();
            } catch (ArgumentOutOfRangeException e)
            {
                Logging.Write("Error displaying the OrderForm!!");
                Logging.Write(e.ToString());
            }
        }


        public override Composite Root
        {
            get
            {
                //OrderList = OrderForm.getOrders();
                return _root ?? (_root = CraftyComposite.GetBase());
            }
        }

    }
}
