namespace _8_Project_8_5_Structures
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblEnterTitle = new System.Windows.Forms.Label();
            this.lblEnterAuthor = new System.Windows.Forms.Label();
            this.lblEnterSubject = new System.Windows.Forms.Label();
            this.lblEnterISBN = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(29, 224);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(109, 43);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblEnterTitle
            // 
            this.lblEnterTitle.AutoSize = true;
            this.lblEnterTitle.Location = new System.Drawing.Point(25, 33);
            this.lblEnterTitle.Name = "lblEnterTitle";
            this.lblEnterTitle.Size = new System.Drawing.Size(150, 24);
            this.lblEnterTitle.TabIndex = 1;
            this.lblEnterTitle.Text = "Enter book title";
            // 
            // lblEnterAuthor
            // 
            this.lblEnterAuthor.AutoSize = true;
            this.lblEnterAuthor.Location = new System.Drawing.Point(25, 79);
            this.lblEnterAuthor.Name = "lblEnterAuthor";
            this.lblEnterAuthor.Size = new System.Drawing.Size(177, 24);
            this.lblEnterAuthor.TabIndex = 2;
            this.lblEnterAuthor.Text = "Enter book author";
            // 
            // lblEnterSubject
            // 
            this.lblEnterSubject.AutoSize = true;
            this.lblEnterSubject.Location = new System.Drawing.Point(25, 124);
            this.lblEnterSubject.Name = "lblEnterSubject";
            this.lblEnterSubject.Size = new System.Drawing.Size(185, 24);
            this.lblEnterSubject.TabIndex = 3;
            this.lblEnterSubject.Text = "Enter book subject";
            // 
            // lblEnterISBN
            // 
            this.lblEnterISBN.AutoSize = true;
            this.lblEnterISBN.Location = new System.Drawing.Point(25, 165);
            this.lblEnterISBN.Name = "lblEnterISBN";
            this.lblEnterISBN.Size = new System.Drawing.Size(164, 24);
            this.lblEnterISBN.TabIndex = 4;
            this.lblEnterISBN.Text = "Enter book ISBN";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(242, 33);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(150, 28);
            this.tbTitle.TabIndex = 5;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(242, 78);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(150, 28);
            this.tbAuthor.TabIndex = 6;
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(242, 124);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(150, 28);
            this.tbSubject.TabIndex = 7;
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(242, 165);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(150, 28);
            this.tbISBN.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 295);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lblEnterISBN);
            this.Controls.Add(this.lblEnterSubject);
            this.Controls.Add(this.lblEnterAuthor);
            this.Controls.Add(this.lblEnterTitle);
            this.Controls.Add(this.btnDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Structures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblEnterTitle;
        private System.Windows.Forms.Label lblEnterAuthor;
        private System.Windows.Forms.Label lblEnterSubject;
        private System.Windows.Forms.Label lblEnterISBN;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TextBox tbISBN;
    }
}

