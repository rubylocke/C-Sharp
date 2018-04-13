namespace TryCatch
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
            this.arrayElementsButton = new System.Windows.Forms.Button();
            this.gnerateExceptionButton = new System.Windows.Forms.Button();
            this.catchTheExceptionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arrayElementsButton
            // 
            this.arrayElementsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrayElementsButton.Location = new System.Drawing.Point(12, 35);
            this.arrayElementsButton.Name = "arrayElementsButton";
            this.arrayElementsButton.Size = new System.Drawing.Size(258, 36);
            this.arrayElementsButton.TabIndex = 0;
            this.arrayElementsButton.Text = "Array Elements";
            this.arrayElementsButton.UseVisualStyleBackColor = true;
            this.arrayElementsButton.Click += new System.EventHandler(this.arrayElementsButton_Click);
            // 
            // gnerateExceptionButton
            // 
            this.gnerateExceptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnerateExceptionButton.Location = new System.Drawing.Point(12, 89);
            this.gnerateExceptionButton.Name = "gnerateExceptionButton";
            this.gnerateExceptionButton.Size = new System.Drawing.Size(258, 36);
            this.gnerateExceptionButton.TabIndex = 1;
            this.gnerateExceptionButton.Text = "Generate Exception";
            this.gnerateExceptionButton.UseVisualStyleBackColor = true;
            this.gnerateExceptionButton.Click += new System.EventHandler(this.gnerateExceptionButton_Click);
            // 
            // catchTheExceptionButton
            // 
            this.catchTheExceptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catchTheExceptionButton.Location = new System.Drawing.Point(12, 148);
            this.catchTheExceptionButton.Name = "catchTheExceptionButton";
            this.catchTheExceptionButton.Size = new System.Drawing.Size(258, 36);
            this.catchTheExceptionButton.TabIndex = 2;
            this.catchTheExceptionButton.Text = "Catch The Exception";
            this.catchTheExceptionButton.UseVisualStyleBackColor = true;
            this.catchTheExceptionButton.Click += new System.EventHandler(this.catchTheExceptionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.catchTheExceptionButton);
            this.Controls.Add(this.gnerateExceptionButton);
            this.Controls.Add(this.arrayElementsButton);
            this.Name = "Form1";
            this.Text = "TryCatch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button arrayElementsButton;
        private System.Windows.Forms.Button gnerateExceptionButton;
        private System.Windows.Forms.Button catchTheExceptionButton;
    }
}

