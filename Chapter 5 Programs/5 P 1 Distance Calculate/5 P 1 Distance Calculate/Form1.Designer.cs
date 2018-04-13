namespace _5_P_1_Distance_Calculate
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSpeedEnter = new System.Windows.Forms.Label();
            this.lblHoursEnter = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.btnClearEverything = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(53, 259);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(119, 45);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(212, 259);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 45);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "&Clear Input";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(396, 259);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 45);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSpeedEnter
            // 
            this.lblSpeedEnter.AutoSize = true;
            this.lblSpeedEnter.Location = new System.Drawing.Point(53, 32);
            this.lblSpeedEnter.Name = "lblSpeedEnter";
            this.lblSpeedEnter.Size = new System.Drawing.Size(228, 24);
            this.lblSpeedEnter.TabIndex = 3;
            this.lblSpeedEnter.Text = "Vehicle Speed in MPH:";
            // 
            // lblHoursEnter
            // 
            this.lblHoursEnter.AutoSize = true;
            this.lblHoursEnter.Location = new System.Drawing.Point(142, 84);
            this.lblHoursEnter.Name = "lblHoursEnter";
            this.lblHoursEnter.Size = new System.Drawing.Size(136, 24);
            this.lblHoursEnter.TabIndex = 4;
            this.lblHoursEnter.Text = "Hours Travel:";
            this.lblHoursEnter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblHoursEnter.Click += new System.EventHandler(this.lblHoursEnter_Click);
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(329, 32);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(100, 28);
            this.tbSpeed.TabIndex = 5;
            this.tbSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(329, 84);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(100, 28);
            this.tbHours.TabIndex = 6;
            this.tbHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbHours.TextChanged += new System.EventHandler(this.tbHours_TextChanged);
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 22;
            this.lbOutput.Location = new System.Drawing.Point(72, 135);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(357, 92);
            this.lbOutput.TabIndex = 7;
            // 
            // btnClearEverything
            // 
            this.btnClearEverything.Location = new System.Drawing.Point(182, 323);
            this.btnClearEverything.Name = "btnClearEverything";
            this.btnClearEverything.Size = new System.Drawing.Size(192, 38);
            this.btnClearEverything.TabIndex = 8;
            this.btnClearEverything.Text = "Clear Everything";
            this.btnClearEverything.UseVisualStyleBackColor = true;
            this.btnClearEverything.Click += new System.EventHandler(this.btnClearEverything_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 401);
            this.Controls.Add(this.btnClearEverything);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.tbHours);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.lblHoursEnter);
            this.Controls.Add(this.lblSpeedEnter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Distance Calculate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSpeedEnter;
        private System.Windows.Forms.Label lblHoursEnter;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Button btnClearEverything;
    }
}

