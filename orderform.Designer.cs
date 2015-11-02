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
            this.maintabs = new System.Windows.Forms.TabControl();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.lbljobs = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCul = new System.Windows.Forms.Label();
            this.lblAlch = new System.Windows.Forms.Label();
            this.lblWeav = new System.Windows.Forms.Label();
            this.lblLeather = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblArm = new System.Windows.Forms.Label();
            this.lblBsm = new System.Windows.Forms.Label();
            this.lblCarp = new System.Windows.Forms.Label();
            this.numCul = new System.Windows.Forms.NumericUpDown();
            this.numAlch = new System.Windows.Forms.NumericUpDown();
            this.numWeav = new System.Windows.Forms.NumericUpDown();
            this.numLtw = new System.Windows.Forms.NumericUpDown();
            this.numGold = new System.Windows.Forms.NumericUpDown();
            this.numArm = new System.Windows.Forms.NumericUpDown();
            this.numBsm = new System.Windows.Forms.NumericUpDown();
            this.numCarp = new System.Windows.Forms.NumericUpDown();
            this.maintabs.SuspendLayout();
            this.tabOrders.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLtw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBsm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarp)).BeginInit();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(12, 9);
            this.addbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(183, 35);
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
            this.orderlistview.Location = new System.Drawing.Point(410, 9);
            this.orderlistview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderlistview.MultiSelect = false;
            this.orderlistview.Name = "orderlistview";
            this.orderlistview.Size = new System.Drawing.Size(607, 681);
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
            this.rembtn.Location = new System.Drawing.Point(204, 9);
            this.rembtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rembtn.Name = "rembtn";
            this.rembtn.Size = new System.Drawing.Size(198, 35);
            this.rembtn.TabIndex = 3;
            this.rembtn.Text = "Remove";
            this.rembtn.UseVisualStyleBackColor = true;
            this.rembtn.Click += new System.EventHandler(this.rembtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Qty";
            // 
            // itemtxt
            // 
            this.itemtxt.Location = new System.Drawing.Point(12, 74);
            this.itemtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemtxt.Name = "itemtxt";
            this.itemtxt.Size = new System.Drawing.Size(260, 26);
            this.itemtxt.TabIndex = 6;
            // 
            // qtytxt
            // 
            this.qtytxt.Location = new System.Drawing.Point(284, 74);
            this.qtytxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.qtytxt.Name = "qtytxt";
            this.qtytxt.Size = new System.Drawing.Size(116, 26);
            this.qtytxt.TabIndex = 7;
            // 
            // jobclasscombo
            // 
            this.jobclasscombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.jobclasscombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.jobclasscombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.jobclasscombo.Location = new System.Drawing.Point(188, 108);
            this.jobclasscombo.Name = "jobclasscombo";
            this.jobclasscombo.Size = new System.Drawing.Size(214, 28);
            this.jobclasscombo.TabIndex = 9;
            this.jobclasscombo.SelectedValueChanged += new System.EventHandler(this.jobclasscombo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
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
            this.materialslist.Location = new System.Drawing.Point(6, 283);
            this.materialslist.Name = "materialslist";
            this.materialslist.Size = new System.Drawing.Size(396, 407);
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
            this.label4.Location = new System.Drawing.Point(130, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Missing Materials";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(64, 198);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(278, 43);
            this.btnCheck.TabIndex = 13;
            this.btnCheck.Text = "Re-check Materials";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // expCheckBox
            // 
            this.expCheckBox.AutoSize = true;
            this.expCheckBox.Location = new System.Drawing.Point(12, 157);
            this.expCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.expCheckBox.Name = "expCheckBox";
            this.expCheckBox.Size = new System.Drawing.Size(190, 24);
            this.expCheckBox.TabIndex = 14;
            this.expCheckBox.Text = "Auto-Expand Recipes";
            this.expCheckBox.UseVisualStyleBackColor = true;
            // 
            // maintabs
            // 
            this.maintabs.Controls.Add(this.tabOrders);
            this.maintabs.Controls.Add(this.tabSettings);
            this.maintabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maintabs.Location = new System.Drawing.Point(0, 0);
            this.maintabs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maintabs.Name = "maintabs";
            this.maintabs.SelectedIndex = 0;
            this.maintabs.Size = new System.Drawing.Size(1040, 743);
            this.maintabs.TabIndex = 15;
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
            this.tabOrders.Location = new System.Drawing.Point(4, 29);
            this.tabOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabOrders.Size = new System.Drawing.Size(1032, 710);
            this.tabOrders.TabIndex = 0;
            this.tabOrders.Text = "Orders";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.lbljobs);
            this.tabSettings.Controls.Add(this.groupBox1);
            this.tabSettings.Location = new System.Drawing.Point(4, 29);
            this.tabSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSettings.Size = new System.Drawing.Size(1032, 710);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // lbljobs
            // 
            this.lbljobs.Location = new System.Drawing.Point(31, 400);
            this.lbljobs.Name = "lbljobs";
            this.lbljobs.Size = new System.Drawing.Size(224, 73);
            this.lbljobs.TabIndex = 17;
            this.lbljobs.Text = "Please set the gearset numbers above. If you don\'t know a job, leave it at \'0\'.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCul);
            this.groupBox1.Controls.Add(this.lblAlch);
            this.groupBox1.Controls.Add(this.lblWeav);
            this.groupBox1.Controls.Add(this.lblLeather);
            this.groupBox1.Controls.Add(this.lblGold);
            this.groupBox1.Controls.Add(this.lblArm);
            this.groupBox1.Controls.Add(this.lblBsm);
            this.groupBox1.Controls.Add(this.lblCarp);
            this.groupBox1.Controls.Add(this.numCul);
            this.groupBox1.Controls.Add(this.numAlch);
            this.groupBox1.Controls.Add(this.numWeav);
            this.groupBox1.Controls.Add(this.numLtw);
            this.groupBox1.Controls.Add(this.numGold);
            this.groupBox1.Controls.Add(this.numArm);
            this.groupBox1.Controls.Add(this.numBsm);
            this.groupBox1.Controls.Add(this.numCarp);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(279, 386);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gearsets";
            // 
            // lblCul
            // 
            this.lblCul.AutoSize = true;
            this.lblCul.Location = new System.Drawing.Point(32, 325);
            this.lblCul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCul.Name = "lblCul";
            this.lblCul.Size = new System.Drawing.Size(79, 20);
            this.lblCul.TabIndex = 15;
            this.lblCul.Text = "Culinarian";
            // 
            // lblAlch
            // 
            this.lblAlch.AutoSize = true;
            this.lblAlch.Location = new System.Drawing.Point(32, 285);
            this.lblAlch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlch.Name = "lblAlch";
            this.lblAlch.Size = new System.Drawing.Size(78, 20);
            this.lblAlch.TabIndex = 14;
            this.lblAlch.Text = "Alchemist";
            // 
            // lblWeav
            // 
            this.lblWeav.AutoSize = true;
            this.lblWeav.Location = new System.Drawing.Point(32, 245);
            this.lblWeav.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeav.Name = "lblWeav";
            this.lblWeav.Size = new System.Drawing.Size(63, 20);
            this.lblWeav.TabIndex = 13;
            this.lblWeav.Text = "Weaver";
            // 
            // lblLeather
            // 
            this.lblLeather.AutoSize = true;
            this.lblLeather.Location = new System.Drawing.Point(32, 205);
            this.lblLeather.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeather.Name = "lblLeather";
            this.lblLeather.Size = new System.Drawing.Size(111, 20);
            this.lblLeather.TabIndex = 12;
            this.lblLeather.Text = "Leatherworker";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(32, 165);
            this.lblGold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(81, 20);
            this.lblGold.TabIndex = 11;
            this.lblGold.Text = "Goldsmith";
            // 
            // lblArm
            // 
            this.lblArm.AutoSize = true;
            this.lblArm.Location = new System.Drawing.Point(32, 125);
            this.lblArm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArm.Name = "lblArm";
            this.lblArm.Size = new System.Drawing.Size(66, 20);
            this.lblArm.TabIndex = 10;
            this.lblArm.Text = "Armorer";
            // 
            // lblBsm
            // 
            this.lblBsm.AutoSize = true;
            this.lblBsm.Location = new System.Drawing.Point(32, 85);
            this.lblBsm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBsm.Name = "lblBsm";
            this.lblBsm.Size = new System.Drawing.Size(86, 20);
            this.lblBsm.TabIndex = 9;
            this.lblBsm.Text = "Blacksmith";
            // 
            // lblCarp
            // 
            this.lblCarp.AutoSize = true;
            this.lblCarp.Location = new System.Drawing.Point(32, 45);
            this.lblCarp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarp.Name = "lblCarp";
            this.lblCarp.Size = new System.Drawing.Size(80, 20);
            this.lblCarp.TabIndex = 8;
            this.lblCarp.Text = "Carpenter";
            // 
            // numCul
            // 
            this.numCul.Location = new System.Drawing.Point(171, 325);
            this.numCul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numCul.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numCul.Name = "numCul";
            this.numCul.Size = new System.Drawing.Size(72, 26);
            this.numCul.TabIndex = 7;
            // 
            // numAlch
            // 
            this.numAlch.Location = new System.Drawing.Point(171, 285);
            this.numAlch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numAlch.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numAlch.Name = "numAlch";
            this.numAlch.Size = new System.Drawing.Size(72, 26);
            this.numAlch.TabIndex = 6;
            // 
            // numWeav
            // 
            this.numWeav.Location = new System.Drawing.Point(171, 245);
            this.numWeav.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numWeav.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numWeav.Name = "numWeav";
            this.numWeav.Size = new System.Drawing.Size(72, 26);
            this.numWeav.TabIndex = 5;
            // 
            // numLtw
            // 
            this.numLtw.Location = new System.Drawing.Point(171, 205);
            this.numLtw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numLtw.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numLtw.Name = "numLtw";
            this.numLtw.Size = new System.Drawing.Size(72, 26);
            this.numLtw.TabIndex = 4;
            // 
            // numGold
            // 
            this.numGold.Location = new System.Drawing.Point(171, 165);
            this.numGold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numGold.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numGold.Name = "numGold";
            this.numGold.Size = new System.Drawing.Size(72, 26);
            this.numGold.TabIndex = 3;
            // 
            // numArm
            // 
            this.numArm.Location = new System.Drawing.Point(171, 125);
            this.numArm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numArm.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numArm.Name = "numArm";
            this.numArm.Size = new System.Drawing.Size(72, 26);
            this.numArm.TabIndex = 2;
            // 
            // numBsm
            // 
            this.numBsm.Location = new System.Drawing.Point(171, 85);
            this.numBsm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numBsm.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numBsm.Name = "numBsm";
            this.numBsm.Size = new System.Drawing.Size(72, 26);
            this.numBsm.TabIndex = 1;
            // 
            // numCarp
            // 
            this.numCarp.Location = new System.Drawing.Point(171, 45);
            this.numCarp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numCarp.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numCarp.Name = "numCarp";
            this.numCarp.Size = new System.Drawing.Size(72, 26);
            this.numCarp.TabIndex = 0;
            // 
            // Orderform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 743);
            this.Controls.Add(this.maintabs);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Orderform";
            this.Text = "Orders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.orderform_FormClosing);
            this.maintabs.ResumeLayout(false);
            this.tabOrders.ResumeLayout(false);
            this.tabOrders.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLtw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBsm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarp)).EndInit();
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
        private System.Windows.Forms.TabControl maintabs;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCul;
        private System.Windows.Forms.Label lblAlch;
        private System.Windows.Forms.Label lblWeav;
        private System.Windows.Forms.Label lblLeather;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblArm;
        private System.Windows.Forms.Label lblBsm;
        private System.Windows.Forms.Label lblCarp;
        private System.Windows.Forms.NumericUpDown numCul;
        private System.Windows.Forms.NumericUpDown numAlch;
        private System.Windows.Forms.NumericUpDown numWeav;
        private System.Windows.Forms.NumericUpDown numLtw;
        private System.Windows.Forms.NumericUpDown numGold;
        private System.Windows.Forms.NumericUpDown numArm;
        private System.Windows.Forms.NumericUpDown numBsm;
        private System.Windows.Forms.NumericUpDown numCarp;
        private System.Windows.Forms.Label lbljobs;
    }
}