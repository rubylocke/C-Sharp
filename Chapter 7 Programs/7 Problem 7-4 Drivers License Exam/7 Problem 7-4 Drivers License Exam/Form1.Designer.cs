namespace _7_Problem_7_4_Drivers_License_Exam
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
            this.btnReadFile = new System.Windows.Forms.Button();
            this.lblPassFail = new System.Windows.Forms.Label();
            this.lblCapCorrect = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblCapQuestionsWrong = new System.Windows.Forms.Label();
            this.lstQuestionsWrong = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(44, 36);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(252, 45);
            this.btnReadFile.TabIndex = 0;
            this.btnReadFile.Text = "Get Student Scores";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // lblPassFail
            // 
            this.lblPassFail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPassFail.Location = new System.Drawing.Point(114, 102);
            this.lblPassFail.Name = "lblPassFail";
            this.lblPassFail.Size = new System.Drawing.Size(135, 48);
            this.lblPassFail.TabIndex = 1;
            this.lblPassFail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCapCorrect
            // 
            this.lblCapCorrect.AutoSize = true;
            this.lblCapCorrect.Location = new System.Drawing.Point(30, 212);
            this.lblCapCorrect.Name = "lblCapCorrect";
            this.lblCapCorrect.Size = new System.Drawing.Size(164, 24);
            this.lblCapCorrect.TabIndex = 2;
            this.lblCapCorrect.Text = "Correct Answers";
            this.lblCapCorrect.Click += new System.EventHandler(this.lblCapCorrect_Click);
            // 
            // lblCorrect
            // 
            this.lblCorrect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCorrect.Location = new System.Drawing.Point(216, 201);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(108, 44);
            this.lblCorrect.TabIndex = 3;
            this.lblCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCorrect.Click += new System.EventHandler(this.lblCorrect_Click);
            // 
            // lblCapQuestionsWrong
            // 
            this.lblCapQuestionsWrong.AutoSize = true;
            this.lblCapQuestionsWrong.Location = new System.Drawing.Point(22, 302);
            this.lblCapQuestionsWrong.Name = "lblCapQuestionsWrong";
            this.lblCapQuestionsWrong.Size = new System.Drawing.Size(172, 24);
            this.lblCapQuestionsWrong.TabIndex = 4;
            this.lblCapQuestionsWrong.Text = "Questions Wrong";
            // 
            // lstQuestionsWrong
            // 
            this.lstQuestionsWrong.FormattingEnabled = true;
            this.lstQuestionsWrong.ItemHeight = 22;
            this.lstQuestionsWrong.Location = new System.Drawing.Point(35, 329);
            this.lstQuestionsWrong.Name = "lstQuestionsWrong";
            this.lstQuestionsWrong.Size = new System.Drawing.Size(150, 114);
            this.lstQuestionsWrong.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(35, 470);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 45);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(203, 470);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 45);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "E&xit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 539);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstQuestionsWrong);
            this.Controls.Add(this.lblCapQuestionsWrong);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblCapCorrect);
            this.Controls.Add(this.lblPassFail);
            this.Controls.Add(this.btnReadFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Driver\'s License Exam";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Label lblPassFail;
        private System.Windows.Forms.Label lblCapCorrect;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblCapQuestionsWrong;
        private System.Windows.Forms.ListBox lstQuestionsWrong;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}

