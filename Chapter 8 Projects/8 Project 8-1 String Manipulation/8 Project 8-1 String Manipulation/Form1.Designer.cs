namespace _8_Project_8_1_String_Manipulation
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.tbString = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnUpper = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnLength = new System.Windows.Forms.Button();
            this.btnSearchForUpper = new System.Windows.Forms.Button();
            this.btnSearchForLower = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(35, 34);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(258, 24);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Enter a string, no numbers";
            // 
            // tbString
            // 
            this.tbString.Location = new System.Drawing.Point(39, 90);
            this.tbString.Name = "tbString";
            this.tbString.Size = new System.Drawing.Size(386, 28);
            this.tbString.TabIndex = 1;
            this.tbString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(39, 145);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(386, 33);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpper
            // 
            this.btnUpper.Location = new System.Drawing.Point(39, 206);
            this.btnUpper.Name = "btnUpper";
            this.btnUpper.Size = new System.Drawing.Size(110, 38);
            this.btnUpper.TabIndex = 3;
            this.btnUpper.Text = "Upper";
            this.btnUpper.UseVisualStyleBackColor = true;
            this.btnUpper.Click += new System.EventHandler(this.btnUpper_Click);
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(188, 206);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(94, 38);
            this.btnLower.TabIndex = 4;
            this.btnLower.Text = "lower";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnLength
            // 
            this.btnLength.Location = new System.Drawing.Point(321, 206);
            this.btnLength.Name = "btnLength";
            this.btnLength.Size = new System.Drawing.Size(104, 38);
            this.btnLength.TabIndex = 5;
            this.btnLength.Text = "Length";
            this.btnLength.UseVisualStyleBackColor = true;
            this.btnLength.Click += new System.EventHandler(this.btnLength_Click);
            // 
            // btnSearchForUpper
            // 
            this.btnSearchForUpper.Location = new System.Drawing.Point(12, 282);
            this.btnSearchForUpper.Name = "btnSearchForUpper";
            this.btnSearchForUpper.Size = new System.Drawing.Size(198, 38);
            this.btnSearchForUpper.TabIndex = 6;
            this.btnSearchForUpper.Text = "Search for UPPER";
            this.btnSearchForUpper.UseVisualStyleBackColor = true;
            this.btnSearchForUpper.Click += new System.EventHandler(this.btnSearchForUpper_Click);
            // 
            // btnSearchForLower
            // 
            this.btnSearchForLower.Location = new System.Drawing.Point(240, 282);
            this.btnSearchForLower.Name = "btnSearchForLower";
            this.btnSearchForLower.Size = new System.Drawing.Size(199, 38);
            this.btnSearchForLower.TabIndex = 7;
            this.btnSearchForLower.Text = "Search for lower";
            this.btnSearchForLower.UseVisualStyleBackColor = true;
            this.btnSearchForLower.Click += new System.EventHandler(this.btnSearchForLower_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 348);
            this.Controls.Add(this.btnSearchForLower);
            this.Controls.Add(this.btnSearchForUpper);
            this.Controls.Add(this.btnLength);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnUpper);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.tbString);
            this.Controls.Add(this.lblInstructions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "String Manipulatoin#1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox tbString;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnUpper;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Button btnLength;
        private System.Windows.Forms.Button btnSearchForUpper;
        private System.Windows.Forms.Button btnSearchForLower;
    }
}

