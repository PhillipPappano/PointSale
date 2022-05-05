namespace PointSale
{
    partial class UpdateDatabaseForm
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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.test = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BuyCostBox = new System.Windows.Forms.TextBox();
            this.SellValueBox = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(333, 294);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(113, 51);
            this.UpdateButton.TabIndex = 0;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(26, 115);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(140, 31);
            this.NameBox.TabIndex = 1;
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(47, 70);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(68, 25);
            this.test.TabIndex = 2;
            this.test.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "BuyCost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "SaleValue";
            // 
            // BuyCostBox
            // 
            this.BuyCostBox.Location = new System.Drawing.Point(427, 115);
            this.BuyCostBox.Name = "BuyCostBox";
            this.BuyCostBox.Size = new System.Drawing.Size(140, 31);
            this.BuyCostBox.TabIndex = 6;
            // 
            // SellValueBox
            // 
            this.SellValueBox.Location = new System.Drawing.Point(623, 115);
            this.SellValueBox.Name = "SellValueBox";
            this.SellValueBox.Size = new System.Drawing.Size(140, 31);
            this.SellValueBox.TabIndex = 7;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.AcceptsReturn = true;
            this.DescriptionBox.Location = new System.Drawing.Point(189, 115);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(217, 143);
            this.DescriptionBox.TabIndex = 8;
            // 
            // UpdateDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.SellValueBox);
            this.Controls.Add(this.BuyCostBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.test);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.UpdateButton);
            this.Name = "UpdateDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateDatabaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BuyCostBox;
        private System.Windows.Forms.TextBox SellValueBox;
        private System.Windows.Forms.TextBox DescriptionBox;
    }
}