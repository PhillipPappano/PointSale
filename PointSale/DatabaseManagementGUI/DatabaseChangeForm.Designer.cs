namespace PointSale
{
    partial class DatabaseChangeForm
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
            this.searchUPCButton = new System.Windows.Forms.Button();
            this.searchBoxUPC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search UPC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchUPCButton
            // 
            this.searchUPCButton.Location = new System.Drawing.Point(220, 218);
            this.searchUPCButton.Name = "searchUPCButton";
            this.searchUPCButton.Size = new System.Drawing.Size(180, 44);
            this.searchUPCButton.TabIndex = 1;
            this.searchUPCButton.Text = "Search";
            this.searchUPCButton.UseVisualStyleBackColor = true;
            this.searchUPCButton.Click += new System.EventHandler(this.searchUPCButton_Click);
            // 
            // searchBoxUPC
            // 
            this.searchBoxUPC.Location = new System.Drawing.Point(192, 116);
            this.searchBoxUPC.Name = "searchBoxUPC";
            this.searchBoxUPC.Size = new System.Drawing.Size(243, 31);
            this.searchBoxUPC.TabIndex = 2;
            // 
            // DatabaseChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchBoxUPC);
            this.Controls.Add(this.searchUPCButton);
            this.Controls.Add(this.label1);
            this.Name = "DatabaseChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatabaseChangeForm";
            this.Load += new System.EventHandler(this.DatabaseChangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchUPCButton;
        private System.Windows.Forms.TextBox searchBoxUPC;
    }
}