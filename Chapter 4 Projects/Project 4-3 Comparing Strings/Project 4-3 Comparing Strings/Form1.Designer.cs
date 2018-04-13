namespace Project_4_3_Comparing_Strings
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
            this.lblEnterFirstString = new System.Windows.Forms.Label();
            this.lblEnterSecondString = new System.Windows.Forms.Label();
            this.lblEqual = new System.Windows.Forms.Label();
            this.lblUnEqual = new System.Windows.Forms.Label();
            this.tbFirstString = new System.Windows.Forms.TextBox();
            this.tbSecondString = new System.Windows.Forms.TextBox();
            this.btnCompare1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCompare2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterFirstString
            // 
            this.lblEnterFirstString.AutoSize = true;
            this.lblEnterFirstString.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterFirstString.Location = new System.Drawing.Point(13, 29);
            this.lblEnterFirstString.Name = "lblEnterFirstString";
            this.lblEnterFirstString.Size = new System.Drawing.Size(190, 24);
            this.lblEnterFirstString.TabIndex = 0;
            this.lblEnterFirstString.Text = "Enter the first string";
            // 
            // lblEnterSecondString
            // 
            this.lblEnterSecondString.AutoSize = true;
            this.lblEnterSecondString.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterSecondString.Location = new System.Drawing.Point(13, 83);
            this.lblEnterSecondString.Name = "lblEnterSecondString";
            this.lblEnterSecondString.Size = new System.Drawing.Size(227, 24);
            this.lblEnterSecondString.TabIndex = 1;
            this.lblEnterSecondString.Text = "Enter the second string";
            // 
            // lblEqual
            // 
            this.lblEqual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqual.Location = new System.Drawing.Point(32, 137);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(228, 37);
            this.lblEqual.TabIndex = 2;
            this.lblEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnEqual
            // 
            this.lblUnEqual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnEqual.Location = new System.Drawing.Point(323, 137);
            this.lblUnEqual.Name = "lblUnEqual";
            this.lblUnEqual.Size = new System.Drawing.Size(237, 37);
            this.lblUnEqual.TabIndex = 3;
            this.lblUnEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbFirstString
            // 
            this.tbFirstString.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstString.Location = new System.Drawing.Point(273, 29);
            this.tbFirstString.Name = "tbFirstString";
            this.tbFirstString.Size = new System.Drawing.Size(287, 28);
            this.tbFirstString.TabIndex = 4;
            this.tbFirstString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSecondString
            // 
            this.tbSecondString.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSecondString.Location = new System.Drawing.Point(273, 83);
            this.tbSecondString.Name = "tbSecondString";
            this.tbSecondString.Size = new System.Drawing.Size(287, 28);
            this.tbSecondString.TabIndex = 5;
            this.tbSecondString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCompare1
            // 
            this.btnCompare1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompare1.Location = new System.Drawing.Point(121, 219);
            this.btnCompare1.Name = "btnCompare1";
            this.btnCompare1.Size = new System.Drawing.Size(125, 54);
            this.btnCompare1.TabIndex = 6;
            this.btnCompare1.Text = "Compare 1";
            this.btnCompare1.UseVisualStyleBackColor = true;
            this.btnCompare1.Click += new System.EventHandler(this.btnCompare1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(121, 309);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 54);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCompare2
            // 
            this.btnCompare2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompare2.Location = new System.Drawing.Point(273, 219);
            this.btnCompare2.Name = "btnCompare2";
            this.btnCompare2.Size = new System.Drawing.Size(125, 54);
            this.btnCompare2.TabIndex = 8;
            this.btnCompare2.Text = "Compare 2";
            this.btnCompare2.UseVisualStyleBackColor = true;
            this.btnCompare2.Click += new System.EventHandler(this.btnCompare2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(273, 308);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 54);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 374);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCompare2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCompare1);
            this.Controls.Add(this.tbSecondString);
            this.Controls.Add(this.tbFirstString);
            this.Controls.Add(this.lblUnEqual);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.lblEnterSecondString);
            this.Controls.Add(this.lblEnterFirstString);
            this.Name = "Form1";
            this.Text = "Comparing Strings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterFirstString;
        private System.Windows.Forms.Label lblEnterSecondString;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.Label lblUnEqual;
        private System.Windows.Forms.TextBox tbFirstString;
        private System.Windows.Forms.TextBox tbSecondString;
        private System.Windows.Forms.Button btnCompare1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCompare2;
        private System.Windows.Forms.Button btnClose;
    }
}

