namespace _5_P_7_Calories_Burned
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
            this.lbnHowManyCalories = new System.Windows.Forms.Label();
            this.lbCaloriesBurned = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbnHowManyCalories
            // 
            this.lbnHowManyCalories.AutoSize = true;
            this.lbnHowManyCalories.Location = new System.Drawing.Point(40, 40);
            this.lbnHowManyCalories.Name = "lbnHowManyCalories";
            this.lbnHowManyCalories.Size = new System.Drawing.Size(315, 24);
            this.lbnHowManyCalories.TabIndex = 0;
            this.lbnHowManyCalories.Text = "Now Many Calories Do You Burn";
            // 
            // lbCaloriesBurned
            // 
            this.lbCaloriesBurned.FormattingEnabled = true;
            this.lbCaloriesBurned.ItemHeight = 22;
            this.lbCaloriesBurned.Location = new System.Drawing.Point(100, 78);
            this.lbCaloriesBurned.Name = "lbCaloriesBurned";
            this.lbCaloriesBurned.Size = new System.Drawing.Size(188, 268);
            this.lbCaloriesBurned.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 415);
            this.Controls.Add(this.lbCaloriesBurned);
            this.Controls.Add(this.lbnHowManyCalories);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calories Burned";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnHowManyCalories;
        private System.Windows.Forms.ListBox lbCaloriesBurned;
    }
}

