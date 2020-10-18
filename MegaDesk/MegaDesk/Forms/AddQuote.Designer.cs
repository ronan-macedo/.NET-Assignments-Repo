namespace MegaDesk
{
    partial class AddQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.deskWidth = new System.Windows.Forms.NumericUpDown();
            this.lblDepth = new System.Windows.Forms.Label();
            this.deskDepth = new System.Windows.Forms.NumericUpDown();
            this.lblDraw = new System.Windows.Forms.Label();
            this.deskDrawers = new System.Windows.Forms.NumericUpDown();
            this.lblMat = new System.Windows.Forms.Label();
            this.cmbMat = new System.Windows.Forms.ComboBox();
            this.lblRush = new System.Windows.Forms.Label();
            this.cmbRushDays = new System.Windows.Forms.ComboBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnBack.Location = new System.Drawing.Point(618, 408);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 30);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "&Return to Main Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(59, 59);
            this.lblName.Margin = new System.Windows.Forms.Padding(50, 50, 3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(200, 20);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Please, enter your name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(265, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 26);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Your Name";
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(59, 104);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(50, 25, 3, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(406, 20);
            this.lblDesc.TabIndex = 8;
            this.lblDesc.Text = "Enter the desk sizes(in inches) and description:";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWidth
            // 
            this.lblWidth.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(59, 149);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(50, 25, 3, 0);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(70, 26);
            this.lblWidth.TabIndex = 9;
            this.lblWidth.Text = "Width:";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deskWidth
            // 
            this.deskWidth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskWidth.Location = new System.Drawing.Point(144, 149);
            this.deskWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.deskWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(120, 26);
            this.deskWidth.TabIndex = 1;
            this.deskWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deskWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.deskWidth.Enter += new System.EventHandler(this.value_Enter);
            // 
            // lblDepth
            // 
            this.lblDepth.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepth.Location = new System.Drawing.Point(287, 149);
            this.lblDepth.Margin = new System.Windows.Forms.Padding(20, 25, 3, 0);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(70, 26);
            this.lblDepth.TabIndex = 11;
            this.lblDepth.Text = "Depth:";
            this.lblDepth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deskDepth
            // 
            this.deskDepth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskDepth.Location = new System.Drawing.Point(363, 147);
            this.deskDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.deskDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.Size = new System.Drawing.Size(120, 26);
            this.deskDepth.TabIndex = 2;
            this.deskDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deskDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.deskDepth.Enter += new System.EventHandler(this.value_Enter);
            // 
            // lblDraw
            // 
            this.lblDraw.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraw.Location = new System.Drawing.Point(59, 200);
            this.lblDraw.Margin = new System.Windows.Forms.Padding(20, 25, 3, 0);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(91, 27);
            this.lblDraw.TabIndex = 12;
            this.lblDraw.Text = "Drawer:";
            this.lblDraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deskDrawers
            // 
            this.deskDrawers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskDrawers.Location = new System.Drawing.Point(222, 200);
            this.deskDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.deskDrawers.Name = "deskDrawers";
            this.deskDrawers.Size = new System.Drawing.Size(120, 26);
            this.deskDrawers.TabIndex = 3;
            this.deskDrawers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deskDrawers.Enter += new System.EventHandler(this.value_Enter);
            // 
            // lblMat
            // 
            this.lblMat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMat.Location = new System.Drawing.Point(59, 252);
            this.lblMat.Margin = new System.Windows.Forms.Padding(50, 25, 3, 0);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(142, 26);
            this.lblMat.TabIndex = 13;
            this.lblMat.Text = "Type of Material:";
            this.lblMat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbMat
            // 
            this.cmbMat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMat.FormattingEnabled = true;
            this.cmbMat.Location = new System.Drawing.Point(222, 251);
            this.cmbMat.Name = "cmbMat";
            this.cmbMat.Size = new System.Drawing.Size(120, 27);
            this.cmbMat.TabIndex = 4;
            this.cmbMat.Validating += new System.ComponentModel.CancelEventHandler(this.cmbMat_Validating);
            // 
            // lblRush
            // 
            this.lblRush.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRush.Location = new System.Drawing.Point(59, 303);
            this.lblRush.Margin = new System.Windows.Forms.Padding(50, 25, 3, 0);
            this.lblRush.Name = "lblRush";
            this.lblRush.Size = new System.Drawing.Size(157, 27);
            this.lblRush.TabIndex = 19;
            this.lblRush.Text = "Estimate Delivery:";
            this.lblRush.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbRushDays
            // 
            this.cmbRushDays.AutoCompleteCustomSource.AddRange(new string[] {
            "14",
            "7",
            "5",
            "3"});
            this.cmbRushDays.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRushDays.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRushDays.FormatString = "N0";
            this.cmbRushDays.FormattingEnabled = true;
            this.cmbRushDays.Location = new System.Drawing.Point(222, 303);
            this.cmbRushDays.Name = "cmbRushDays";
            this.cmbRushDays.Size = new System.Drawing.Size(120, 27);
            this.cmbRushDays.TabIndex = 5;
            this.cmbRushDays.Validating += new System.ComponentModel.CancelEventHandler(this.cmbRushDays_Validating);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.White;
            this.btnDisplay.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDisplay.Location = new System.Drawing.Point(462, 408);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(150, 30);
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.Text = "&Display Quote";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // img
            // 
            this.img.Image = ((System.Drawing.Image)(resources.GetObject("img.Image")));
            this.img.Location = new System.Drawing.Point(568, 24);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(200, 100);
            this.img.TabIndex = 20;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.Controls.Add(this.img);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.cmbRushDays);
            this.Controls.Add(this.lblRush);
            this.Controls.Add(this.cmbMat);
            this.Controls.Add(this.lblMat);
            this.Controls.Add(this.deskDrawers);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.deskDepth);
            this.Controls.Add(this.lblDepth);
            this.Controls.Add(this.deskWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Quote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown deskWidth;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.NumericUpDown deskDepth;
        private System.Windows.Forms.Label lblDraw;
        private System.Windows.Forms.NumericUpDown deskDrawers;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.ComboBox cmbMat;
        private System.Windows.Forms.Label lblRush;
        private System.Windows.Forms.ComboBox cmbRushDays;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label img;
    }
}