namespace _6_Project_2_Passing_Arguments
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
            this.lblCaptionEnterAge = new System.Windows.Forms.Label();
            this.tbEnterAge = new System.Windows.Forms.TextBox();
            this.btnValue = new System.Windows.Forms.Button();
            this.btnReference = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCaptionEnterAge
            // 
            this.lblCaptionEnterAge.AutoSize = true;
            this.lblCaptionEnterAge.Location = new System.Drawing.Point(76, 53);
            this.lblCaptionEnterAge.Name = "lblCaptionEnterAge";
            this.lblCaptionEnterAge.Size = new System.Drawing.Size(104, 24);
            this.lblCaptionEnterAge.TabIndex = 0;
            this.lblCaptionEnterAge.Text = "Enter Age";
            // 
            // tbEnterAge
            // 
            this.tbEnterAge.Location = new System.Drawing.Point(220, 50);
            this.tbEnterAge.Name = "tbEnterAge";
            this.tbEnterAge.Size = new System.Drawing.Size(151, 28);
            this.tbEnterAge.TabIndex = 1;
            this.tbEnterAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnValue
            // 
            this.btnValue.Location = new System.Drawing.Point(31, 126);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(157, 38);
            this.btnValue.TabIndex = 2;
            this.btnValue.Text = "By Value";
            this.btnValue.UseVisualStyleBackColor = true;
            this.btnValue.Click += new System.EventHandler(this.btnValue_Click);
            // 
            // btnReference
            // 
            this.btnReference.Location = new System.Drawing.Point(220, 126);
            this.btnReference.Name = "btnReference";
            this.btnReference.Size = new System.Drawing.Size(157, 38);
            this.btnReference.TabIndex = 3;
            this.btnReference.Text = "By Reference";
            this.btnReference.UseVisualStyleBackColor = true;
            this.btnReference.Click += new System.EventHandler(this.btnReference_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(406, 126);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(157, 38);
            this.btnOutput.TabIndex = 4;
            this.btnOutput.Text = "By Output";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(192, 209);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 54);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(332, 209);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 54);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "E&xit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 285);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnReference);
            this.Controls.Add(this.btnValue);
            this.Controls.Add(this.tbEnterAge);
            this.Controls.Add(this.lblCaptionEnterAge);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Passing Arguments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaptionEnterAge;
        private System.Windows.Forms.TextBox tbEnterAge;
        private System.Windows.Forms.Button btnValue;
        private System.Windows.Forms.Button btnReference;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}

