using crafty.Recipes;
using ff14bot.Enums;
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

        private ClassJobType job = ClassJobType.Adventurer;

        private void button1_Click(object sender, EventArgs e)
        {
            if(job == ClassJobType.Adventurer)
            {
                MessageBox.Show("Please select a job!");
                return;
            }

            recipes.Recipe r = recipes.getRecipe(itemtxt.Text, job);

            if(r.Id == 0)
            {
                MessageBox.Show("Recipe not found. Please check your spelling");
                return;
            }

            string[] row = {r.Name, qtytxt.Text, jobclasscombo.Text, r.Id.ToString()};
            orderlistview.Items.Add(new ListViewItem(row));
        }

        public List<Crafty.Order> getOrders()
        {
            int numitems = orderlistview.Items.Count;
            List<Crafty.Order> o = new List<Crafty.Order>();
            foreach (ListViewItem row in this.orderlistview.Items)
            {
                uint itemid, qty;
                uint.TryParse(row.SubItems[0].Text, out itemid);
                uint.TryParse(row.SubItems[2].Text, out qty);
                ClassJobType j = getClassJobType(row.SubItems[3].Text);
                string itemname = row.SubItems[1].Text;
                o.Add(new Crafty.Order(itemid, itemname, qty, j));
            }
            return o;
        }

        private void orderform_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void orderlistview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void jobclasscombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Alchemist , Armorer, Blacksmith, Carpenter, Cullinarian, Goldsmith, Leatherworker, Weaver */
            job = getClassJobType(this.Text);
        }

        private ClassJobType getClassJobType(string j)
        {
            ClassJobType result = ClassJobType.Adventurer;
            if (j == "Alchemist") result = ClassJobType.Alchemist;
            if (j == "Armorer") result = ClassJobType.Armorer;
            if (j == "Blacksmith") result = ClassJobType.Blacksmith;
            if (j == "Carpenter") result = ClassJobType.Carpenter;
            if (j == "Cullinarian") result = ClassJobType.Culinarian;
            if (j == "Goldsmith") result = ClassJobType.Goldsmith;
            if (j == "Leatherworker") result = ClassJobType.Leatherworker;
            if (j == "Weaver") result = ClassJobType.Weaver;
            return result;
        }
    }
}
