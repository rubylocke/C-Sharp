namespace Project_4_1_ifStatement
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
            this.lblEnterGrade = new System.Windows.Forms.Label();
            this.lbLetterGradeCaption = new System.Windows.Forms.Label();
            this.lblLetterGrade = new System.Windows.Forms.Label();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.btnGtGrade = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterGrade
            // 
            this.lblEnterGrade.AutoSize = true;
            this.lblEnterGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterGrade.Location = new System.Drawing.Point(16, 27);
            this.lblEnterGrade.Name = "lblEnterGrade";
            this.lblEnterGrade.Size = new System.Drawing.Size(164, 24);
            this.lblEnterGrade.TabIndex = 0;
            this.lblEnterGrade.Text = "Enter test grade!";
            this.lblEnterGrade.Click += new System.EventHandler(this.lblEnterGrade_Click);
            // 
            // lbLetterGradeCaption
            // 
            this.lbLetterGradeCaption.AutoSize = true;
            this.lbLetterGradeCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLetterGradeCaption.Location = new System.Drawing.Point(16, 84);
            this.lbLetterGradeCaption.Name = "lbLetterGradeCaption";
            this.lbLetterGradeCaption.Size = new System.Drawing.Size(125, 24);
            this.lbLetterGradeCaption.TabIndex = 1;
            this.lbLetterGradeCaption.Text = "Letter Grade";
            // 
            // lblLetterGrade
            // 
            this.lblLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetterGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetterGrade.Location = new System.Drawing.Point(232, 75);
            this.lblLetterGrade.Name = "lblLetterGrade";
            this.lblLetterGrade.Size = new System.Drawing.Size(100, 43);
            this.lblLetterGrade.TabIndex = 2;
            this.lblLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbGrade
            // 
            this.tbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGrade.Location = new System.Drawing.Point(232, 24);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(100, 28);
            this.tbGrade.TabIndex = 3;
            this.tbGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGtGrade
            // 
            this.btnGtGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGtGrade.Location = new System.Drawing.Point(31, 177);
            this.btnGtGrade.Name = "btnGtGrade";
            this.btnGtGrade.Size = new System.Drawing.Size(90, 61);
            this.btnGtGrade.TabIndex = 4;
            this.btnGtGrade.Text = "Get Grade!";
            this.btnGtGrade.UseVisualStyleBackColor = true;
            this.btnGtGrade.Click += new System.EventHandler(this.btnGtGrade_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(181, 177);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 61);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(330, 177);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 61);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "C&lose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 291);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGtGrade);
            this.Controls.Add(this.tbGrade);
            this.Controls.Add(this.lblLetterGrade);
            this.Controls.Add(this.lbLetterGradeCaption);
            this.Controls.Add(this.lblEnterGrade);
            this.Name = "Form1";
            this.Text = "Grade Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterGrade;
        private System.Windows.Forms.Label lbLetterGradeCaption;
        private System.Windows.Forms.Label lblLetterGrade;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.Button btnGtGrade;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}

