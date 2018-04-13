namespace _8_Project_8_4_SSN_Formatter
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
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnFormat = new System.Windows.Forms.Button();
            this.lblNines = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCapEnter
            // 
            this.lblCapEnter.AutoSize = true;
            this.lblCapEnter.Location = new System.Drawing.Point(41, 42);
            this.lblCapEnter.Name = "lblCapEnter";
            this.lblCapEnter.Size = new System.Drawing.Size(436, 24);
            this.lblCapEnter.TabIndex = 0;
            this.lblCapEnter.Text = "Enter 9 digit number to be formatted as a SSN";
            // 
            // tbOutput
            // 
            this.tbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOutput.Location = new System.Drawing.Point(121, 127);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(214, 28);
            this.tbOutput.TabIndex = 1;
            this.tbOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(77, 183);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(299, 48);
            this.btnFormat.TabIndex = 2;
            this.btnFormat.Text = "Format as SSN";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // lblNines
            // 
            this.lblNines.AutoSize = true;
            this.lblNines.Location = new System.Drawing.Point(176, 80);
            this.lblNines.Name = "lblNines";
            this.lblNines.Size = new System.Drawing.Size(123, 24);
            this.lblNines.TabIndex = 3;
            this.lblNines.Text = "###-##-####";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 271);
            this.Controls.Add(this.lblNines);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.lblCapEnter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "SSN Formatter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCapEnter;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.Label lblNines;
    }
}

