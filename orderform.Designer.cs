namespace crafty
{
    partial class orderform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        ///<param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addbtn = new System.Windows.Forms.Button();
            this.orderlistview = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Job = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rembtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemtxt = new System.Windows.Forms.TextBox();
            this.qtytxt = new System.Windows.Forms.TextBox();
            this.jobclasscombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.materialslist = new System.Windows.Forms.ListView();
            this.MissingItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MissingQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(12, 12);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(122, 23);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // orderlistview
            // 
            this.orderlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Item,
            this.Qty,
            this.Job});
            this.orderlistview.Location = new System.Drawing.Point(277, 12);
            this.orderlistview.MultiSelect = false;
            this.orderlistview.Name = "orderlistview";
            this.orderlistview.Size = new System.Drawing.Size(400, 409);
            this.orderlistview.TabIndex = 2;
            this.orderlistview.UseCompatibleStateImageBehavior = false;
            this.orderlistview.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 190;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.Width = 47;
            // 
            // Job
            // 
            this.Job.Text = "Job";
            this.Job.Width = 98;
            // 
            // rembtn
            // 
            this.rembtn.Location = new System.Drawing.Point(140, 12);
            this.rembtn.Name = "rembtn";
            this.rembtn.Size = new System.Drawing.Size(132, 23);
            this.rembtn.TabIndex = 3;
            this.rembtn.Text = "Remove";
            this.rembtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Qty";
            // 
            // itemtxt
            // 
            this.itemtxt.Location = new System.Drawing.Point(12, 54);
            this.itemtxt.Name = "itemtxt";
            this.itemtxt.Size = new System.Drawing.Size(175, 20);
            this.itemtxt.TabIndex = 6;
            // 
            // qtytxt
            // 
            this.qtytxt.Location = new System.Drawing.Point(193, 54);
            this.qtytxt.Name = "qtytxt";
            this.qtytxt.Size = new System.Drawing.Size(79, 20);
            this.qtytxt.TabIndex = 7;
            // 
            // jobclasscombo
            // 
            this.jobclasscombo.FormattingEnabled = true;
            this.jobclasscombo.Items.AddRange(new object[] {
            "Alchemist",
            "Armorer",
            "Blacksmith",
            "Carpenter",
            "Cullinarian",
            "Goldsmith",
            "Leatherworker",
            "Weaver"});
            this.jobclasscombo.Location = new System.Drawing.Point(129, 76);
            this.jobclasscombo.Margin = new System.Windows.Forms.Padding(2);
            this.jobclasscombo.Name = "jobclasscombo";
            this.jobclasscombo.Size = new System.Drawing.Size(144, 21);
            this.jobclasscombo.TabIndex = 9;
            this.jobclasscombo.SelectedValueChanged += new System.EventHandler(this.jobclasscombo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Job/Class";
            // 
            // materialslist
            // 
            this.materialslist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MissingItem,
            this.MissingQty});
            this.materialslist.Location = new System.Drawing.Point(8, 190);
            this.materialslist.Margin = new System.Windows.Forms.Padding(2);
            this.materialslist.Name = "materialslist";
            this.materialslist.Size = new System.Drawing.Size(265, 231);
            this.materialslist.TabIndex = 11;
            this.materialslist.UseCompatibleStateImageBehavior = false;
            this.materialslist.View = System.Windows.Forms.View.Details;
            // 
            // MissingItem
            // 
            this.MissingItem.Text = "Item";
            this.MissingItem.Width = 200;
            // 
            // MissingQty
            // 
            this.MissingQty.Text = "Qty";
            this.MissingQty.Width = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Missing Materials";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(47, 135);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(185, 28);
            this.btnCheck.TabIndex = 13;
            this.btnCheck.Text = "Re-check Materials";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // orderform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 428);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.materialslist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jobclasscombo);
            this.Controls.Add(this.qtytxt);
            this.Controls.Add(this.itemtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rembtn);
            this.Controls.Add(this.orderlistview);
            this.Controls.Add(this.addbtn);
            this.Name = "orderform";
            this.Text = "Orders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.orderform_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.ListView orderlistview;
        private System.Windows.Forms.Button rembtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemtxt;
        private System.Windows.Forms.TextBox qtytxt;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader Job;
        private System.Windows.Forms.ComboBox jobclasscombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView materialslist;
        private System.Windows.Forms.ColumnHeader MissingItem;
        private System.Windows.Forms.ColumnHeader MissingQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ColumnHeader ID;
    }
}