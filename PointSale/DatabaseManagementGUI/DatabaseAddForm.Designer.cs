namespace PointSale
{
    partial class DatabaseAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addItem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.upcBox = new System.Windows.Forms.TextBox();
            this.itemNameBox = new System.Windows.Forms.TextBox();
            this.itemDescriptionBox = new System.Windows.Forms.TextBox();
            this.itemBuyCostBox = new System.Windows.Forms.TextBox();
            this.itemSellPriceBox = new System.Windows.Forms.TextBox();
            this.itemNumberHaveBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(651, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sell Price";
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(583, 392);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(161, 42);
            this.addItem.TabIndex = 5;
            this.addItem.Text = "Add Item";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Inventory";
            // 
            // upcBox
            // 
            this.upcBox.Location = new System.Drawing.Point(10, 114);
            this.upcBox.Name = "upcBox";
            this.upcBox.Size = new System.Drawing.Size(120, 31);
            this.upcBox.TabIndex = 7;
            // 
            // itemNameBox
            // 
            this.itemNameBox.Location = new System.Drawing.Point(161, 114);
            this.itemNameBox.Name = "itemNameBox";
            this.itemNameBox.Size = new System.Drawing.Size(114, 31);
            this.itemNameBox.TabIndex = 8;
            // 
            // itemDescriptionBox
            // 
            this.itemDescriptionBox.Location = new System.Drawing.Point(298, 114);
            this.itemDescriptionBox.Name = "itemDescriptionBox";
            this.itemDescriptionBox.Size = new System.Drawing.Size(181, 31);
            this.itemDescriptionBox.TabIndex = 9;
            // 
            // itemBuyCostBox
            // 
            this.itemBuyCostBox.Location = new System.Drawing.Point(495, 114);
            this.itemBuyCostBox.Name = "itemBuyCostBox";
            this.itemBuyCostBox.Size = new System.Drawing.Size(114, 31);
            this.itemBuyCostBox.TabIndex = 10;
            // 
            // itemSellPriceBox
            // 
            this.itemSellPriceBox.Location = new System.Drawing.Point(615, 114);
            this.itemSellPriceBox.Name = "itemSellPriceBox";
            this.itemSellPriceBox.Size = new System.Drawing.Size(173, 31);
            this.itemSellPriceBox.TabIndex = 11;
            // 
            // itemNumberHaveBox
            // 
            this.itemNumberHaveBox.Location = new System.Drawing.Point(316, 274);
            this.itemNumberHaveBox.Name = "itemNumberHaveBox";
            this.itemNumberHaveBox.Size = new System.Drawing.Size(163, 31);
            this.itemNumberHaveBox.TabIndex = 12;
            // 
            // DatabaseAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.upcBox);
            this.Controls.Add(this.itemNumberHaveBox);
            this.Controls.Add(this.itemSellPriceBox);
            this.Controls.Add(this.itemBuyCostBox);
            this.Controls.Add(this.itemDescriptionBox);
            this.Controls.Add(this.itemNameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DatabaseAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatabaseAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox upcBox;
        private System.Windows.Forms.TextBox itemNameBox;
        private System.Windows.Forms.TextBox itemDescriptionBox;
        private System.Windows.Forms.TextBox itemBuyCostBox;
        private System.Windows.Forms.TextBox itemSellPriceBox;
        private System.Windows.Forms.TextBox itemNumberHaveBox;
    }
}