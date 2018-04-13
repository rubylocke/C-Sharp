namespace Project_5_3_Prefix_and_Postfix
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
            this.lbEnterANumber = new System.Windows.Forms.Label();
            this.lbNumberValueCaption = new System.Windows.Forms.Label();
            this.lbNumberOutput = new System.Windows.Forms.Label();
            this.btnPrefix = new System.Windows.Forms.Button();
            this.btnPostfix = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbEnter = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEnterANumber
            // 
            this.lbEnterANumber.AutoSize = true;
            this.lbEnterANumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnterANumber.Location = new System.Drawing.Point(27, 31);
            this.lbEnterANumber.Name = "lbEnterANumber";
            this.lbEnterANumber.Size = new System.Drawing.Size(155, 24);
            this.lbEnterANumber.TabIndex = 0;
            this.lbEnterANumber.Text = "Enter a number";
            // 
            // lbNumberValueCaption
            // 
            this.lbNumberValueCaption.AutoSize = true;
            this.lbNumberValueCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberValueCaption.Location = new System.Drawing.Point(30, 94);
            this.lbNumberValueCaption.Name = "lbNumberValueCaption";
            this.lbNumberValueCaption.Size = new System.Drawing.Size(141, 24);
            this.lbNumberValueCaption.TabIndex = 1;
            this.lbNumberValueCaption.Text = "Number value";
            // 
            // lbNumberOutput
            // 
            this.lbNumberOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNumberOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOutput.Location = new System.Drawing.Point(218, 94);
            this.lbNumberOutput.Name = "lbNumberOutput";
            this.lbNumberOutput.Size = new System.Drawing.Size(85, 38);
            this.lbNumberOutput.TabIndex = 2;
            this.lbNumberOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbNumberOutput.Click += new System.EventHandler(this.lbNumberOutput_Click);
            // 
            // btnPrefix
            // 
            this.btnPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrefix.Location = new System.Drawing.Point(37, 173);
            this.btnPrefix.Name = "btnPrefix";
            this.btnPrefix.Size = new System.Drawing.Size(84, 43);
            this.btnPrefix.TabIndex = 3;
            this.btnPrefix.Text = "Prefix";
            this.btnPrefix.UseVisualStyleBackColor = true;
            this.btnPrefix.Click += new System.EventHandler(this.btnPrefix_Click);
            // 
            // btnPostfix
            // 
            this.btnPostfix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostfix.Location = new System.Drawing.Point(228, 173);
            this.btnPostfix.Name = "btnPostfix";
            this.btnPostfix.Size = new System.Drawing.Size(84, 43);
            this.btnPostfix.TabIndex = 4;
            this.btnPostfix.Text = "Postfix";
            this.btnPostfix.UseVisualStyleBackColor = true;
            this.btnPostfix.Click += new System.EventHandler(this.btnPostfix_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(37, 264);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 43);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbEnter
            // 
            this.tbEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnter.Location = new System.Drawing.Point(201, 28);
            this.tbEnter.Multiline = true;
            this.tbEnter.Name = "tbEnter";
            this.tbEnter.Size = new System.Drawing.Size(118, 35);
            this.tbEnter.TabIndex = 6;
            this.tbEnter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(228, 264);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 43);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 344);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbEnter);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPostfix);
            this.Controls.Add(this.btnPrefix);
            this.Controls.Add(this.lbNumberOutput);
            this.Controls.Add(this.lbNumberValueCaption);
            this.Controls.Add(this.lbEnterANumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Prefix and Postfix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEnterANumber;
        private System.Windows.Forms.Label lbNumberValueCaption;
        private System.Windows.Forms.Label lbNumberOutput;
        private System.Windows.Forms.Button btnPrefix;
        private System.Windows.Forms.Button btnPostfix;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbEnter;
        private System.Windows.Forms.Button btnExit;
    }
}

