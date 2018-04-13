namespace _8_Problem_8_8_Sum_of_Numbers_in_a_String
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
            this.lblCapEnter = new System.Windows.Forms.Label();
            this.tbStringOfNumbers = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCapSum = new System.Windows.Forms.Label();
            this.lblOutputSum = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCapEnter
            // 
            this.lblCapEnter.AutoSize = true;
            this.lblCapEnter.Location = new System.Drawing.Point(53, 38);
            this.lblCapEnter.Name = "lblCapEnter";
            this.lblCapEnter.Size = new System.Drawing.Size(527, 24);
            this.lblCapEnter.TabIndex = 0;
            this.lblCapEnter.Text = "Enter a String containing Numbers divided by a Comma";
            // 
            // tbStringOfNumbers
            // 
            this.tbStringOfNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStringOfNumbers.Location = new System.Drawing.Point(57, 94);
            this.tbStringOfNumbers.Name = "tbStringOfNumbers";
            this.tbStringOfNumbers.Size = new System.Drawing.Size(514, 28);
            this.tbStringOfNumbers.TabIndex = 1;
            this.tbStringOfNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(58, 156);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(221, 48);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate Sum";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblCapSum
            // 
            this.lblCapSum.AutoSize = true;
            this.lblCapSum.Location = new System.Drawing.Point(323, 168);
            this.lblCapSum.Name = "lblCapSum";
            this.lblCapSum.Size = new System.Drawing.Size(58, 24);
            this.lblCapSum.TabIndex = 3;
            this.lblCapSum.Text = "Sum:";
            // 
            // lblOutputSum
            // 
            this.lblOutputSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputSum.Location = new System.Drawing.Point(387, 165);
            this.lblOutputSum.Name = "lblOutputSum";
            this.lblOutputSum.Size = new System.Drawing.Size(126, 29);
            this.lblOutputSum.TabIndex = 4;
            this.lblOutputSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(589, 156);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 48);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 239);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblOutputSum);
            this.Controls.Add(this.lblCapSum);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbStringOfNumbers);
            this.Controls.Add(this.lblCapEnter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Sum of Numbers in a String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCapEnter;
        private System.Windows.Forms.TextBox tbStringOfNumbers;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCapSum;
        private System.Windows.Forms.Label lblOutputSum;
        private System.Windows.Forms.Button btnExit;
    }
}

