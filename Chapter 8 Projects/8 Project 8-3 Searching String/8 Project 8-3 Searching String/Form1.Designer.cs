namespace _8_Project_8_3_Searching_String
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
            this.btnContain = new System.Windows.Forms.Button();
            this.btnFormat = new System.Windows.Forms.Button();
            this.btnSubstring = new System.Windows.Forms.Button();
            this.btnStringToChar = new System.Windows.Forms.Button();
            this.btnStartsWith = new System.Windows.Forms.Button();
            this.btnEndsWith = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCapEnter
            // 
            this.lblCapEnter.AutoSize = true;
            this.lblCapEnter.Location = new System.Drawing.Point(198, 36);
            this.lblCapEnter.Name = "lblCapEnter";
            this.lblCapEnter.Size = new System.Drawing.Size(140, 24);
            this.lblCapEnter.TabIndex = 0;
            this.lblCapEnter.Text = "Enter a string!";
            // 
            // btnContain
            // 
            this.btnContain.Location = new System.Drawing.Point(12, 180);
            this.btnContain.Name = "btnContain";
            this.btnContain.Size = new System.Drawing.Size(163, 44);
            this.btnContain.TabIndex = 2;
            this.btnContain.Text = "Contain";
            this.btnContain.UseVisualStyleBackColor = true;
            this.btnContain.Click += new System.EventHandler(this.btnContain_Click);
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(202, 179);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(139, 44);
            this.btnFormat.TabIndex = 3;
            this.btnFormat.Text = "Format";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // btnSubstring
            // 
            this.btnSubstring.Location = new System.Drawing.Point(365, 180);
            this.btnSubstring.Name = "btnSubstring";
            this.btnSubstring.Size = new System.Drawing.Size(124, 44);
            this.btnSubstring.TabIndex = 4;
            this.btnSubstring.Text = "Substring";
            this.btnSubstring.UseVisualStyleBackColor = true;
            this.btnSubstring.Click += new System.EventHandler(this.btnSubstring_Click);
            // 
            // btnStringToChar
            // 
            this.btnStringToChar.Location = new System.Drawing.Point(12, 272);
            this.btnStringToChar.Name = "btnStringToChar";
            this.btnStringToChar.Size = new System.Drawing.Size(163, 44);
            this.btnStringToChar.TabIndex = 5;
            this.btnStringToChar.Text = "String to Char";
            this.btnStringToChar.UseVisualStyleBackColor = true;
            this.btnStringToChar.Click += new System.EventHandler(this.btnStringToChar_Click);
            // 
            // btnStartsWith
            // 
            this.btnStartsWith.Location = new System.Drawing.Point(202, 271);
            this.btnStartsWith.Name = "btnStartsWith";
            this.btnStartsWith.Size = new System.Drawing.Size(139, 44);
            this.btnStartsWith.TabIndex = 6;
            this.btnStartsWith.Text = "Starts With";
            this.btnStartsWith.UseVisualStyleBackColor = true;
            this.btnStartsWith.Click += new System.EventHandler(this.btnStartsWith_Click);
            // 
            // btnEndsWith
            // 
            this.btnEndsWith.Location = new System.Drawing.Point(365, 271);
            this.btnEndsWith.Name = "btnEndsWith";
            this.btnEndsWith.Size = new System.Drawing.Size(124, 44);
            this.btnEndsWith.TabIndex = 7;
            this.btnEndsWith.Text = "Ends With";
            this.btnEndsWith.UseVisualStyleBackColor = true;
            this.btnEndsWith.Click += new System.EventHandler(this.btnEndsWith_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(118, 96);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(302, 30);
            this.tbInput.TabIndex = 8;
            this.tbInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 348);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnEndsWith);
            this.Controls.Add(this.btnStartsWith);
            this.Controls.Add(this.btnStringToChar);
            this.Controls.Add(this.btnSubstring);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.btnContain);
            this.Controls.Add(this.lblCapEnter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Searching String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCapEnter;
        private System.Windows.Forms.Button btnContain;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.Button btnSubstring;
        private System.Windows.Forms.Button btnStringToChar;
        private System.Windows.Forms.Button btnStartsWith;
        private System.Windows.Forms.Button btnEndsWith;
        private System.Windows.Forms.TextBox tbInput;
    }
}

