namespace MathQuiz
{
    partial class MathQuiz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MathQuiz));
            this.timeLabel = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.lblPlus = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.lblEqualSum = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.dividedRightLabel = new System.Windows.Forms.Label();
            this.lblMinus = new System.Windows.Forms.Label();
            this.lblMult = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblEqualDiff = new System.Windows.Forms.Label();
            this.lblEqualProd = new System.Windows.Forms.Label();
            this.lblEqualQuo = new System.Windows.Forms.Label();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(260, 20);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(163, 20);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(91, 23);
            this.lblTimeLeft.TabIndex = 1;
            this.lblTimeLeft.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(50, 75);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlus
            // 
            this.lblPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus.Location = new System.Drawing.Point(116, 75);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(60, 50);
            this.lblPlus.TabIndex = 3;
            this.lblPlus.Text = "+";
            this.lblPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(182, 75);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 4;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEqualSum
            // 
            this.lblEqualSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqualSum.Location = new System.Drawing.Point(248, 75);
            this.lblEqualSum.Name = "lblEqualSum";
            this.lblEqualSum.Size = new System.Drawing.Size(60, 50);
            this.lblEqualSum.TabIndex = 5;
            this.lblEqualSum.Text = "=";
            this.lblEqualSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(314, 84);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 35);
            this.sum.TabIndex = 2;
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftLabel.Location = new System.Drawing.Point(50, 125);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.minusLeftLabel.TabIndex = 7;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLeftLabel.Location = new System.Drawing.Point(50, 175);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.timesLeftLabel.TabIndex = 8;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            this.dividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedLeftLabel.Location = new System.Drawing.Point(50, 225);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedLeftLabel.TabIndex = 9;
            this.dividedLeftLabel.Text = "?";
            this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightLabel.Location = new System.Drawing.Point(182, 125);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.minusRightLabel.TabIndex = 10;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesRightLabel.Location = new System.Drawing.Point(182, 175);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(60, 50);
            this.timesRightLabel.TabIndex = 11;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            this.dividedRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedRightLabel.Location = new System.Drawing.Point(182, 225);
            this.dividedRightLabel.Name = "dividedRightLabel";
            this.dividedRightLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedRightLabel.TabIndex = 12;
            this.dividedRightLabel.Text = "?";
            this.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinus
            // 
            this.lblMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinus.Location = new System.Drawing.Point(116, 125);
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.Size = new System.Drawing.Size(60, 50);
            this.lblMinus.TabIndex = 13;
            this.lblMinus.Text = "-";
            this.lblMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMult
            // 
            this.lblMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMult.Location = new System.Drawing.Point(116, 175);
            this.lblMult.Name = "lblMult";
            this.lblMult.Size = new System.Drawing.Size(60, 50);
            this.lblMult.TabIndex = 14;
            this.lblMult.Text = "×";
            this.lblMult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(116, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 50);
            this.label9.TabIndex = 15;
            this.label9.Text = "÷";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEqualDiff
            // 
            this.lblEqualDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqualDiff.Location = new System.Drawing.Point(248, 125);
            this.lblEqualDiff.Name = "lblEqualDiff";
            this.lblEqualDiff.Size = new System.Drawing.Size(60, 50);
            this.lblEqualDiff.TabIndex = 16;
            this.lblEqualDiff.Text = "=";
            this.lblEqualDiff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEqualProd
            // 
            this.lblEqualProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqualProd.Location = new System.Drawing.Point(248, 175);
            this.lblEqualProd.Name = "lblEqualProd";
            this.lblEqualProd.Size = new System.Drawing.Size(60, 50);
            this.lblEqualProd.TabIndex = 17;
            this.lblEqualProd.Text = "=";
            this.lblEqualProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEqualQuo
            // 
            this.lblEqualQuo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqualQuo.Location = new System.Drawing.Point(248, 225);
            this.lblEqualQuo.Name = "lblEqualQuo";
            this.lblEqualQuo.Size = new System.Drawing.Size(60, 50);
            this.lblEqualQuo.TabIndex = 18;
            this.lblEqualQuo.Text = "=";
            this.lblEqualQuo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difference.Location = new System.Drawing.Point(314, 134);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(100, 35);
            this.difference.TabIndex = 3;
            this.difference.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(314, 184);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(100, 35);
            this.product.TabIndex = 4;
            this.product.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotient.Location = new System.Drawing.Point(314, 234);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(100, 35);
            this.quotient.TabIndex = 5;
            this.quotient.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(126, 293);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(128, 34);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start the Quiz!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            this.startButton.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(345, 333);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 19);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MathQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.product);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.lblEqualQuo);
            this.Controls.Add(this.lblEqualProd);
            this.Controls.Add(this.lblEqualDiff);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblMult);
            this.Controls.Add(this.lblMinus);
            this.Controls.Add(this.dividedRightLabel);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.dividedLeftLabel);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.lblEqualSum);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MathQuiz";
            this.Text = "Ronan Macedo - Math Quiz";
            this.Load += new System.EventHandler(this.MathQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label lblEqualSum;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label dividedRightLabel;
        private System.Windows.Forms.Label lblMinus;
        private System.Windows.Forms.Label lblMult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEqualDiff;
        private System.Windows.Forms.Label lblEqualProd;
        private System.Windows.Forms.Label lblEqualQuo;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
    }
}

