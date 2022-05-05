namespace PointSale
{
    partial class MonthlyInventoryForm
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
            this.UPCRecordBox = new System.Windows.Forms.TextBox();
            this.UPCCheckedBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UPCCheckBox = new System.Windows.Forms.TextBox();
            this.UPCCheckButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ExcelExportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UPCRecordBox
            // 
            this.UPCRecordBox.Location = new System.Drawing.Point(791, 119);
            this.UPCRecordBox.Name = "UPCRecordBox";
            this.UPCRecordBox.ReadOnly = true;
            this.UPCRecordBox.Size = new System.Drawing.Size(210, 31);
            this.UPCRecordBox.TabIndex = 0;
            // 
            // UPCCheckedBox
            // 
            this.UPCCheckedBox.Location = new System.Drawing.Point(791, 311);
            this.UPCCheckedBox.Name = "UPCCheckedBox";
            this.UPCCheckedBox.ReadOnly = true;
            this.UPCCheckedBox.Size = new System.Drawing.Size(210, 31);
            this.UPCCheckedBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(812, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Items Recorded";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(770, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Items Checked";
            // 
            // UPCCheckBox
            // 
            this.UPCCheckBox.Location = new System.Drawing.Point(53, 198);
            this.UPCCheckBox.Name = "UPCCheckBox";
            this.UPCCheckBox.Size = new System.Drawing.Size(210, 31);
            this.UPCCheckBox.TabIndex = 4;
            this.UPCCheckBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UPCCheckBox_KeyDown);
            // 
            // UPCCheckButton
            // 
            this.UPCCheckButton.Location = new System.Drawing.Point(306, 182);
            this.UPCCheckButton.Name = "UPCCheckButton";
            this.UPCCheckButton.Size = new System.Drawing.Size(156, 63);
            this.UPCCheckButton.TabIndex = 5;
            this.UPCCheckButton.Text = "Add/Check Item";
            this.UPCCheckButton.UseVisualStyleBackColor = true;
            this.UPCCheckButton.Click += new System.EventHandler(this.UPCCheckButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Item Check";
            // 
            // ExcelExportButton
            // 
            this.ExcelExportButton.Location = new System.Drawing.Point(495, 481);
            this.ExcelExportButton.Name = "ExcelExportButton";
            this.ExcelExportButton.Size = new System.Drawing.Size(156, 63);
            this.ExcelExportButton.TabIndex = 7;
            this.ExcelExportButton.Text = "Export Excel";
            this.ExcelExportButton.UseVisualStyleBackColor = true;
            this.ExcelExportButton.Click += new System.EventHandler(this.ExcelExportButton_Click);
            // 
            // MonthlyInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 609);
            this.Controls.Add(this.ExcelExportButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UPCCheckButton);
            this.Controls.Add(this.UPCCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UPCCheckedBox);
            this.Controls.Add(this.UPCRecordBox);
            this.Name = "MonthlyInventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonthlyInventoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UPCRecordBox;
        private System.Windows.Forms.TextBox UPCCheckedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UPCCheckBox;
        private System.Windows.Forms.Button UPCCheckButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ExcelExportButton;
    }
}