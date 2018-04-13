namespace _9_Problem_9_1_Pet_Class
{
    partial class PetClass
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbTypeOfDog = new System.Windows.Forms.TextBox();
            this.tbAgeofDog = new System.Windows.Forms.TextBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(205, 55);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 28);
            this.tbName.TabIndex = 0;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTypeOfDog
            // 
            this.tbTypeOfDog.Location = new System.Drawing.Point(205, 116);
            this.tbTypeOfDog.Name = "tbTypeOfDog";
            this.tbTypeOfDog.Size = new System.Drawing.Size(100, 28);
            this.tbTypeOfDog.TabIndex = 1;
            this.tbTypeOfDog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAgeofDog
            // 
            this.tbAgeofDog.Location = new System.Drawing.Point(205, 176);
            this.tbAgeofDog.Name = "tbAgeofDog";
            this.tbAgeofDog.Size = new System.Drawing.Size(100, 28);
            this.tbAgeofDog.TabIndex = 2;
            this.tbAgeofDog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(41, 252);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(99, 60);
            this.btnCapture.TabIndex = 3;
            this.btnCapture.Text = "Capture Info";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(174, 263);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 39);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(295, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 39);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(124, 24);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name of Pet";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(37, 116);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(122, 24);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Type of dog";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(37, 186);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(48, 24);
            this.lblAge.TabIndex = 8;
            this.lblAge.Text = "Age";
            // 
            // PetClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 348);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.tbAgeofDog);
            this.Controls.Add(this.tbTypeOfDog);
            this.Controls.Add(this.tbName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PetClass";
            this.Text = "Pet Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbTypeOfDog;
        private System.Windows.Forms.TextBox tbAgeofDog;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAge;
    }
}

