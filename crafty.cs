using ff14bot.AClasses;
using System;
using System.Collections.Generic;
using ff14bot.Behavior;
using TreeSharp;
using ff14bot.Helpers;

namespace crafty
{
    public class Crafty : BotBase
    {
        private Composite _root;
        public orderform OrderForm;
        public static List<Order> OrderList = new List<Order>();
        public struct Order
        {
            public uint ItemId;
            public uint Qty;
            public string ItemName;
            public ff14bot.Enums.ClassJobType Job;

            public Order(uint itemid, string itemname, uint qty, ff14bot.Enums.ClassJobType job)
            {
                this.ItemId = itemid;
                this.Qty = qty;
                this.Job = job;
                this.ItemName = itemname;
            }
        }

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
