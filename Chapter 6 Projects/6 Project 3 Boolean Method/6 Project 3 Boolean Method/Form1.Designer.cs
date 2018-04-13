namespace _6_Project_3_Boolean_Method
{
    partial class formBoolean
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
            this.lblCaptionEnterAnInteger = new System.Windows.Forms.Label();
            this.btnEvenOrOdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbInteger = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCaptionEnterAnInteger
            // 
            this.lblCaptionEnterAnInteger.AutoSize = true;
            this.lblCaptionEnterAnInteger.Location = new System.Drawing.Point(40, 44);
            this.lblCaptionEnterAnInteger.Name = "lblCaptionEnterAnInteger";
            this.lblCaptionEnterAnInteger.Size = new System.Drawing.Size(163, 24);
            this.lblCaptionEnterAnInteger.TabIndex = 0;
            this.lblCaptionEnterAnInteger.Text = "Enter An Integer";
            // 
            // btnEvenOrOdd
            // 
            this.btnEvenOrOdd.Location = new System.Drawing.Point(99, 114);
            this.btnEvenOrOdd.Name = "btnEvenOrOdd";
            this.btnEvenOrOdd.Size = new System.Drawing.Size(181, 38);
            this.btnEvenOrOdd.TabIndex = 2;
            this.btnEvenOrOdd.Text = "Even Or Odd";
            this.btnEvenOrOdd.UseVisualStyleBackColor = true;
            this.btnEvenOrOdd.Click += new System.EventHandler(this.btnEvenOrOdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(80, 201);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 43);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(215, 201);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 43);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "E&xit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbInteger
            // 
            this.tbInteger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInteger.Location = new System.Drawing.Point(244, 44);
            this.tbInteger.Name = "tbInteger";
            this.tbInteger.Size = new System.Drawing.Size(100, 28);
            this.tbInteger.TabIndex = 5;
            this.tbInteger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // formBoolean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 295);
            this.Controls.Add(this.tbInteger);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEvenOrOdd);
            this.Controls.Add(this.lblCaptionEnterAnInteger);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formBoolean";
            this.Text = "Boolean Method";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaptionEnterAnInteger;
        private System.Windows.Forms.Button btnEvenOrOdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbInteger;
    }
}

