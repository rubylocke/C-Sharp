namespace _7_Problem_7_3_Charge_Account_Validations
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
            this.lblCaptionAcctVal = new System.Windows.Forms.Label();
            this.lblEnterNumber = new System.Windows.Forms.Label();
            this.tbAcctNumber = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCaptionAcctVal
            // 
            this.lblCaptionAcctVal.AutoSize = true;
            this.lblCaptionAcctVal.Location = new System.Drawing.Point(96, 43);
            this.lblCaptionAcctVal.Name = "lblCaptionAcctVal";
            this.lblCaptionAcctVal.Size = new System.Drawing.Size(259, 24);
            this.lblCaptionAcctVal.TabIndex = 0;
            this.lblCaptionAcctVal.Text = "Charge Account Validation";
            // 
            // lblEnterNumber
            // 
            this.lblEnterNumber.AutoSize = true;
            this.lblEnterNumber.Location = new System.Drawing.Point(45, 111);
            this.lblEnterNumber.Name = "lblEnterNumber";
            this.lblEnterNumber.Size = new System.Drawing.Size(224, 24);
            this.lblEnterNumber.TabIndex = 1;
            this.lblEnterNumber.Text = "Enter Account Number";
            // 
            // tbAcctNumber
            // 
            this.tbAcctNumber.Location = new System.Drawing.Point(276, 111);
            this.tbAcctNumber.Name = "tbAcctNumber";
            this.tbAcctNumber.Size = new System.Drawing.Size(125, 28);
            this.tbAcctNumber.TabIndex = 2;
            this.tbAcctNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(45, 190);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(108, 49);
            this.btnValidate.TabIndex = 3;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(196, 190);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 49);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(320, 190);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 49);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "E&xit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 266);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.tbAcctNumber);
            this.Controls.Add(this.lblEnterNumber);
            this.Controls.Add(this.lblCaptionAcctVal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Charge Account Validation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaptionAcctVal;
        private System.Windows.Forms.Label lblEnterNumber;
        private System.Windows.Forms.TextBox tbAcctNumber;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}

