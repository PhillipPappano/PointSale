namespace PointSale
{
    partial class AddInventoryForm
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
            this.UpcSearchBox = new System.Windows.Forms.TextBox();
            this.UpcSearchButton = new System.Windows.Forms.Button();
            this.ItemNumHaveNowBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UpcAddBox = new System.Windows.Forms.TextBox();
            this.UpcAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpcSearchBox
            // 
            this.UpcSearchBox.Location = new System.Drawing.Point(74, 82);
            this.UpcSearchBox.Name = "UpcSearchBox";
            this.UpcSearchBox.Size = new System.Drawing.Size(227, 31);
            this.UpcSearchBox.TabIndex = 0;
            this.UpcSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpcSearchBox_KeyDown);
            // 
            // UpcSearchButton
            // 
            this.UpcSearchButton.Location = new System.Drawing.Point(358, 48);
            this.UpcSearchButton.Name = "UpcSearchButton";
            this.UpcSearchButton.Size = new System.Drawing.Size(242, 72);
            this.UpcSearchButton.TabIndex = 1;
            this.UpcSearchButton.Text = "Search";
            this.UpcSearchButton.UseVisualStyleBackColor = true;
            this.UpcSearchButton.Click += new System.EventHandler(this.UpcSearchButton_Click);
            // 
            // ItemNumHaveNowBox
            // 
            this.ItemNumHaveNowBox.Location = new System.Drawing.Point(734, 89);
            this.ItemNumHaveNowBox.Name = "ItemNumHaveNowBox";
            this.ItemNumHaveNowBox.ReadOnly = true;
            this.ItemNumHaveNowBox.Size = new System.Drawing.Size(219, 31);
            this.ItemNumHaveNowBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "UPC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(761, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Items You Have";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "UPC";
            // 
            // UpcAddBox
            // 
            this.UpcAddBox.Location = new System.Drawing.Point(74, 227);
            this.UpcAddBox.Name = "UpcAddBox";
            this.UpcAddBox.Size = new System.Drawing.Size(227, 31);
            this.UpcAddBox.TabIndex = 5;
            this.UpcAddBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpcAddBox_KeyDown);
            // 
            // UpcAddButton
            // 
            this.UpcAddButton.Location = new System.Drawing.Point(358, 206);
            this.UpcAddButton.Name = "UpcAddButton";
            this.UpcAddButton.Size = new System.Drawing.Size(242, 72);
            this.UpcAddButton.TabIndex = 7;
            this.UpcAddButton.Text = "Search";
            this.UpcAddButton.UseVisualStyleBackColor = true;
            this.UpcAddButton.Click += new System.EventHandler(this.UpcAddButton_Click);
            // 
            // AddInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 457);
            this.Controls.Add(this.UpcAddButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UpcAddBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemNumHaveNowBox);
            this.Controls.Add(this.UpcSearchButton);
            this.Controls.Add(this.UpcSearchBox);
            this.Name = "AddInventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UpcSearchBox;
        private System.Windows.Forms.Button UpcSearchButton;
        private System.Windows.Forms.TextBox ItemNumHaveNowBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UpcAddBox;
        private System.Windows.Forms.Button UpcAddButton;
    }
}