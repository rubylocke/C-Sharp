namespace _10_Project_10_1_Encapsulation
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
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.tbSecond = new System.Windows.Forms.TextBox();
            this.lblEntNumber1 = new System.Windows.Forms.Label();
            this.lblEntNumber2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFirst
            // 
            this.tbFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFirst.Location = new System.Drawing.Point(321, 38);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(124, 28);
            this.tbFirst.TabIndex = 0;
            this.tbFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSecond
            // 
            this.tbSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSecond.Location = new System.Drawing.Point(321, 101);
            this.tbSecond.Name = "tbSecond";
            this.tbSecond.Size = new System.Drawing.Size(124, 28);
            this.tbSecond.TabIndex = 1;
            this.tbSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEntNumber1
            // 
            this.lblEntNumber1.AutoSize = true;
            this.lblEntNumber1.Location = new System.Drawing.Point(65, 38);
            this.lblEntNumber1.Name = "lblEntNumber1";
            this.lblEntNumber1.Size = new System.Drawing.Size(217, 24);
            this.lblEntNumber1.TabIndex = 2;
            this.lblEntNumber1.Text = "Enter the first number!";
            this.lblEntNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEntNumber2
            // 
            this.lblEntNumber2.AutoSize = true;
            this.lblEntNumber2.Location = new System.Drawing.Point(28, 101);
            this.lblEntNumber2.Name = "lblEntNumber2";
            this.lblEntNumber2.Size = new System.Drawing.Size(254, 24);
            this.lblEntNumber2.TabIndex = 3;
            this.lblEntNumber2.Text = "Enter the second number!";
            this.lblEntNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(110, 174);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 48);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(291, 174);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 48);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 267);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblEntNumber2);
            this.Controls.Add(this.lblEntNumber1);
            this.Controls.Add(this.tbSecond);
            this.Controls.Add(this.tbFirst);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Encapsulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirst;
        private System.Windows.Forms.TextBox tbSecond;
        private System.Windows.Forms.Label lblEntNumber1;
        private System.Windows.Forms.Label lblEntNumber2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
    }
}

