namespace _4_1_Roman_Numeral_Converter
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
            this.lblEnterNumberCaption = new System.Windows.Forms.Label();
            this.btnGetNumber = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblRomanNumeralCaption = new System.Windows.Forms.Label();
            this.lblOutputRomanNumeral = new System.Windows.Forms.Label();
            this.txtUserEnter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEnterNumberCaption
            // 
            this.lblEnterNumberCaption.AutoSize = true;
            this.lblEnterNumberCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNumberCaption.Location = new System.Drawing.Point(25, 26);
            this.lblEnterNumberCaption.Name = "lblEnterNumberCaption";
            this.lblEnterNumberCaption.Size = new System.Drawing.Size(332, 24);
            this.lblEnterNumberCaption.TabIndex = 0;
            this.lblEnterNumberCaption.Text = "Enter an Integer between 1 and 10";
            // 
            // btnGetNumber
            // 
            this.btnGetNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetNumber.Location = new System.Drawing.Point(117, 169);
            this.btnGetNumber.Name = "btnGetNumber";
            this.btnGetNumber.Size = new System.Drawing.Size(84, 62);
            this.btnGetNumber.TabIndex = 1;
            this.btnGetNumber.Text = "&Get Value";
            this.btnGetNumber.UseVisualStyleBackColor = true;
            this.btnGetNumber.Click += new System.EventHandler(this.btnGetNumber_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(271, 179);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 43);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(440, 179);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 43);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblRomanNumeralCaption
            // 
            this.lblRomanNumeralCaption.AutoSize = true;
            this.lblRomanNumeralCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRomanNumeralCaption.Location = new System.Drawing.Point(184, 106);
            this.lblRomanNumeralCaption.Name = "lblRomanNumeralCaption";
            this.lblRomanNumeralCaption.Size = new System.Drawing.Size(173, 24);
            this.lblRomanNumeralCaption.TabIndex = 4;
            this.lblRomanNumeralCaption.Text = "Roman Numeral :";
            this.lblRomanNumeralCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputRomanNumeral
            // 
            this.lblOutputRomanNumeral.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblOutputRomanNumeral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputRomanNumeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputRomanNumeral.Location = new System.Drawing.Point(385, 96);
            this.lblOutputRomanNumeral.Name = "lblOutputRomanNumeral";
            this.lblOutputRomanNumeral.Size = new System.Drawing.Size(130, 45);
            this.lblOutputRomanNumeral.TabIndex = 5;
            this.lblOutputRomanNumeral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserEnter
            // 
            this.txtUserEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserEnter.Location = new System.Drawing.Point(385, 27);
            this.txtUserEnter.Name = "txtUserEnter";
            this.txtUserEnter.Size = new System.Drawing.Size(120, 28);
            this.txtUserEnter.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 253);
            this.Controls.Add(this.txtUserEnter);
            this.Controls.Add(this.lblOutputRomanNumeral);
            this.Controls.Add(this.lblRomanNumeralCaption);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGetNumber);
            this.Controls.Add(this.lblEnterNumberCaption);
            this.Name = "Form1";
            this.Text = "Roman Numeral Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterNumberCaption;
        private System.Windows.Forms.Button btnGetNumber;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblRomanNumeralCaption;
        private System.Windows.Forms.Label lblOutputRomanNumeral;
        private System.Windows.Forms.TextBox txtUserEnter;
    }
}

