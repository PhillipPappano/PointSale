namespace PointSale
{
    partial class paymentSystem
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
            this.cashButton = new System.Windows.Forms.Button();
            this.cardButton = new System.Windows.Forms.Button();
            this.costOfItems = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.cancelSaleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cashButton
            // 
            this.cashButton.Location = new System.Drawing.Point(87, 168);
            this.cashButton.Name = "cashButton";
            this.cashButton.Size = new System.Drawing.Size(163, 49);
            this.cashButton.TabIndex = 0;
            this.cashButton.Text = "Pay By Cash";
            this.cashButton.UseVisualStyleBackColor = true;
            this.cashButton.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // cardButton
            // 
            this.cardButton.Location = new System.Drawing.Point(536, 168);
            this.cardButton.Name = "cardButton";
            this.cardButton.Size = new System.Drawing.Size(163, 49);
            this.cardButton.TabIndex = 1;
            this.cardButton.Text = "Pay By Card";
            this.cardButton.UseVisualStyleBackColor = true;
            this.cardButton.Click += new System.EventHandler(this.cardButton_Click);
            // 
            // costOfItems
            // 
            this.costOfItems.Location = new System.Drawing.Point(313, 320);
            this.costOfItems.Name = "costOfItems";
            this.costOfItems.Size = new System.Drawing.Size(164, 31);
            this.costOfItems.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Payment";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(295, 67);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(66, 25);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Total:";
            // 
            // cancelSaleButton
            // 
            this.cancelSaleButton.Location = new System.Drawing.Point(625, 389);
            this.cancelSaleButton.Name = "cancelSaleButton";
            this.cancelSaleButton.Size = new System.Drawing.Size(163, 49);
            this.cancelSaleButton.TabIndex = 5;
            this.cancelSaleButton.Text = "Cancel";
            this.cancelSaleButton.UseVisualStyleBackColor = true;
            this.cancelSaleButton.Click += new System.EventHandler(this.cancelSaleButton_Click);
            // 
            // paymentSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelSaleButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costOfItems);
            this.Controls.Add(this.cardButton);
            this.Controls.Add(this.cashButton);
            this.Name = "paymentSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paymentSystem";
            this.Load += new System.EventHandler(this.paymentSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cashButton;
        private System.Windows.Forms.Button cardButton;
        private System.Windows.Forms.TextBox costOfItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button cancelSaleButton;
    }
}