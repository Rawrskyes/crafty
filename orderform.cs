using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crafty
{
    public partial class orderform : Form
    {
        public orderform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] row = { itemtxt.Text, qtytxt.Text };
            orderlistview.Items.Add(new ListViewItem(row));
        }

        public List<Crafty.Order> getOrders()
        {
            int numitems = orderlistview.Items.Count;
            List<Crafty.Order> o = new List<Crafty.Order>();
            foreach (ListViewItem row in this.orderlistview.Items)
            {
                int item, qty;
                int.TryParse(row.SubItems[0].Text, out item);
                int.TryParse(row.SubItems[1].Text, out qty);
                o.Add(new Crafty.Order(item, qty));
            }
            return o;
        }

        private void orderform_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide(); 
            e.Cancel = true;
        }
    }
}
