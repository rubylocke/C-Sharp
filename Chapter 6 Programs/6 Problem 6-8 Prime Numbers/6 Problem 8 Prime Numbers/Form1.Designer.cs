namespace _6_Problem_8_Prime_Numbers
{
    partial class formPrimeNumbers
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
            this.lblCaptionEngerNumber = new System.Windows.Forms.Label();
            this.tbEnterNumber = new System.Windows.Forms.TextBox();
            this.btnPrimeChecker = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblOutputPrimeIndicator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCaptionEngerNumber
            // 
            this.lblCaptionEngerNumber.AutoSize = true;
            this.lblCaptionEngerNumber.Location = new System.Drawing.Point(28, 36);
            this.lblCaptionEngerNumber.Name = "lblCaptionEngerNumber";
            this.lblCaptionEngerNumber.Size = new System.Drawing.Size(141, 24);
            this.lblCaptionEngerNumber.TabIndex = 0;
            this.lblCaptionEngerNumber.Text = "Enter Number";
            // 
            // tbEnterNumber
            // 
            this.tbEnterNumber.Location = new System.Drawing.Point(201, 36);
            this.tbEnterNumber.Name = "tbEnterNumber";
            this.tbEnterNumber.Size = new System.Drawing.Size(100, 28);
            this.tbEnterNumber.TabIndex = 1;
            this.tbEnterNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPrimeChecker
            // 
            this.btnPrimeChecker.Location = new System.Drawing.Point(22, 192);
            this.btnPrimeChecker.Name = "btnPrimeChecker";
            this.btnPrimeChecker.Size = new System.Drawing.Size(114, 58);
            this.btnPrimeChecker.TabIndex = 2;
            this.btnPrimeChecker.Text = "Prime Checker";
            this.btnPrimeChecker.UseVisualStyleBackColor = true;
            this.btnPrimeChecker.Click += new System.EventHandler(this.btnPrimeChecker_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(176, 192);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 58);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(283, 192);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 58);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "E&xit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblOutputPrimeIndicator
            // 
            this.lblOutputPrimeIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputPrimeIndicator.Location = new System.Drawing.Point(42, 103);
            this.lblOutputPrimeIndicator.Name = "lblOutputPrimeIndicator";
            this.lblOutputPrimeIndicator.Size = new System.Drawing.Size(296, 37);
            this.lblOutputPrimeIndicator.TabIndex = 5;
            this.lblOutputPrimeIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formPrimeNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 290);
            this.Controls.Add(this.lblOutputPrimeIndicator);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrimeChecker);
            this.Controls.Add(this.tbEnterNumber);
            this.Controls.Add(this.lblCaptionEngerNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formPrimeNumbers";
            this.Text = "Prime Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaptionEngerNumber;
        private System.Windows.Forms.TextBox tbEnterNumber;
        private System.Windows.Forms.Button btnPrimeChecker;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblOutputPrimeIndicator;
    }
}

