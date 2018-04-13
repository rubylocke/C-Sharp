namespace Project_4__2_Switch
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
            this.lblEnterLetterGrade = new System.Windows.Forms.Label();
            this.lblABCDF = new System.Windows.Forms.Label();
            this.lblTextOutput = new System.Windows.Forms.Label();
            this.tbEnterLetter = new System.Windows.Forms.TextBox();
            this.btnGetResponse = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterLetterGrade
            // 
            this.lblEnterLetterGrade.AutoSize = true;
            this.lblEnterLetterGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterLetterGrade.Location = new System.Drawing.Point(33, 24);
            this.lblEnterLetterGrade.Name = "lblEnterLetterGrade";
            this.lblEnterLetterGrade.Size = new System.Drawing.Size(217, 24);
            this.lblEnterLetterGrade.TabIndex = 0;
            this.lblEnterLetterGrade.Text = "Enter letter grade only";
            // 
            // lblABCDF
            // 
            this.lblABCDF.AutoSize = true;
            this.lblABCDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABCDF.Location = new System.Drawing.Point(33, 71);
            this.lblABCDF.Name = "lblABCDF";
            this.lblABCDF.Size = new System.Drawing.Size(151, 24);
            this.lblABCDF.TabIndex = 1;
            this.lblABCDF.Text = "A, B, C, D, or F";
            // 
            // lblTextOutput
            // 
            this.lblTextOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTextOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextOutput.Location = new System.Drawing.Point(35, 109);
            this.lblTextOutput.Name = "lblTextOutput";
            this.lblTextOutput.Size = new System.Drawing.Size(454, 36);
            this.lblTextOutput.TabIndex = 2;
            this.lblTextOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEnterLetter
            // 
            this.tbEnterLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnterLetter.Location = new System.Drawing.Point(303, 24);
            this.tbEnterLetter.Name = "tbEnterLetter";
            this.tbEnterLetter.Size = new System.Drawing.Size(100, 28);
            this.tbEnterLetter.TabIndex = 3;
            this.tbEnterLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGetResponse
            // 
            this.btnGetResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetResponse.Location = new System.Drawing.Point(36, 171);
            this.btnGetResponse.Name = "btnGetResponse";
            this.btnGetResponse.Size = new System.Drawing.Size(148, 56);
            this.btnGetResponse.TabIndex = 4;
            this.btnGetResponse.Text = "&Get Response!";
            this.btnGetResponse.UseVisualStyleBackColor = true;
            this.btnGetResponse.Click += new System.EventHandler(this.btnGetResponse_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(209, 172);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 56);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(369, 171);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 56);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "C&lose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 253);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGetResponse);
            this.Controls.Add(this.tbEnterLetter);
            this.Controls.Add(this.lblTextOutput);
            this.Controls.Add(this.lblABCDF);
            this.Controls.Add(this.lblEnterLetterGrade);
            this.Name = "Form1";
            this.Text = "Letter Grade Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterLetterGrade;
        private System.Windows.Forms.Label lblABCDF;
        private System.Windows.Forms.Label lblTextOutput;
        private System.Windows.Forms.TextBox tbEnterLetter;
        private System.Windows.Forms.Button btnGetResponse;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}

