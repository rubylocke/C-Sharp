namespace _10_Program_10_2_Inheritance___Encapsulation
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
            this.tbInitialBalance = new System.Windows.Forms.TextBox();
            this.tbDeposits = new System.Windows.Forms.TextBox();
            this.tbWithdrawals = new System.Windows.Forms.TextBox();
            this.btnShowBalance = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblEntInitBal = new System.Windows.Forms.Label();
            this.lblEntDeposits = new System.Windows.Forms.Label();
            this.lblEntWithdrawals = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInitialBalance
            // 
            this.tbInitialBalance.Location = new System.Drawing.Point(306, 44);
            this.tbInitialBalance.Name = "tbInitialBalance";
            this.tbInitialBalance.Size = new System.Drawing.Size(183, 28);
            this.tbInitialBalance.TabIndex = 0;
            this.tbInitialBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDeposits
            // 
            this.tbDeposits.Location = new System.Drawing.Point(306, 113);
            this.tbDeposits.Name = "tbDeposits";
            this.tbDeposits.Size = new System.Drawing.Size(183, 28);
            this.tbDeposits.TabIndex = 1;
            this.tbDeposits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbWithdrawals
            // 
            this.tbWithdrawals.Location = new System.Drawing.Point(306, 189);
            this.tbWithdrawals.Name = "tbWithdrawals";
            this.tbWithdrawals.Size = new System.Drawing.Size(183, 28);
            this.tbWithdrawals.TabIndex = 2;
            this.tbWithdrawals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnShowBalance
            // 
            this.btnShowBalance.Location = new System.Drawing.Point(115, 271);
            this.btnShowBalance.Name = "btnShowBalance";
            this.btnShowBalance.Size = new System.Drawing.Size(181, 39);
            this.btnShowBalance.TabIndex = 3;
            this.btnShowBalance.Text = "Show Balance";
            this.btnShowBalance.UseVisualStyleBackColor = true;
            this.btnShowBalance.Click += new System.EventHandler(this.btnShowBalance_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(389, 271);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 39);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblEntInitBal
            // 
            this.lblEntInitBal.AutoSize = true;
            this.lblEntInitBal.Location = new System.Drawing.Point(74, 44);
            this.lblEntInitBal.Name = "lblEntInitBal";
            this.lblEntInitBal.Size = new System.Drawing.Size(195, 24);
            this.lblEntInitBal.TabIndex = 5;
            this.lblEntInitBal.Text = "Enter Initial Balance";
            this.lblEntInitBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEntDeposits
            // 
            this.lblEntDeposits.AutoSize = true;
            this.lblEntDeposits.Location = new System.Drawing.Point(78, 113);
            this.lblEntDeposits.Name = "lblEntDeposits";
            this.lblEntDeposits.Size = new System.Drawing.Size(146, 24);
            this.lblEntDeposits.TabIndex = 6;
            this.lblEntDeposits.Text = "Enter Deposits";
            this.lblEntDeposits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEntWithdrawals
            // 
            this.lblEntWithdrawals.AutoSize = true;
            this.lblEntWithdrawals.Location = new System.Drawing.Point(78, 189);
            this.lblEntWithdrawals.Name = "lblEntWithdrawals";
            this.lblEntWithdrawals.Size = new System.Drawing.Size(167, 24);
            this.lblEntWithdrawals.TabIndex = 7;
            this.lblEntWithdrawals.Text = "Enter Withdrawls";
            this.lblEntWithdrawals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 348);
            this.Controls.Add(this.lblEntWithdrawals);
            this.Controls.Add(this.lblEntDeposits);
            this.Controls.Add(this.lblEntInitBal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowBalance);
            this.Controls.Add(this.tbWithdrawals);
            this.Controls.Add(this.tbDeposits);
            this.Controls.Add(this.tbInitialBalance);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Inheritance & Encapsulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInitialBalance;
        private System.Windows.Forms.TextBox tbDeposits;
        private System.Windows.Forms.TextBox tbWithdrawals;
        private System.Windows.Forms.Button btnShowBalance;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblEntInitBal;
        private System.Windows.Forms.Label lblEntDeposits;
        private System.Windows.Forms.Label lblEntWithdrawals;
    }
}

