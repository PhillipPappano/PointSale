namespace PointSale
{
    partial class DatabaseForm
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
            this.addItem = new System.Windows.Forms.Button();
            this.changeItem = new System.Windows.Forms.Button();
            this.deleteItem = new System.Windows.Forms.Button();
            this.inventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(82, 201);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(118, 44);
            this.addItem.TabIndex = 0;
            this.addItem.Text = "Add Item";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // changeItem
            // 
            this.changeItem.Location = new System.Drawing.Point(277, 201);
            this.changeItem.Name = "changeItem";
            this.changeItem.Size = new System.Drawing.Size(154, 44);
            this.changeItem.TabIndex = 1;
            this.changeItem.Text = "Change Item";
            this.changeItem.UseVisualStyleBackColor = true;
            this.changeItem.Click += new System.EventHandler(this.changeItem_Click);
            // 
            // deleteItem
            // 
            this.deleteItem.Location = new System.Drawing.Point(534, 198);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(165, 47);
            this.deleteItem.TabIndex = 2;
            this.deleteItem.Text = "Delete Item";
            this.deleteItem.UseVisualStyleBackColor = true;
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // inventory
            // 
            this.inventory.Location = new System.Drawing.Point(277, 332);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(186, 49);
            this.inventory.TabIndex = 3;
            this.inventory.Text = "Inventory";
            this.inventory.UseVisualStyleBackColor = true;
            this.inventory.Click += new System.EventHandler(this.inventory_Click);
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.deleteItem);
            this.Controls.Add(this.changeItem);
            this.Controls.Add(this.addItem);
            this.Name = "DatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatabaseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Button changeItem;
        private System.Windows.Forms.Button deleteItem;
        private System.Windows.Forms.Button inventory;
    }
}