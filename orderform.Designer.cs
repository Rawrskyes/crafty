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
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rembtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemtxt = new System.Windows.Forms.TextBox();
            this.qtytxt = new System.Windows.Forms.TextBox();
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
            this.Item,
            this.Qty});
            this.orderlistview.Location = new System.Drawing.Point(12, 80);
            this.orderlistview.MultiSelect = false;
            this.orderlistview.Name = "orderlistview";
            this.orderlistview.Size = new System.Drawing.Size(260, 169);
            this.orderlistview.TabIndex = 2;
            this.orderlistview.UseCompatibleStateImageBehavior = false;
            this.orderlistview.View = System.Windows.Forms.View.Details;
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 177;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.Width = 79;
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
            // orderform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
    }
}