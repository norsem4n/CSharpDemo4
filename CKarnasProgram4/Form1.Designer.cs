namespace CKarnasProgram4
{
    partial class Form1
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
            this.lblLoanAmt = new System.Windows.Forms.Label();
            this.lblLoanDuration = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblPayment = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.numUpDnLoanAmt = new System.Windows.Forms.NumericUpDown();
            this.numUpDnDuration = new System.Windows.Forms.NumericUpDown();
            this.numUpDwnInterest = new System.Windows.Forms.NumericUpDown();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblDevelopedBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnLoanAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnInterest)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoanAmt
            // 
            this.lblLoanAmt.AutoSize = true;
            this.lblLoanAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanAmt.Location = new System.Drawing.Point(96, 100);
            this.lblLoanAmt.Name = "lblLoanAmt";
            this.lblLoanAmt.Size = new System.Drawing.Size(139, 25);
            this.lblLoanAmt.TabIndex = 0;
            this.lblLoanAmt.Text = "Loan Amount";
            // 
            // lblLoanDuration
            // 
            this.lblLoanDuration.AutoSize = true;
            this.lblLoanDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanDuration.Location = new System.Drawing.Point(96, 175);
            this.lblLoanDuration.Name = "lblLoanDuration";
            this.lblLoanDuration.Size = new System.Drawing.Size(224, 25);
            this.lblLoanDuration.TabIndex = 1;
            this.lblLoanDuration.Text = "Loan Duration Months";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestRate.Location = new System.Drawing.Point(96, 244);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(207, 25);
            this.lblInterestRate.TabIndex = 2;
            this.lblInterestRate.Text = "Annual Interest Rate";
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(91, 314);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(226, 35);
            this.btnPayment.TabIndex = 6;
            this.btnPayment.Text = "Calculate Monthly Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(341, 314);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(189, 34);
            this.lblPayment.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(445, 361);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 35);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(341, 361);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 33);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // numUpDnLoanAmt
            // 
            this.numUpDnLoanAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDnLoanAmt.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUpDnLoanAmt.Location = new System.Drawing.Point(341, 100);
            this.numUpDnLoanAmt.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numUpDnLoanAmt.Name = "numUpDnLoanAmt";
            this.numUpDnLoanAmt.Size = new System.Drawing.Size(189, 29);
            this.numUpDnLoanAmt.TabIndex = 12;
            this.numUpDnLoanAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDnLoanAmt.ThousandsSeparator = true;
            // 
            // numUpDnDuration
            // 
            this.numUpDnDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDnDuration.Location = new System.Drawing.Point(341, 175);
            this.numUpDnDuration.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numUpDnDuration.Name = "numUpDnDuration";
            this.numUpDnDuration.Size = new System.Drawing.Size(189, 29);
            this.numUpDnDuration.TabIndex = 13;
            this.numUpDnDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDnDuration.ThousandsSeparator = true;
            // 
            // numUpDwnInterest
            // 
            this.numUpDwnInterest.DecimalPlaces = 2;
            this.numUpDwnInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDwnInterest.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numUpDwnInterest.Location = new System.Drawing.Point(341, 244);
            this.numUpDwnInterest.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpDwnInterest.Name = "numUpDwnInterest";
            this.numUpDwnInterest.Size = new System.Drawing.Size(189, 29);
            this.numUpDwnInterest.TabIndex = 14;
            this.numUpDwnInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDwnInterest.ThousandsSeparator = true;
            // 
            // lblMain
            // 
            this.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(168, 32);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(307, 25);
            this.lblMain.TabIndex = 15;
            this.lblMain.Text = "Monthly Payment Calculator";
            // 
            // lblDevelopedBy
            // 
            this.lblDevelopedBy.AutoSize = true;
            this.lblDevelopedBy.Location = new System.Drawing.Point(12, 455);
            this.lblDevelopedBy.Name = "lblDevelopedBy";
            this.lblDevelopedBy.Size = new System.Drawing.Size(98, 13);
            this.lblDevelopedBy.TabIndex = 16;
            this.lblDevelopedBy.Text = "Developed by CGK";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 477);
            this.Controls.Add(this.lblDevelopedBy);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.numUpDwnInterest);
            this.Controls.Add(this.numUpDnDuration);
            this.Controls.Add(this.numUpDnLoanAmt);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.lblLoanDuration);
            this.Controls.Add(this.lblLoanAmt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment 3 - Loan Program";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnLoanAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwnInterest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoanAmt;
        private System.Windows.Forms.Label lblLoanDuration;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.NumericUpDown numUpDnLoanAmt;
        private System.Windows.Forms.NumericUpDown numUpDnDuration;
        private System.Windows.Forms.NumericUpDown numUpDwnInterest;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblDevelopedBy;
    }
}

