namespace crafty
{
    partial class Orderform
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
            this.expCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabOrders.SuspendLayout();
            this.tabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(8, 6);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(122, 23);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // orderlistview
            // 
            this.orderlistview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Item,
            this.Qty,
            this.Job});
            this.orderlistview.FullRowSelect = true;
            this.orderlistview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.orderlistview.Location = new System.Drawing.Point(273, 6);
            this.orderlistview.MultiSelect = false;
            this.orderlistview.Name = "orderlistview";
            this.orderlistview.Size = new System.Drawing.Size(406, 444);
            this.orderlistview.TabIndex = 8;
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
            this.rembtn.Location = new System.Drawing.Point(136, 6);
            this.rembtn.Name = "rembtn";
            this.rembtn.Size = new System.Drawing.Size(132, 23);
            this.rembtn.TabIndex = 3;
            this.rembtn.Text = "Remove";
            this.rembtn.UseVisualStyleBackColor = true;
            this.rembtn.Click += new System.EventHandler(this.rembtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Qty";
            // 
            // itemtxt
            // 
            this.itemtxt.Location = new System.Drawing.Point(8, 48);
            this.itemtxt.Name = "itemtxt";
            this.itemtxt.Size = new System.Drawing.Size(175, 20);
            this.itemtxt.TabIndex = 6;
            // 
            // qtytxt
            // 
            this.qtytxt.Location = new System.Drawing.Point(189, 48);
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
            "Culinarian",
            "Goldsmith",
            "Leatherworker",
            "Weaver"});
            this.jobclasscombo.Location = new System.Drawing.Point(125, 70);
            this.jobclasscombo.Margin = new System.Windows.Forms.Padding(2);
            this.jobclasscombo.Name = "jobclasscombo";
            this.jobclasscombo.Size = new System.Drawing.Size(144, 21);
            this.jobclasscombo.TabIndex = 9;
            this.jobclasscombo.SelectedValueChanged += new System.EventHandler(this.jobclasscombo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Job/Class";
            // 
            // materialslist
            // 
            this.materialslist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialslist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MissingItem,
            this.MissingQty});
            this.materialslist.FullRowSelect = true;
            this.materialslist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialslist.Location = new System.Drawing.Point(4, 184);
            this.materialslist.Margin = new System.Windows.Forms.Padding(2);
            this.materialslist.Name = "materialslist";
            this.materialslist.Size = new System.Drawing.Size(265, 266);
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
            this.label4.Location = new System.Drawing.Point(87, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Missing Materials";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(43, 129);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(185, 28);
            this.btnCheck.TabIndex = 13;
            this.btnCheck.Text = "Re-check Materials";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // expCheckBox
            // 
            this.expCheckBox.AutoSize = true;
            this.expCheckBox.Location = new System.Drawing.Point(8, 102);
            this.expCheckBox.Name = "expCheckBox";
            this.expCheckBox.Size = new System.Drawing.Size(129, 17);
            this.expCheckBox.TabIndex = 14;
            this.expCheckBox.Text = "Auto-Expand Recipes";
            this.expCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOrders);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(693, 483);
            this.tabControl1.TabIndex = 15;
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.addbtn);
            this.tabOrders.Controls.Add(this.expCheckBox);
            this.tabOrders.Controls.Add(this.orderlistview);
            this.tabOrders.Controls.Add(this.btnCheck);
            this.tabOrders.Controls.Add(this.rembtn);
            this.tabOrders.Controls.Add(this.label4);
            this.tabOrders.Controls.Add(this.label1);
            this.tabOrders.Controls.Add(this.materialslist);
            this.tabOrders.Controls.Add(this.label2);
            this.tabOrders.Controls.Add(this.label3);
            this.tabOrders.Controls.Add(this.itemtxt);
            this.tabOrders.Controls.Add(this.jobclasscombo);
            this.tabOrders.Controls.Add(this.qtytxt);
            this.tabOrders.Location = new System.Drawing.Point(4, 22);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(685, 457);
            this.tabOrders.TabIndex = 0;
            this.tabOrders.Text = "Orders";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.groupBox1);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(685, 457);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(114, 29);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(114, 55);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown2.TabIndex = 1;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(114, 81);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown3.TabIndex = 2;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(114, 107);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown4.TabIndex = 3;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(114, 133);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown5.TabIndex = 4;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(114, 159);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown6.TabIndex = 5;
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(114, 185);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown7.TabIndex = 6;
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(114, 211);
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown8.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Carpenter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Blacksmith";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Armorer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Goldsmith";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Leatherworker";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Weaver";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Alchemist";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Culinarian";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDown8);
            this.groupBox1.Controls.Add(this.numericUpDown7);
            this.groupBox1.Controls.Add(this.numericUpDown6);
            this.groupBox1.Controls.Add(this.numericUpDown5);
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 251);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gearsets";
            // 
            // Orderform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 483);
            this.Controls.Add(this.tabControl1);
            this.Name = "Orderform";
            this.Text = "Orders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.orderform_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabOrders.ResumeLayout(false);
            this.tabOrders.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.CheckBox expCheckBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}