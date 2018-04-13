namespace _8_Problem_6_Word_Separator
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
            this.lblCapEnterSentence = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnReformat = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblReformat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCapEnterSentence
            // 
            this.lblCapEnterSentence.AutoSize = true;
            this.lblCapEnterSentence.Location = new System.Drawing.Point(50, 42);
            this.lblCapEnterSentence.Name = "lblCapEnterSentence";
            this.lblCapEnterSentence.Size = new System.Drawing.Size(289, 24);
            this.lblCapEnterSentence.TabIndex = 0;
            this.lblCapEnterSentence.Text = "Enter a Sentence in one word";
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(12, 173);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(346, 38);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbInput
            // 
            this.tbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInput.Location = new System.Drawing.Point(12, 81);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(346, 28);
            this.tbInput.TabIndex = 2;
            this.tbInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReformat
            // 
            this.btnReformat.Location = new System.Drawing.Point(54, 251);
            this.btnReformat.Name = "btnReformat";
            this.btnReformat.Size = new System.Drawing.Size(171, 49);
            this.btnReformat.TabIndex = 3;
            this.btnReformat.Text = "ReFormatter";
            this.btnReformat.UseVisualStyleBackColor = true;
            this.btnReformat.Click += new System.EventHandler(this.btnReformat_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(283, 251);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 49);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblReformat
            // 
            this.lblReformat.AutoSize = true;
            this.lblReformat.Location = new System.Drawing.Point(54, 134);
            this.lblReformat.Name = "lblReformat";
            this.lblReformat.Size = new System.Drawing.Size(99, 24);
            this.lblReformat.TabIndex = 5;
            this.lblReformat.Text = "Reformat:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 348);
            this.Controls.Add(this.lblReformat);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReformat);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblCapEnterSentence);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Word Separator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCapEnterSentence;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnReformat;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblReformat;
    }
}

