namespace _4_2_Mass_and_Weight
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
            this.lblEnterMass = new System.Windows.Forms.Label();
            this.lblWeightNewtons = new System.Windows.Forms.Label();
            this.tbMass = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.btnCalculateWeight = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterMass
            // 
            this.lblEnterMass.AutoSize = true;
            this.lblEnterMass.Location = new System.Drawing.Point(13, 33);
            this.lblEnterMass.Name = "lblEnterMass";
            this.lblEnterMass.Size = new System.Drawing.Size(79, 17);
            this.lblEnterMass.TabIndex = 0;
            this.lblEnterMass.Text = "Enter Mass";
            // 
            // lblWeightNewtons
            // 
            this.lblWeightNewtons.AutoSize = true;
            this.lblWeightNewtons.Location = new System.Drawing.Point(16, 85);
            this.lblWeightNewtons.Name = "lblWeightNewtons";
            this.lblWeightNewtons.Size = new System.Drawing.Size(233, 17);
            this.lblWeightNewtons.TabIndex = 1;
            this.lblWeightNewtons.Text = "The Object\'s weight (in Newtons) is:";
            // 
            // tbMass
            // 
            this.tbMass.Location = new System.Drawing.Point(313, 30);
            this.tbMass.Name = "tbMass";
            this.tbMass.Size = new System.Drawing.Size(153, 22);
            this.tbMass.TabIndex = 2;
            // 
            // lblWeight
            // 
            this.lblWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWeight.Location = new System.Drawing.Point(313, 85);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(153, 23);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculateWeight
            // 
            this.btnCalculateWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateWeight.Location = new System.Drawing.Point(72, 152);
            this.btnCalculateWeight.Name = "btnCalculateWeight";
            this.btnCalculateWeight.Size = new System.Drawing.Size(128, 77);
            this.btnCalculateWeight.TabIndex = 4;
            this.btnCalculateWeight.Text = "Calculate Weight";
            this.btnCalculateWeight.UseVisualStyleBackColor = true;
            this.btnCalculateWeight.Click += new System.EventHandler(this.btnCalculateWeight_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(245, 164);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 50);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(391, 164);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 50);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 253);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculateWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.tbMass);
            this.Controls.Add(this.lblWeightNewtons);
            this.Controls.Add(this.lblEnterMass);
            this.Name = "Form1";
            this.Text = "Mass and Weight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterMass;
        private System.Windows.Forms.Label lblWeightNewtons;
        private System.Windows.Forms.TextBox tbMass;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Button btnCalculateWeight;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

