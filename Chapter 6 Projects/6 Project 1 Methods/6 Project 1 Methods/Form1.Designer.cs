namespace _6_Project_1_Methods
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
            this.lblCaptionFirstNumber = new System.Windows.Forms.Label();
            this.lblCaptionSecondNumber = new System.Windows.Forms.Label();
            this.lblCaptionResult = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbFirstNumber = new System.Windows.Forms.TextBox();
            this.tbSecondNumber = new System.Windows.Forms.TextBox();
            this.btnReturnValue = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnVoidMethod1 = new System.Windows.Forms.Button();
            this.btnVoidMethod2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCaptionFirstNumber
            // 
            this.lblCaptionFirstNumber.AutoSize = true;
            this.lblCaptionFirstNumber.Location = new System.Drawing.Point(51, 39);
            this.lblCaptionFirstNumber.Name = "lblCaptionFirstNumber";
            this.lblCaptionFirstNumber.Size = new System.Drawing.Size(131, 24);
            this.lblCaptionFirstNumber.TabIndex = 0;
            this.lblCaptionFirstNumber.Text = "First Number";
            // 
            // lblCaptionSecondNumber
            // 
            this.lblCaptionSecondNumber.AutoSize = true;
            this.lblCaptionSecondNumber.Location = new System.Drawing.Point(19, 108);
            this.lblCaptionSecondNumber.Name = "lblCaptionSecondNumber";
            this.lblCaptionSecondNumber.Size = new System.Drawing.Size(163, 24);
            this.lblCaptionSecondNumber.TabIndex = 1;
            this.lblCaptionSecondNumber.Text = "Second Number";
            // 
            // lblCaptionResult
            // 
            this.lblCaptionResult.AutoSize = true;
            this.lblCaptionResult.Location = new System.Drawing.Point(114, 177);
            this.lblCaptionResult.Name = "lblCaptionResult";
            this.lblCaptionResult.Size = new System.Drawing.Size(68, 24);
            this.lblCaptionResult.TabIndex = 2;
            this.lblCaptionResult.Text = "Result";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(241, 172);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 38);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbFirstNumber
            // 
            this.tbFirstNumber.Location = new System.Drawing.Point(241, 35);
            this.tbFirstNumber.Name = "tbFirstNumber";
            this.tbFirstNumber.Size = new System.Drawing.Size(100, 28);
            this.tbFirstNumber.TabIndex = 4;
            // 
            // tbSecondNumber
            // 
            this.tbSecondNumber.Location = new System.Drawing.Point(241, 108);
            this.tbSecondNumber.Name = "tbSecondNumber";
            this.tbSecondNumber.Size = new System.Drawing.Size(100, 28);
            this.tbSecondNumber.TabIndex = 5;
            // 
            // btnReturnValue
            // 
            this.btnReturnValue.Location = new System.Drawing.Point(40, 259);
            this.btnReturnValue.Name = "btnReturnValue";
            this.btnReturnValue.Size = new System.Drawing.Size(115, 93);
            this.btnReturnValue.TabIndex = 6;
            this.btnReturnValue.Text = "Return Value Method";
            this.btnReturnValue.UseVisualStyleBackColor = true;
            this.btnReturnValue.Click += new System.EventHandler(this.btnReturnValue_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(181, 260);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 93);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(335, 259);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 93);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "E&xit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnVoidMethod1
            // 
            this.btnVoidMethod1.Location = new System.Drawing.Point(85, 375);
            this.btnVoidMethod1.Name = "btnVoidMethod1";
            this.btnVoidMethod1.Size = new System.Drawing.Size(115, 82);
            this.btnVoidMethod1.TabIndex = 9;
            this.btnVoidMethod1.Text = "Void Method 1";
            this.btnVoidMethod1.UseVisualStyleBackColor = true;
            this.btnVoidMethod1.Click += new System.EventHandler(this.btnVoidMethod1_Click);
            // 
            // btnVoidMethod2
            // 
            this.btnVoidMethod2.Location = new System.Drawing.Point(251, 375);
            this.btnVoidMethod2.Name = "btnVoidMethod2";
            this.btnVoidMethod2.Size = new System.Drawing.Size(115, 82);
            this.btnVoidMethod2.TabIndex = 10;
            this.btnVoidMethod2.Text = "Void Method 2";
            this.btnVoidMethod2.UseVisualStyleBackColor = true;
            this.btnVoidMethod2.Click += new System.EventHandler(this.btnVoidMethod2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 469);
            this.Controls.Add(this.btnVoidMethod2);
            this.Controls.Add(this.btnVoidMethod1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReturnValue);
            this.Controls.Add(this.tbSecondNumber);
            this.Controls.Add(this.tbFirstNumber);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCaptionResult);
            this.Controls.Add(this.lblCaptionSecondNumber);
            this.Controls.Add(this.lblCaptionFirstNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Methods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaptionFirstNumber;
        private System.Windows.Forms.Label lblCaptionSecondNumber;
        private System.Windows.Forms.Label lblCaptionResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbFirstNumber;
        private System.Windows.Forms.TextBox tbSecondNumber;
        private System.Windows.Forms.Button btnReturnValue;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnVoidMethod1;
        private System.Windows.Forms.Button btnVoidMethod2;
    }
}

