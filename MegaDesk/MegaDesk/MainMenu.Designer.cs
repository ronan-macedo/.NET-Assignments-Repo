namespace MegaDesk
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.addQuote = new System.Windows.Forms.Button();
            this.viewQuotes = new System.Windows.Forms.Button();
            this.searchQuotes = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 80);
            this.label1.TabIndex = 1;
            // 
            // addQuote
            // 
            this.addQuote.BackColor = System.Drawing.Color.White;
            this.addQuote.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuote.ForeColor = System.Drawing.Color.SaddleBrown;
            this.addQuote.Location = new System.Drawing.Point(320, 130);
            this.addQuote.Name = "addQuote";
            this.addQuote.Size = new System.Drawing.Size(150, 50);
            this.addQuote.TabIndex = 0;
            this.addQuote.Text = "&Add New Quote";
            this.addQuote.UseVisualStyleBackColor = false;
            this.addQuote.Click += new System.EventHandler(this.addQuote_Click);
            // 
            // viewQuotes
            // 
            this.viewQuotes.BackColor = System.Drawing.Color.White;
            this.viewQuotes.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuotes.ForeColor = System.Drawing.Color.SaddleBrown;
            this.viewQuotes.Location = new System.Drawing.Point(320, 193);
            this.viewQuotes.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.viewQuotes.Name = "viewQuotes";
            this.viewQuotes.Size = new System.Drawing.Size(150, 50);
            this.viewQuotes.TabIndex = 1;
            this.viewQuotes.Text = "&View Quotes";
            this.viewQuotes.UseVisualStyleBackColor = false;
            this.viewQuotes.Click += new System.EventHandler(this.viewQuotes_Click);
            // 
            // searchQuotes
            // 
            this.searchQuotes.BackColor = System.Drawing.Color.White;
            this.searchQuotes.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotes.ForeColor = System.Drawing.Color.SaddleBrown;
            this.searchQuotes.Location = new System.Drawing.Point(320, 256);
            this.searchQuotes.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.searchQuotes.Name = "searchQuotes";
            this.searchQuotes.Size = new System.Drawing.Size(150, 50);
            this.searchQuotes.TabIndex = 2;
            this.searchQuotes.Text = "&Search Quotes";
            this.searchQuotes.UseVisualStyleBackColor = false;
            this.searchQuotes.Click += new System.EventHandler(this.searchQuotes_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.exit.Location = new System.Drawing.Point(320, 319);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(150, 50);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.searchQuotes);
            this.Controls.Add(this.viewQuotes);
            this.Controls.Add(this.addQuote);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ronan Macedo - MegaDesk";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addQuote;
        private System.Windows.Forms.Button viewQuotes;
        private System.Windows.Forms.Button searchQuotes;
        private System.Windows.Forms.Button exit;
    }
}

