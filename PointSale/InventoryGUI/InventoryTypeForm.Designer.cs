namespace PointSale
{
    partial class InventoryTypeForm
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
            this.AddInventoryButton = new System.Windows.Forms.Button();
            this.MonthlyInventoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddInventoryButton
            // 
            this.AddInventoryButton.Location = new System.Drawing.Point(105, 153);
            this.AddInventoryButton.Name = "AddInventoryButton";
            this.AddInventoryButton.Size = new System.Drawing.Size(174, 65);
            this.AddInventoryButton.TabIndex = 0;
            this.AddInventoryButton.Text = "Add Inventory";
            this.AddInventoryButton.UseVisualStyleBackColor = true;
            this.AddInventoryButton.Click += new System.EventHandler(this.AddInventoryButton_Click);
            // 
            // MonthlyInventoryButton
            // 
            this.MonthlyInventoryButton.Location = new System.Drawing.Point(476, 153);
            this.MonthlyInventoryButton.Name = "MonthlyInventoryButton";
            this.MonthlyInventoryButton.Size = new System.Drawing.Size(174, 65);
            this.MonthlyInventoryButton.TabIndex = 1;
            this.MonthlyInventoryButton.Text = "Monthly Inventory";
            this.MonthlyInventoryButton.UseVisualStyleBackColor = true;
            this.MonthlyInventoryButton.Click += new System.EventHandler(this.MonthlyInventoryButton_Click);
            // 
            // InventoryTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MonthlyInventoryButton);
            this.Controls.Add(this.AddInventoryButton);
            this.Name = "InventoryTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Type";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddInventoryButton;
        private System.Windows.Forms.Button MonthlyInventoryButton;
    }
}