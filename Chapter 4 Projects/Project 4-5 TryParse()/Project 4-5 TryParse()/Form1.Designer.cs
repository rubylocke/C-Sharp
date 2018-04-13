namespace Project_4_5_TryParse__
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
            this.tbEnterInteger = new System.Windows.Forms.TextBox();
            this.tbEnterAlphanumeric = new System.Windows.Forms.TextBox();
            this.lblEnterIntegerCaption = new System.Windows.Forms.Label();
            this.lblEnterAlphaCaption = new System.Windows.Forms.Label();
            this.lblNoDecimalCaption = new System.Windows.Forms.Label();
            this.btnParse = new System.Windows.Forms.Button();
            this.btnTryParse = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbEnterInteger
            // 
            this.tbEnterInteger.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnterInteger.Location = new System.Drawing.Point(323, 31);
            this.tbEnterInteger.Name = "tbEnterInteger";
            this.tbEnterInteger.Size = new System.Drawing.Size(100, 38);
            this.tbEnterInteger.TabIndex = 0;
            this.tbEnterInteger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEnterAlphanumeric
            // 
            this.tbEnterAlphanumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnterAlphanumeric.Location = new System.Drawing.Point(323, 94);
            this.tbEnterAlphanumeric.Name = "tbEnterAlphanumeric";
            this.tbEnterAlphanumeric.Size = new System.Drawing.Size(100, 38);
            this.tbEnterAlphanumeric.TabIndex = 1;
            this.tbEnterAlphanumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEnterIntegerCaption
            // 
            this.lblEnterIntegerCaption.AutoSize = true;
            this.lblEnterIntegerCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterIntegerCaption.Location = new System.Drawing.Point(13, 35);
            this.lblEnterIntegerCaption.Name = "lblEnterIntegerCaption";
            this.lblEnterIntegerCaption.Size = new System.Drawing.Size(233, 24);
            this.lblEnterIntegerCaption.TabIndex = 2;
            this.lblEnterIntegerCaption.Text = "Enter an integer (Parse)";
            // 
            // lblEnterAlphaCaption
            // 
            this.lblEnterAlphaCaption.AutoSize = true;
            this.lblEnterAlphaCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterAlphaCaption.Location = new System.Drawing.Point(13, 98);
            this.lblEnterAlphaCaption.Name = "lblEnterAlphaCaption";
            this.lblEnterAlphaCaption.Size = new System.Drawing.Size(193, 24);
            this.lblEnterAlphaCaption.TabIndex = 3;
            this.lblEnterAlphaCaption.Text = "Enter alphanumeric";
            // 
            // lblNoDecimalCaption
            // 
            this.lblNoDecimalCaption.AutoSize = true;
            this.lblNoDecimalCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDecimalCaption.Location = new System.Drawing.Point(15, 131);
            this.lblNoDecimalCaption.Name = "lblNoDecimalCaption";
            this.lblNoDecimalCaption.Size = new System.Drawing.Size(271, 24);
            this.lblNoDecimalCaption.TabIndex = 4;
            this.lblNoDecimalCaption.Text = "No decimal point (TryParse)";
            // 
            // btnParse
            // 
            this.btnParse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParse.Location = new System.Drawing.Point(19, 218);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(118, 70);
            this.btnParse.TabIndex = 5;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // btnTryParse
            // 
            this.btnTryParse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTryParse.Location = new System.Drawing.Point(184, 218);
            this.btnTryParse.Name = "btnTryParse";
            this.btnTryParse.Size = new System.Drawing.Size(119, 70);
            this.btnTryParse.TabIndex = 6;
            this.btnTryParse.Text = "TryParse";
            this.btnTryParse.UseVisualStyleBackColor = true;
            this.btnTryParse.Click += new System.EventHandler(this.btnTryParse_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(348, 218);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 70);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 314);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTryParse);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.lblNoDecimalCaption);
            this.Controls.Add(this.lblEnterAlphaCaption);
            this.Controls.Add(this.lblEnterIntegerCaption);
            this.Controls.Add(this.tbEnterAlphanumeric);
            this.Controls.Add(this.tbEnterInteger);
            this.Name = "Form1";
            this.Text = "TryParse()";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEnterInteger;
        private System.Windows.Forms.TextBox tbEnterAlphanumeric;
        private System.Windows.Forms.Label lblEnterIntegerCaption;
        private System.Windows.Forms.Label lblEnterAlphaCaption;
        private System.Windows.Forms.Label lblNoDecimalCaption;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Button btnTryParse;
        private System.Windows.Forms.Button btnClose;
    }
}

