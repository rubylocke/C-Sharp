namespace _8_Problem_8_7_Pig_Latin
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
            this.btnPigLatinConverter = new System.Windows.Forms.Button();
            this.lblCapEnterSentence = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.Label();
            this.tbInputSentence = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPigLatinConverter
            // 
            this.btnPigLatinConverter.Location = new System.Drawing.Point(48, 204);
            this.btnPigLatinConverter.Name = "btnPigLatinConverter";
            this.btnPigLatinConverter.Size = new System.Drawing.Size(143, 48);
            this.btnPigLatinConverter.TabIndex = 0;
            this.btnPigLatinConverter.Text = "Pig Latin";
            this.btnPigLatinConverter.UseVisualStyleBackColor = true;
            this.btnPigLatinConverter.Click += new System.EventHandler(this.btnPigLatinConverter_Click);
            // 
            // lblCapEnterSentence
            // 
            this.lblCapEnterSentence.AutoSize = true;
            this.lblCapEnterSentence.Location = new System.Drawing.Point(44, 24);
            this.lblCapEnterSentence.Name = "lblCapEnterSentence";
            this.lblCapEnterSentence.Size = new System.Drawing.Size(251, 24);
            this.lblCapEnterSentence.TabIndex = 1;
            this.lblCapEnterSentence.Text = "Enter a Normal Sentence:";
            // 
            // lbOutput
            // 
            this.lbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbOutput.Location = new System.Drawing.Point(48, 131);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(310, 33);
            this.lbOutput.TabIndex = 2;
            this.lbOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbInputSentence
            // 
            this.tbInputSentence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInputSentence.Location = new System.Drawing.Point(48, 71);
            this.tbInputSentence.Name = "tbInputSentence";
            this.tbInputSentence.Size = new System.Drawing.Size(310, 28);
            this.tbInputSentence.TabIndex = 3;
            this.tbInputSentence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(283, 204);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 48);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 287);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbInputSentence);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.lblCapEnterSentence);
            this.Controls.Add(this.btnPigLatinConverter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Pig Latin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPigLatinConverter;
        private System.Windows.Forms.Label lblCapEnterSentence;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.TextBox tbInputSentence;
        private System.Windows.Forms.Button btnExit;
    }
}

