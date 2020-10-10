namespace MegaDesk
{
    partial class SearchQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchQuotes));
            this.lblDevelop = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDevelop
            // 
            this.lblDevelop.AutoSize = true;
            this.lblDevelop.Location = new System.Drawing.Point(12, 9);
            this.lblDevelop.Name = "lblDevelop";
            this.lblDevelop.Size = new System.Drawing.Size(102, 13);
            this.lblDevelop.TabIndex = 0;
            this.lblDevelop.Text = "Under Development";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.SaddleBrown;
            this.back.Location = new System.Drawing.Point(618, 408);
            this.back.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(150, 30);
            this.back.TabIndex = 7;
            this.back.Text = "&Return to Main Menu";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.Controls.Add(this.back);
            this.Controls.Add(this.lblDevelop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Quotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDevelop;
        private System.Windows.Forms.Button back;
    }
}