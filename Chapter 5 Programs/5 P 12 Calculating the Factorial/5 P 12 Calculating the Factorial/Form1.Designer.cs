namespace _5_P_12_Calculating_the_Factorial
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
            this.lbCaptionEnterNumber = new System.Windows.Forms.Label();
            this.tbNumberEntered = new System.Windows.Forms.TextBox();
            this.lblOutputFactorial = new System.Windows.Forms.Label();
            this.lblFactorial = new System.Windows.Forms.Label();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCaptionEnterNumber
            // 
            this.lbCaptionEnterNumber.AutoSize = true;
            this.lbCaptionEnterNumber.Location = new System.Drawing.Point(41, 55);
            this.lbCaptionEnterNumber.Name = "lbCaptionEnterNumber";
            this.lbCaptionEnterNumber.Size = new System.Drawing.Size(262, 24);
            this.lbCaptionEnterNumber.TabIndex = 0;
            this.lbCaptionEnterNumber.Text = "Enter nonnegative Number";
            // 
            // tbNumberEntered
            // 
            this.tbNumberEntered.Location = new System.Drawing.Point(384, 55);
            this.tbNumberEntered.Name = "tbNumberEntered";
            this.tbNumberEntered.Size = new System.Drawing.Size(146, 28);
            this.tbNumberEntered.TabIndex = 1;
            this.tbNumberEntered.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumberEntered.TextChanged += new System.EventHandler(this.tbNumberEntered_TextChanged);
            // 
            // lblOutputFactorial
            // 
            this.lblOutputFactorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputFactorial.Location = new System.Drawing.Point(309, 153);
            this.lblOutputFactorial.Name = "lblOutputFactorial";
            this.lblOutputFactorial.Size = new System.Drawing.Size(310, 41);
            this.lblOutputFactorial.TabIndex = 2;
            this.lblOutputFactorial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFactorial
            // 
            this.lblFactorial.AutoSize = true;
            this.lblFactorial.Location = new System.Drawing.Point(213, 162);
            this.lblFactorial.Name = "lblFactorial";
            this.lblFactorial.Size = new System.Drawing.Size(90, 24);
            this.lblFactorial.TabIndex = 3;
            this.lblFactorial.Text = "Factorial";
            // 
            // btnFactorial
            // 
            this.btnFactorial.Location = new System.Drawing.Point(114, 243);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(133, 40);
            this.btnFactorial.TabIndex = 4;
            this.btnFactorial.Text = "Factor";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(356, 243);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 40);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(497, 243);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 40);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 348);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.lblFactorial);
            this.Controls.Add(this.lblOutputFactorial);
            this.Controls.Add(this.tbNumberEntered);
            this.Controls.Add(this.lbCaptionEnterNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Calculating the Factorial of a Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCaptionEnterNumber;
        private System.Windows.Forms.TextBox tbNumberEntered;
        private System.Windows.Forms.Label lblOutputFactorial;
        private System.Windows.Forms.Label lblFactorial;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

