namespace _9_Project_9_2_Classes_and_Constructors
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnOverload = new System.Windows.Forms.Button();
            this.btnAccessorsMutators = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(138, 28);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(205, 28);
            this.tbName.TabIndex = 0;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(138, 83);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(205, 28);
            this.tbHeight.TabIndex = 1;
            this.tbHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(138, 144);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(205, 28);
            this.tbWeight.TabIndex = 2;
            this.tbWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(24, 198);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(222, 39);
            this.btnDefault.TabIndex = 3;
            this.btnDefault.Text = "Default Constructor";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnOverload
            // 
            this.btnOverload.Location = new System.Drawing.Point(24, 254);
            this.btnOverload.Name = "btnOverload";
            this.btnOverload.Size = new System.Drawing.Size(319, 39);
            this.btnOverload.TabIndex = 4;
            this.btnOverload.Text = "Overload Constructor";
            this.btnOverload.UseVisualStyleBackColor = true;
            this.btnOverload.Click += new System.EventHandler(this.btnOverload_Click);
            // 
            // btnAccessorsMutators
            // 
            this.btnAccessorsMutators.Location = new System.Drawing.Point(24, 312);
            this.btnAccessorsMutators.Name = "btnAccessorsMutators";
            this.btnAccessorsMutators.Size = new System.Drawing.Size(319, 39);
            this.btnAccessorsMutators.TabIndex = 5;
            this.btnAccessorsMutators.Text = "Accessors and Mutators";
            this.btnAccessorsMutators.UseVisualStyleBackColor = true;
            this.btnAccessorsMutators.Click += new System.EventHandler(this.btnAccessorsMutators_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(261, 198);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 39);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 24);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(33, 83);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(77, 24);
            this.lblHeight.TabIndex = 8;
            this.lblHeight.Text = "Height:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(34, 144);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(81, 24);
            this.lblWeight.TabIndex = 9;
            this.lblWeight.Text = "Weight:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 373);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAccessorsMutators);
            this.Controls.Add(this.btnOverload);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Classes and Constructors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnOverload;
        private System.Windows.Forms.Button btnAccessorsMutators;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
    }
}

