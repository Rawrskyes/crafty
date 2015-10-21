using System;
using System.Collections.Generic;
using ff14bot.AClasses;
using ff14bot.Behavior;
using ff14bot.Enums;
using ff14bot.Helpers;
using TreeSharp;

namespace crafty
{
    public class Crafty : BotBase
    {
        public static Orderform OrderForm;
        public static List<Order> OrderList = new List<Order>();
        private Composite _root;

        public override bool RequiresProfile
        {
            get { return false; }
        }

        public override string Name
        {
            get { return "Crafty"; }
        }

        public override PulseFlags PulseFlags
        {
            get { return PulseFlags.All; }
        }

        public override bool WantButton
        {
            get { return true; }
        }


        public override Composite Root
        {
            get
            {
                //OrderList = OrderForm.getOrders();
                return _root ?? (_root = CraftyComposite.GetBase());
            }
        }

        public override void OnButtonPress()
        {
            if (OrderForm == null || OrderForm.IsDisposed)
            {
                OrderForm = new Orderform();
            }
            try
            {
                OrderForm.Show();
                OrderForm.Activate();
            }
            catch (ArgumentOutOfRangeException e)
            {
                Logging.Write("Error displaying the OrderForm!!");
                Logging.Write(e.ToString());
            }
        }

        public struct Order
        {
            public uint ItemId;
            public uint Qty;
            public string ItemName;
            public ClassJobType Job;

            public Order(uint itemid, string itemname, uint qty, ClassJobType job)
            {
                ItemId = itemid;
                Qty = qty;
                Job = job;
                ItemName = itemname;
            }
        }
    }
}