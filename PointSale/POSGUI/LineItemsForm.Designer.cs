namespace PointSale
{
    partial class LineItemsForm
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
            this.lineItems = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lineItems
            // 
            this.lineItems.AcceptsReturn = true;
            this.lineItems.AcceptsTab = true;
            this.lineItems.Location = new System.Drawing.Point(12, 12);
            this.lineItems.Multiline = true;
            this.lineItems.Name = "lineItems";
            this.lineItems.ReadOnly = true;
            this.lineItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lineItems.Size = new System.Drawing.Size(776, 426);
            this.lineItems.TabIndex = 0;
            this.lineItems.WordWrap = false;
            this.lineItems.TextChanged += new System.EventHandler(this.lineItems_TextChanged);
            // 
            // LineItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lineItems);
            this.Name = "LineItemsForm";
            this.Text = "LineItemsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lineItems;
    }
}