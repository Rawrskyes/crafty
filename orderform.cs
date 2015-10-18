using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ff14bot.Enums;

namespace crafty
{
    public partial class Orderform : Form
    {
        private ClassJobType _job = ClassJobType.Adventurer;

        public Orderform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_job == ClassJobType.Adventurer)
            {
                MessageBox.Show("Please select a job!");
                return;
            }

            var r = Recipes.Recipes.getRecipe(itemtxt.Text, _job);

            if (r.Id == 0)
            {
                MessageBox.Show("Recipe not found. Please check your spelling");
                return;
            }

            if (uint.Parse(qtytxt.Text) == 0)
            {
                MessageBox.Show("Please enter a quantity.");
                return;
            }

            string[] row = {r.Id.ToString(), r.Name, qtytxt.Text, jobclasscombo.Text};
            var canCraftIt = Materials.FetchMaterials(r.Id, uint.Parse(qtytxt.Text), ExpandMaterials());
            if (canCraftIt)
            {
                orderlistview.Items.Add(new ListViewItem(row));
                ReloadMaterials();
            }
            else
            {
                MessageBox.Show("We don't know that recipe!");
            }
        }

        public void AddOrder(uint id, string name, uint qty, string jobclass)
        {
            string[] row = {id.ToString(), name, qty.ToString(), jobclass};
            orderlistview.Items.Add(new ListViewItem(row));
        }

        public List<Crafty.Order> GetOrders()
        {
            var numitems = orderlistview.Items.Count;
            var o = new List<Crafty.Order>();
            foreach (ListViewItem row in orderlistview.Items)
            {
                uint itemid, qty;
                uint.TryParse(row.SubItems[0].Text, out itemid);
                uint.TryParse(row.SubItems[2].Text, out qty);
                var j = getClassJobType(row.SubItems[3].Text);
                var itemname = row.SubItems[1].Text;
                o.Add(new Crafty.Order(itemid, itemname, qty, j));
            }
            return o;
        }

        private void orderform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private ClassJobType getClassJobType(string j)
        {
            var result = ClassJobType.Adventurer;
            if (j == "Alchemist") result = ClassJobType.Alchemist;
            if (j == "Armorer") result = ClassJobType.Armorer;
            if (j == "Blacksmith") result = ClassJobType.Blacksmith;
            if (j == "Carpenter") result = ClassJobType.Carpenter;
            if (j == "Culinarian") result = ClassJobType.Culinarian;
            if (j == "Goldsmith") result = ClassJobType.Goldsmith;
            if (j == "Leatherworker") result = ClassJobType.Leatherworker;
            if (j == "Weaver") result = ClassJobType.Weaver;
            return result;
        }

        private void jobclasscombo_TextChanged(object sender, EventArgs e)
        {
            _job = getClassJobType(jobclasscombo.SelectedItem.ToString());
        }

        private void ReloadMaterials()
        {
            materialslist.Items.Clear();
            Materials.CountStock();
            var mats = Materials.GetList();
            foreach (var m in mats)
            {
                //Add it if we don't have enough materials.
                if (m.Qty < m.Qtyreq)
                {
                    var qtyrem = m.Qtyreq - m.Qty;
                    string[] row = {m.Itemname, qtyrem.ToString()};
                    materialslist.Items.Add(new ListViewItem(row));
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            ClearAndReload();
        }

        private void rembtn_Click(object sender, EventArgs e)
        {
            orderlistview.SelectedItems[0].Remove();
        }

        private void ClearAndReload()
        {
            Materials.ClearList();
            foreach (ListViewItem row in orderlistview.Items)
            {
                var itemid = uint.Parse(row.SubItems[0].Text);
                var qty = uint.Parse(row.SubItems[2].Text);
                Materials.FetchMaterials(itemid, qty);
            }
            ReloadMaterials();
        }

        private bool ExpandMaterials()
        {
            return expCheckBox.Checked;
        }

        public uint CountOrders(string name)
        {
            uint result = 0;
            foreach (ListViewItem i in orderlistview.Items)
            {
                if (i.SubItems[1].Text.Equals(name))
                {
                    result += uint.Parse(i.SubItems[2].Text);
                }
            }
            return result;
        }
    }
}