namespace MegaDesk
{
    partial class DisplayQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayQuote));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblAreaCost = new System.Windows.Forms.Label();
            this.lblDrawer = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblRush = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblRushDolar = new System.Windows.Forms.Label();
            this.lblTotalDolar = new System.Windows.Forms.Label();
            this.lblMatDolar = new System.Windows.Forms.Label();
            this.lblDrawerDolar = new System.Windows.Forms.Label();
            this.lblAreaDolar = new System.Windows.Forms.Label();
            this.lblEstDelivery = new System.Windows.Forms.Label();
            this.txtAreaCost = new System.Windows.Forms.Label();
            this.txtDrawer = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.Label();
            this.txtRushDays = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.btnBack.Text = "&Return to Add Quote";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(59, 59);
            this.lblName.Margin = new System.Windows.Forms.Padding(50, 50, 3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 20);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Thank you,";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(164, 59);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 50, 3, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(275, 20);
            this.txtName.TabIndex = 9;
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(59, 104);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(50, 25, 3, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(380, 20);
            this.lblDesc.TabIndex = 10;
            this.lblDesc.Text = "Cost summary:";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAreaCost
            // 
            this.lblAreaCost.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaCost.Location = new System.Drawing.Point(59, 134);
            this.lblAreaCost.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.lblAreaCost.Name = "lblAreaCost";
            this.lblAreaCost.Size = new System.Drawing.Size(140, 26);
            this.lblAreaCost.TabIndex = 11;
            this.lblAreaCost.Text = "Area cost:";
            this.lblAreaCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDrawer
            // 
            this.lblDrawer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawer.Location = new System.Drawing.Point(59, 170);
            this.lblDrawer.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.lblDrawer.Name = "lblDrawer";
            this.lblDrawer.Size = new System.Drawing.Size(140, 26);
            this.lblDrawer.TabIndex = 12;
            this.lblDrawer.Text = "DrawerCost(s):";
            this.lblDrawer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaterial
            // 
            this.lblMaterial.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(59, 206);
            this.lblMaterial.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(140, 26);
            this.lblMaterial.TabIndex = 13;
            this.lblMaterial.Text = "Material cost:";
            this.lblMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRush
            // 
            this.lblRush.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRush.Location = new System.Drawing.Point(59, 242);
            this.lblRush.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.lblRush.Name = "lblRush";
            this.lblRush.Size = new System.Drawing.Size(140, 26);
            this.lblRush.TabIndex = 14;
            this.lblRush.Text = "Rush days cost:";
            this.lblRush.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(59, 278);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(140, 26);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRushDolar
            // 
            this.lblRushDolar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRushDolar.Location = new System.Drawing.Point(212, 242);
            this.lblRushDolar.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblRushDolar.Name = "lblRushDolar";
            this.lblRushDolar.Size = new System.Drawing.Size(18, 26);
            this.lblRushDolar.TabIndex = 16;
            this.lblRushDolar.Text = "$";
            this.lblRushDolar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalDolar
            // 
            this.lblTotalDolar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDolar.Location = new System.Drawing.Point(212, 278);
            this.lblTotalDolar.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblTotalDolar.Name = "lblTotalDolar";
            this.lblTotalDolar.Size = new System.Drawing.Size(18, 26);
            this.lblTotalDolar.TabIndex = 17;
            this.lblTotalDolar.Text = "$";
            this.lblTotalDolar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMatDolar
            // 
            this.lblMatDolar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatDolar.Location = new System.Drawing.Point(212, 206);
            this.lblMatDolar.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblMatDolar.Name = "lblMatDolar";
            this.lblMatDolar.Size = new System.Drawing.Size(18, 26);
            this.lblMatDolar.TabIndex = 18;
            this.lblMatDolar.Text = "$";
            this.lblMatDolar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDrawerDolar
            // 
            this.lblDrawerDolar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawerDolar.Location = new System.Drawing.Point(212, 170);
            this.lblDrawerDolar.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblDrawerDolar.Name = "lblDrawerDolar";
            this.lblDrawerDolar.Size = new System.Drawing.Size(18, 26);
            this.lblDrawerDolar.TabIndex = 19;
            this.lblDrawerDolar.Text = "$";
            this.lblDrawerDolar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAreaDolar
            // 
            this.lblAreaDolar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaDolar.Location = new System.Drawing.Point(212, 134);
            this.lblAreaDolar.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblAreaDolar.Name = "lblAreaDolar";
            this.lblAreaDolar.Size = new System.Drawing.Size(18, 26);
            this.lblAreaDolar.TabIndex = 20;
            this.lblAreaDolar.Text = "$";
            this.lblAreaDolar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstDelivery
            // 
            this.lblEstDelivery.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstDelivery.Location = new System.Drawing.Point(59, 314);
            this.lblEstDelivery.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
            this.lblEstDelivery.Name = "lblEstDelivery";
            this.lblEstDelivery.Size = new System.Drawing.Size(171, 26);
            this.lblEstDelivery.TabIndex = 22;
            this.lblEstDelivery.Text = "Estimated delivery:";
            this.lblEstDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAreaCost
            // 
            this.txtAreaCost.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtAreaCost.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaCost.Location = new System.Drawing.Point(238, 137);
            this.txtAreaCost.Margin = new System.Windows.Forms.Padding(5, 50, 3, 0);
            this.txtAreaCost.Name = "txtAreaCost";
            this.txtAreaCost.Size = new System.Drawing.Size(201, 20);
            this.txtAreaCost.TabIndex = 23;
            this.txtAreaCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDrawer
            // 
            this.txtDrawer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDrawer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrawer.Location = new System.Drawing.Point(238, 176);
            this.txtDrawer.Margin = new System.Windows.Forms.Padding(5, 50, 3, 0);
            this.txtDrawer.Name = "txtDrawer";
            this.txtDrawer.Size = new System.Drawing.Size(201, 20);
            this.txtDrawer.TabIndex = 24;
            this.txtDrawer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaterial
            // 
            this.txtMaterial.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtMaterial.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterial.Location = new System.Drawing.Point(238, 212);
            this.txtMaterial.Margin = new System.Windows.Forms.Padding(5, 50, 3, 0);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(201, 20);
            this.txtMaterial.TabIndex = 25;
            this.txtMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRushDays
            // 
            this.txtRushDays.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtRushDays.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRushDays.Location = new System.Drawing.Point(238, 248);
            this.txtRushDays.Margin = new System.Windows.Forms.Padding(5, 50, 3, 0);
            this.txtRushDays.Name = "txtRushDays";
            this.txtRushDays.Size = new System.Drawing.Size(201, 20);
            this.txtRushDays.TabIndex = 26;
            this.txtRushDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtTotal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(238, 281);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5, 50, 3, 0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(201, 20);
            this.txtTotal.TabIndex = 27;
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(238, 317);
            this.txtDate.Margin = new System.Windows.Forms.Padding(5, 50, 3, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(201, 20);
            this.txtDate.TabIndex = 28;
            this.txtDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // img
            // 
            this.img.Image = ((System.Drawing.Image)(resources.GetObject("img.Image")));
            this.img.Location = new System.Drawing.Point(568, 24);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(200, 100);
            this.img.TabIndex = 29;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAdd.Location = new System.Drawing.Point(462, 408);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 30);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "&Confirm this Quote";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.img);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtRushDays);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.txtDrawer);
            this.Controls.Add(this.txtAreaCost);
            this.Controls.Add(this.lblEstDelivery);
            this.Controls.Add(this.lblAreaDolar);
            this.Controls.Add(this.lblDrawerDolar);
            this.Controls.Add(this.lblMatDolar);
            this.Controls.Add(this.lblTotalDolar);
            this.Controls.Add(this.lblRushDolar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblRush);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblDrawer);
            this.Controls.Add(this.lblAreaCost);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DisplayQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Quotes";
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblAreaCost;
        private System.Windows.Forms.Label lblDrawer;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblRush;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblRushDolar;
        private System.Windows.Forms.Label lblTotalDolar;
        private System.Windows.Forms.Label lblMatDolar;
        private System.Windows.Forms.Label lblDrawerDolar;
        private System.Windows.Forms.Label lblAreaDolar;
        private System.Windows.Forms.Label lblEstDelivery;
        private System.Windows.Forms.Label txtAreaCost;
        private System.Windows.Forms.Label txtDrawer;
        private System.Windows.Forms.Label txtMaterial;
        private System.Windows.Forms.Label txtRushDays;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.Label img;
        private System.Windows.Forms.Button btnAdd;
    }
}