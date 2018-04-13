namespace _6_Problem_4_Calories_from_Fat_and_Carbs
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
            this.lblEnterFatGrams = new System.Windows.Forms.Label();
            this.lblCarbGrams = new System.Windows.Forms.Label();
            this.lblCaptionArrow1 = new System.Windows.Forms.Label();
            this.lblCaptionArrow2 = new System.Windows.Forms.Label();
            this.lblCaloriesFat = new System.Windows.Forms.Label();
            this.lblCaloriesCarb = new System.Windows.Forms.Label();
            this.tbEnterFat = new System.Windows.Forms.TextBox();
            this.tbEnterCarb = new System.Windows.Forms.TextBox();
            this.lblCaptionCalories = new System.Windows.Forms.Label();
            this.btnCalcFatCalories = new System.Windows.Forms.Button();
            this.btnCalcCarbCalories = new System.Windows.Forms.Button();
            this.btnCalcBoth = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterFatGrams
            // 
            this.lblEnterFatGrams.AutoSize = true;
            this.lblEnterFatGrams.Location = new System.Drawing.Point(31, 57);
            this.lblEnterFatGrams.Name = "lblEnterFatGrams";
            this.lblEnterFatGrams.Size = new System.Drawing.Size(161, 24);
            this.lblEnterFatGrams.TabIndex = 0;
            this.lblEnterFatGrams.Text = "Enter Fat Grams";
            // 
            // lblCarbGrams
            // 
            this.lblCarbGrams.AutoSize = true;
            this.lblCarbGrams.Location = new System.Drawing.Point(31, 118);
            this.lblCarbGrams.Name = "lblCarbGrams";
            this.lblCarbGrams.Size = new System.Drawing.Size(267, 24);
            this.lblCarbGrams.TabIndex = 1;
            this.lblCarbGrams.Text = "Enter Carbohydrates Grams";
            this.lblCarbGrams.Click += new System.EventHandler(this.lblCarbGrams_Click);
            // 
            // lblCaptionArrow1
            // 
            this.lblCaptionArrow1.AutoSize = true;
            this.lblCaptionArrow1.Location = new System.Drawing.Point(452, 63);
            this.lblCaptionArrow1.Name = "lblCaptionArrow1";
            this.lblCaptionArrow1.Size = new System.Drawing.Size(46, 24);
            this.lblCaptionArrow1.TabIndex = 2;
            this.lblCaptionArrow1.Text = ">>>";
            // 
            // lblCaptionArrow2
            // 
            this.lblCaptionArrow2.AutoSize = true;
            this.lblCaptionArrow2.Location = new System.Drawing.Point(452, 126);
            this.lblCaptionArrow2.Name = "lblCaptionArrow2";
            this.lblCaptionArrow2.Size = new System.Drawing.Size(46, 24);
            this.lblCaptionArrow2.TabIndex = 3;
            this.lblCaptionArrow2.Text = ">>>";
            // 
            // lblCaloriesFat
            // 
            this.lblCaloriesFat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaloriesFat.Location = new System.Drawing.Point(518, 57);
            this.lblCaloriesFat.Name = "lblCaloriesFat";
            this.lblCaloriesFat.Size = new System.Drawing.Size(106, 35);
            this.lblCaloriesFat.TabIndex = 4;
            this.lblCaloriesFat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaloriesCarb
            // 
            this.lblCaloriesCarb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaloriesCarb.Location = new System.Drawing.Point(518, 118);
            this.lblCaloriesCarb.Name = "lblCaloriesCarb";
            this.lblCaloriesCarb.Size = new System.Drawing.Size(106, 38);
            this.lblCaloriesCarb.TabIndex = 5;
            this.lblCaloriesCarb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEnterFat
            // 
            this.tbEnterFat.Location = new System.Drawing.Point(320, 57);
            this.tbEnterFat.Name = "tbEnterFat";
            this.tbEnterFat.Size = new System.Drawing.Size(100, 28);
            this.tbEnterFat.TabIndex = 6;
            this.tbEnterFat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEnterCarb
            // 
            this.tbEnterCarb.Location = new System.Drawing.Point(320, 118);
            this.tbEnterCarb.Name = "tbEnterCarb";
            this.tbEnterCarb.Size = new System.Drawing.Size(100, 28);
            this.tbEnterCarb.TabIndex = 7;
            this.tbEnterCarb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCaptionCalories
            // 
            this.lblCaptionCalories.AutoSize = true;
            this.lblCaptionCalories.Location = new System.Drawing.Point(518, 13);
            this.lblCaptionCalories.Name = "lblCaptionCalories";
            this.lblCaptionCalories.Size = new System.Drawing.Size(86, 24);
            this.lblCaptionCalories.TabIndex = 8;
            this.lblCaptionCalories.Text = "Calories";
            // 
            // btnCalcFatCalories
            // 
            this.btnCalcFatCalories.Location = new System.Drawing.Point(87, 198);
            this.btnCalcFatCalories.Name = "btnCalcFatCalories";
            this.btnCalcFatCalories.Size = new System.Drawing.Size(131, 94);
            this.btnCalcFatCalories.TabIndex = 9;
            this.btnCalcFatCalories.Text = "Calculate Fat Calories";
            this.btnCalcFatCalories.UseVisualStyleBackColor = true;
            this.btnCalcFatCalories.Click += new System.EventHandler(this.btnCalcFatCalories_Click);
            // 
            // btnCalcCarbCalories
            // 
            this.btnCalcCarbCalories.Location = new System.Drawing.Point(308, 198);
            this.btnCalcCarbCalories.Name = "btnCalcCarbCalories";
            this.btnCalcCarbCalories.Size = new System.Drawing.Size(126, 94);
            this.btnCalcCarbCalories.TabIndex = 10;
            this.btnCalcCarbCalories.Text = "Calculate Carb Calories";
            this.btnCalcCarbCalories.UseVisualStyleBackColor = true;
            this.btnCalcCarbCalories.Click += new System.EventHandler(this.btnCalcCarbCalories_Click);
            // 
            // btnCalcBoth
            // 
            this.btnCalcBoth.Location = new System.Drawing.Point(518, 198);
            this.btnCalcBoth.Name = "btnCalcBoth";
            this.btnCalcBoth.Size = new System.Drawing.Size(106, 94);
            this.btnCalcBoth.TabIndex = 11;
            this.btnCalcBoth.Text = "Calculate Both";
            this.btnCalcBoth.UseVisualStyleBackColor = true;
            this.btnCalcBoth.Click += new System.EventHandler(this.btnCalcBoth_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(459, 337);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 44);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(567, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 44);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 404);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalcBoth);
            this.Controls.Add(this.btnCalcCarbCalories);
            this.Controls.Add(this.btnCalcFatCalories);
            this.Controls.Add(this.lblCaptionCalories);
            this.Controls.Add(this.tbEnterCarb);
            this.Controls.Add(this.tbEnterFat);
            this.Controls.Add(this.lblCaloriesCarb);
            this.Controls.Add(this.lblCaloriesFat);
            this.Controls.Add(this.lblCaptionArrow2);
            this.Controls.Add(this.lblCaptionArrow1);
            this.Controls.Add(this.lblCarbGrams);
            this.Controls.Add(this.lblEnterFatGrams);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calories from Fat and Carbohydrates";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterFatGrams;
        private System.Windows.Forms.Label lblCarbGrams;
        private System.Windows.Forms.Label lblCaptionArrow1;
        private System.Windows.Forms.Label lblCaptionArrow2;
        private System.Windows.Forms.Label lblCaloriesFat;
        private System.Windows.Forms.Label lblCaloriesCarb;
        private System.Windows.Forms.TextBox tbEnterFat;
        private System.Windows.Forms.TextBox tbEnterCarb;
        private System.Windows.Forms.Label lblCaptionCalories;
        private System.Windows.Forms.Button btnCalcFatCalories;
        private System.Windows.Forms.Button btnCalcCarbCalories;
        private System.Windows.Forms.Button btnCalcBoth;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

