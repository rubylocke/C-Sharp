namespace _10_Project_10_4_Abstraction
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
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCapLength = new System.Windows.Forms.Label();
            this.lblCapWidth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(193, 43);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(108, 28);
            this.tbLength.TabIndex = 0;
            this.tbLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(193, 98);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(108, 28);
            this.tbWidth.TabIndex = 1;
            this.tbWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(46, 167);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(142, 42);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(227, 167);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 42);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCapLength
            // 
            this.lblCapLength.AutoSize = true;
            this.lblCapLength.Location = new System.Drawing.Point(42, 40);
            this.lblCapLength.Name = "lblCapLength";
            this.lblCapLength.Size = new System.Drawing.Size(130, 24);
            this.lblCapLength.TabIndex = 4;
            this.lblCapLength.Text = "Enter Length";
            this.lblCapLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCapWidth
            // 
            this.lblCapWidth.AutoSize = true;
            this.lblCapWidth.Location = new System.Drawing.Point(53, 102);
            this.lblCapWidth.Name = "lblCapWidth";
            this.lblCapWidth.Size = new System.Drawing.Size(119, 24);
            this.lblCapWidth.TabIndex = 5;
            this.lblCapWidth.Text = "Enter Width";
            this.lblCapWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 245);
            this.Controls.Add(this.lblCapWidth);
            this.Controls.Add(this.lblCapLength);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.tbLength);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Abstraction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCapLength;
        private System.Windows.Forms.Label lblCapWidth;
    }
}

