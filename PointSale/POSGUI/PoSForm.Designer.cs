namespace PointSale
{
    partial class PoSForm
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
            this.upcBox = new System.Windows.Forms.TextBox();
            this.addItem = new System.Windows.Forms.Button();
            this.finalizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // upcBox
            // 
            this.upcBox.Location = new System.Drawing.Point(21, 84);
            this.upcBox.Name = "upcBox";
            this.upcBox.Size = new System.Drawing.Size(162, 31);
            this.upcBox.TabIndex = 0;
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(21, 132);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(162, 46);
            this.addItem.TabIndex = 1;
            this.addItem.Text = "Add Item";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // finalizeButton
            // 
            this.finalizeButton.Location = new System.Drawing.Point(577, 357);
            this.finalizeButton.Name = "finalizeButton";
            this.finalizeButton.Size = new System.Drawing.Size(162, 46);
            this.finalizeButton.TabIndex = 2;
            this.finalizeButton.Text = "Finalize";
            this.finalizeButton.UseVisualStyleBackColor = true;
            this.finalizeButton.Click += new System.EventHandler(this.finalizeButton_Click);
            // 
            // PoSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finalizeButton);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.upcBox);
            this.Name = "PoSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PoSForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox upcBox;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Button finalizeButton;
    }
}