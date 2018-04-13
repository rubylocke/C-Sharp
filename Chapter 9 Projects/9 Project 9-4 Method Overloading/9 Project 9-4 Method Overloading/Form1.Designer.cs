namespace _9_Project_9_4_Method_Overloading
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
            this.tbEnterFirst = new System.Windows.Forms.TextBox();
            this.tbEnterIntLast = new System.Windows.Forms.TextBox();
            this.btnOverloadInt1 = new System.Windows.Forms.Button();
            this.btnOverloadStr1 = new System.Windows.Forms.Button();
            this.btnOverloadInt2 = new System.Windows.Forms.Button();
            this.btnOverloadStr2 = new System.Windows.Forms.Button();
            this.lblEnterIntFirst = new System.Windows.Forms.Label();
            this.lblEnterIntLast = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbEnterFirst
            // 
            this.tbEnterFirst.Location = new System.Drawing.Point(319, 24);
            this.tbEnterFirst.Name = "tbEnterFirst";
            this.tbEnterFirst.Size = new System.Drawing.Size(279, 28);
            this.tbEnterFirst.TabIndex = 0;
            this.tbEnterFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEnterIntLast
            // 
            this.tbEnterIntLast.Location = new System.Drawing.Point(319, 79);
            this.tbEnterIntLast.Name = "tbEnterIntLast";
            this.tbEnterIntLast.Size = new System.Drawing.Size(279, 28);
            this.tbEnterIntLast.TabIndex = 1;
            this.tbEnterIntLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOverloadInt1
            // 
            this.btnOverloadInt1.Location = new System.Drawing.Point(20, 139);
            this.btnOverloadInt1.Name = "btnOverloadInt1";
            this.btnOverloadInt1.Size = new System.Drawing.Size(276, 34);
            this.btnOverloadInt1.TabIndex = 2;
            this.btnOverloadInt1.Text = "Overload int Method 1";
            this.btnOverloadInt1.UseVisualStyleBackColor = true;
            this.btnOverloadInt1.Click += new System.EventHandler(this.btnOverloadInt1_Click);
            // 
            // btnOverloadStr1
            // 
            this.btnOverloadStr1.Location = new System.Drawing.Point(20, 210);
            this.btnOverloadStr1.Name = "btnOverloadStr1";
            this.btnOverloadStr1.Size = new System.Drawing.Size(276, 34);
            this.btnOverloadStr1.TabIndex = 3;
            this.btnOverloadStr1.Text = "Overload Str. Method 1";
            this.btnOverloadStr1.UseVisualStyleBackColor = true;
            this.btnOverloadStr1.Click += new System.EventHandler(this.btnOverloadStr1_Click);
            // 
            // btnOverloadInt2
            // 
            this.btnOverloadInt2.Location = new System.Drawing.Point(343, 139);
            this.btnOverloadInt2.Name = "btnOverloadInt2";
            this.btnOverloadInt2.Size = new System.Drawing.Size(276, 34);
            this.btnOverloadInt2.TabIndex = 4;
            this.btnOverloadInt2.Text = "Overload int Method 2";
            this.btnOverloadInt2.UseVisualStyleBackColor = true;
            this.btnOverloadInt2.Click += new System.EventHandler(this.btnOverloadInt2_Click);
            // 
            // btnOverloadStr2
            // 
            this.btnOverloadStr2.Location = new System.Drawing.Point(343, 210);
            this.btnOverloadStr2.Name = "btnOverloadStr2";
            this.btnOverloadStr2.Size = new System.Drawing.Size(276, 34);
            this.btnOverloadStr2.TabIndex = 5;
            this.btnOverloadStr2.Text = "Overload Str. Method 2";
            this.btnOverloadStr2.UseVisualStyleBackColor = true;
            this.btnOverloadStr2.Click += new System.EventHandler(this.btnOverloadStr2_Click);
            // 
            // lblEnterIntFirst
            // 
            this.lblEnterIntFirst.AutoSize = true;
            this.lblEnterIntFirst.Location = new System.Drawing.Point(20, 28);
            this.lblEnterIntFirst.Name = "lblEnterIntFirst";
            this.lblEnterIntFirst.Size = new System.Drawing.Size(252, 24);
            this.lblEnterIntFirst.TabIndex = 6;
            this.lblEnterIntFirst.Text = "Enter integer or first name";
            // 
            // lblEnterIntLast
            // 
            this.lblEnterIntLast.AutoSize = true;
            this.lblEnterIntLast.Location = new System.Drawing.Point(21, 83);
            this.lblEnterIntLast.Name = "lblEnterIntLast";
            this.lblEnterIntLast.Size = new System.Drawing.Size(251, 24);
            this.lblEnterIntLast.TabIndex = 7;
            this.lblEnterIntLast.Text = "Enter integer or last name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 269);
            this.Controls.Add(this.lblEnterIntLast);
            this.Controls.Add(this.lblEnterIntFirst);
            this.Controls.Add(this.btnOverloadStr2);
            this.Controls.Add(this.btnOverloadInt2);
            this.Controls.Add(this.btnOverloadStr1);
            this.Controls.Add(this.btnOverloadInt1);
            this.Controls.Add(this.tbEnterIntLast);
            this.Controls.Add(this.tbEnterFirst);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Method Overloading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEnterFirst;
        private System.Windows.Forms.TextBox tbEnterIntLast;
        private System.Windows.Forms.Button btnOverloadInt1;
        private System.Windows.Forms.Button btnOverloadStr1;
        private System.Windows.Forms.Button btnOverloadInt2;
        private System.Windows.Forms.Button btnOverloadStr2;
        private System.Windows.Forms.Label lblEnterIntFirst;
        private System.Windows.Forms.Label lblEnterIntLast;
    }
}

