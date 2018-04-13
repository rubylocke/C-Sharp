namespace _4_6_Color_Mixer
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
            this.btnMix = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbFirstColor = new System.Windows.Forms.GroupBox();
            this.rbFirstYellow = new System.Windows.Forms.RadioButton();
            this.rbFirstBlue = new System.Windows.Forms.RadioButton();
            this.rbFirstRed = new System.Windows.Forms.RadioButton();
            this.gbSecondColor = new System.Windows.Forms.GroupBox();
            this.rbSecondYellow = new System.Windows.Forms.RadioButton();
            this.rbSecondBlue = new System.Windows.Forms.RadioButton();
            this.rbSecondRed = new System.Windows.Forms.RadioButton();
            this.gbFirstColor.SuspendLayout();
            this.gbSecondColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMix
            // 
            this.btnMix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMix.Location = new System.Drawing.Point(86, 248);
            this.btnMix.Name = "btnMix";
            this.btnMix.Size = new System.Drawing.Size(95, 48);
            this.btnMix.TabIndex = 0;
            this.btnMix.Text = "Mix";
            this.btnMix.UseVisualStyleBackColor = true;
            this.btnMix.Click += new System.EventHandler(this.btnMix_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(324, 248);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 48);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbFirstColor
            // 
            this.gbFirstColor.Controls.Add(this.rbFirstYellow);
            this.gbFirstColor.Controls.Add(this.rbFirstBlue);
            this.gbFirstColor.Controls.Add(this.rbFirstRed);
            this.gbFirstColor.Location = new System.Drawing.Point(39, 51);
            this.gbFirstColor.Name = "gbFirstColor";
            this.gbFirstColor.Size = new System.Drawing.Size(200, 157);
            this.gbFirstColor.TabIndex = 2;
            this.gbFirstColor.TabStop = false;
            this.gbFirstColor.Text = "Select The First Color";
            // 
            // rbFirstYellow
            // 
            this.rbFirstYellow.AutoSize = true;
            this.rbFirstYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFirstYellow.Location = new System.Drawing.Point(22, 120);
            this.rbFirstYellow.Name = "rbFirstYellow";
            this.rbFirstYellow.Size = new System.Drawing.Size(84, 24);
            this.rbFirstYellow.TabIndex = 2;
            this.rbFirstYellow.TabStop = true;
            this.rbFirstYellow.Text = "Yellow";
            this.rbFirstYellow.UseVisualStyleBackColor = true;
            // 
            // rbFirstBlue
            // 
            this.rbFirstBlue.AutoSize = true;
            this.rbFirstBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFirstBlue.Location = new System.Drawing.Point(22, 79);
            this.rbFirstBlue.Name = "rbFirstBlue";
            this.rbFirstBlue.Size = new System.Drawing.Size(68, 24);
            this.rbFirstBlue.TabIndex = 1;
            this.rbFirstBlue.TabStop = true;
            this.rbFirstBlue.Text = "Blue";
            this.rbFirstBlue.UseVisualStyleBackColor = true;
            // 
            // rbFirstRed
            // 
            this.rbFirstRed.AutoSize = true;
            this.rbFirstRed.Checked = true;
            this.rbFirstRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFirstRed.Location = new System.Drawing.Point(22, 35);
            this.rbFirstRed.Name = "rbFirstRed";
            this.rbFirstRed.Size = new System.Drawing.Size(63, 24);
            this.rbFirstRed.TabIndex = 0;
            this.rbFirstRed.TabStop = true;
            this.rbFirstRed.Text = "Red";
            this.rbFirstRed.UseVisualStyleBackColor = true;
            // 
            // gbSecondColor
            // 
            this.gbSecondColor.Controls.Add(this.rbSecondYellow);
            this.gbSecondColor.Controls.Add(this.rbSecondBlue);
            this.gbSecondColor.Controls.Add(this.rbSecondRed);
            this.gbSecondColor.Location = new System.Drawing.Point(295, 51);
            this.gbSecondColor.Name = "gbSecondColor";
            this.gbSecondColor.Size = new System.Drawing.Size(200, 157);
            this.gbSecondColor.TabIndex = 3;
            this.gbSecondColor.TabStop = false;
            this.gbSecondColor.Text = "Select the Second Color";
            // 
            // rbSecondYellow
            // 
            this.rbSecondYellow.AutoSize = true;
            this.rbSecondYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSecondYellow.Location = new System.Drawing.Point(20, 119);
            this.rbSecondYellow.Name = "rbSecondYellow";
            this.rbSecondYellow.Size = new System.Drawing.Size(84, 24);
            this.rbSecondYellow.TabIndex = 2;
            this.rbSecondYellow.TabStop = true;
            this.rbSecondYellow.Text = "Yellow";
            this.rbSecondYellow.UseVisualStyleBackColor = true;
            // 
            // rbSecondBlue
            // 
            this.rbSecondBlue.AutoSize = true;
            this.rbSecondBlue.Checked = true;
            this.rbSecondBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSecondBlue.Location = new System.Drawing.Point(20, 78);
            this.rbSecondBlue.Name = "rbSecondBlue";
            this.rbSecondBlue.Size = new System.Drawing.Size(68, 24);
            this.rbSecondBlue.TabIndex = 1;
            this.rbSecondBlue.TabStop = true;
            this.rbSecondBlue.Text = "Blue";
            this.rbSecondBlue.UseVisualStyleBackColor = true;
            // 
            // rbSecondRed
            // 
            this.rbSecondRed.AutoSize = true;
            this.rbSecondRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSecondRed.Location = new System.Drawing.Point(20, 35);
            this.rbSecondRed.Name = "rbSecondRed";
            this.rbSecondRed.Size = new System.Drawing.Size(63, 24);
            this.rbSecondRed.TabIndex = 0;
            this.rbSecondRed.TabStop = true;
            this.rbSecondRed.Text = "Red";
            this.rbSecondRed.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 324);
            this.Controls.Add(this.gbSecondColor);
            this.Controls.Add(this.gbFirstColor);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMix);
            this.Name = "Form1";
            this.Text = "Color Mixer";
            this.gbFirstColor.ResumeLayout(false);
            this.gbFirstColor.PerformLayout();
            this.gbSecondColor.ResumeLayout(false);
            this.gbSecondColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMix;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbFirstColor;
        private System.Windows.Forms.RadioButton rbFirstYellow;
        private System.Windows.Forms.RadioButton rbFirstBlue;
        private System.Windows.Forms.RadioButton rbFirstRed;
        private System.Windows.Forms.GroupBox gbSecondColor;
        private System.Windows.Forms.RadioButton rbSecondYellow;
        private System.Windows.Forms.RadioButton rbSecondBlue;
        private System.Windows.Forms.RadioButton rbSecondRed;
    }
}

