namespace PointSale
{
    partial class Build
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
            this.database = new System.Windows.Forms.Button();
            this.pos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // database
            // 
            this.database.Location = new System.Drawing.Point(473, 200);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(256, 44);
            this.database.TabIndex = 0;
            this.database.Text = "Database Management";
            this.database.UseVisualStyleBackColor = true;
            this.database.Click += new System.EventHandler(this.database_Click);
            // 
            // pos
            // 
            this.pos.Location = new System.Drawing.Point(125, 193);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(179, 51);
            this.pos.TabIndex = 1;
            this.pos.Text = "Point of Sale";
            this.pos.UseVisualStyleBackColor = true;
            this.pos.Click += new System.EventHandler(this.pos_Click);
            // 
            // Build
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pos);
            this.Controls.Add(this.database);
            this.Name = "Build";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Build";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button database;
        private System.Windows.Forms.Button pos;
    }
}