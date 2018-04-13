namespace _9_Problem_9_6_Dorm_and_Meal_Plan_Calculator
{
    partial class MainForm
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
            this.grpDorm = new System.Windows.Forms.GroupBox();
            this.grpMeals = new System.Windows.Forms.GroupBox();
            this.btnChoices = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbAllen = new System.Windows.Forms.CheckBox();
            this.cbPike = new System.Windows.Forms.CheckBox();
            this.cbFarthing = new System.Windows.Forms.CheckBox();
            this.cb7Meals = new System.Windows.Forms.CheckBox();
            this.cb14Meals = new System.Windows.Forms.CheckBox();
            this.cbUnlimitedMeals = new System.Windows.Forms.CheckBox();
            this.cbUniversitySuites = new System.Windows.Forms.CheckBox();
            this.grpDorm.SuspendLayout();
            this.grpMeals.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDorm
            // 
            this.grpDorm.Controls.Add(this.cbUniversitySuites);
            this.grpDorm.Controls.Add(this.cbFarthing);
            this.grpDorm.Controls.Add(this.cbPike);
            this.grpDorm.Controls.Add(this.cbAllen);
            this.grpDorm.Location = new System.Drawing.Point(31, 42);
            this.grpDorm.Name = "grpDorm";
            this.grpDorm.Size = new System.Drawing.Size(308, 233);
            this.grpDorm.TabIndex = 0;
            this.grpDorm.TabStop = false;
            this.grpDorm.Text = "Dormitories";
            // 
            // grpMeals
            // 
            this.grpMeals.Controls.Add(this.cbUnlimitedMeals);
            this.grpMeals.Controls.Add(this.cb14Meals);
            this.grpMeals.Controls.Add(this.cb7Meals);
            this.grpMeals.Location = new System.Drawing.Point(378, 42);
            this.grpMeals.Name = "grpMeals";
            this.grpMeals.Size = new System.Drawing.Size(331, 188);
            this.grpMeals.TabIndex = 1;
            this.grpMeals.TabStop = false;
            this.grpMeals.Text = "Meal Plans";
            // 
            // btnChoices
            // 
            this.btnChoices.Location = new System.Drawing.Point(112, 309);
            this.btnChoices.Name = "btnChoices";
            this.btnChoices.Size = new System.Drawing.Size(109, 46);
            this.btnChoices.TabIndex = 2;
            this.btnChoices.Text = "Choices";
            this.btnChoices.UseVisualStyleBackColor = true;
            this.btnChoices.Click += new System.EventHandler(this.btnChoices_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(323, 308);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(96, 46);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "&Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(495, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 46);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbAllen
            // 
            this.cbAllen.AutoSize = true;
            this.cbAllen.Location = new System.Drawing.Point(25, 46);
            this.cbAllen.Name = "cbAllen";
            this.cbAllen.Size = new System.Drawing.Size(261, 28);
            this.cbAllen.TabIndex = 0;
            this.cbAllen.Text = "Allen Hall             $1,500";
            this.cbAllen.UseVisualStyleBackColor = true;
            // 
            // cbPike
            // 
            this.cbPike.AutoSize = true;
            this.cbPike.Location = new System.Drawing.Point(25, 93);
            this.cbPike.Name = "cbPike";
            this.cbPike.Size = new System.Drawing.Size(259, 28);
            this.cbPike.TabIndex = 1;
            this.cbPike.Text = "Pike Hall              $1,600";
            this.cbPike.UseVisualStyleBackColor = true;
            // 
            // cbFarthing
            // 
            this.cbFarthing.AutoSize = true;
            this.cbFarthing.Location = new System.Drawing.Point(25, 144);
            this.cbFarthing.Name = "cbFarthing";
            this.cbFarthing.Size = new System.Drawing.Size(260, 28);
            this.cbFarthing.TabIndex = 2;
            this.cbFarthing.Text = "Farthing Hall        $1,800";
            this.cbFarthing.UseVisualStyleBackColor = true;
            // 
            // cb7Meals
            // 
            this.cb7Meals.AutoSize = true;
            this.cb7Meals.Location = new System.Drawing.Point(23, 46);
            this.cb7Meals.Name = "cb7Meals";
            this.cb7Meals.Size = new System.Drawing.Size(276, 28);
            this.cb7Meals.TabIndex = 0;
            this.cb7Meals.Text = "7 meals per week      $600";
            this.cb7Meals.UseVisualStyleBackColor = true;
            // 
            // cb14Meals
            // 
            this.cb14Meals.AutoSize = true;
            this.cb14Meals.Location = new System.Drawing.Point(23, 93);
            this.cb14Meals.Name = "cb14Meals";
            this.cb14Meals.Size = new System.Drawing.Size(280, 28);
            this.cb14Meals.TabIndex = 1;
            this.cb14Meals.Text = "14 meals per week  $1,200";
            this.cb14Meals.UseVisualStyleBackColor = true;
            // 
            // cbUnlimitedMeals
            // 
            this.cbUnlimitedMeals.AutoSize = true;
            this.cbUnlimitedMeals.Location = new System.Drawing.Point(23, 144);
            this.cbUnlimitedMeals.Name = "cbUnlimitedMeals";
            this.cbUnlimitedMeals.Size = new System.Drawing.Size(283, 28);
            this.cbUnlimitedMeals.TabIndex = 2;
            this.cbUnlimitedMeals.Text = "Unlimited meals       $1,700";
            this.cbUnlimitedMeals.UseVisualStyleBackColor = true;
            // 
            // cbUniversitySuites
            // 
            this.cbUniversitySuites.AutoSize = true;
            this.cbUniversitySuites.Location = new System.Drawing.Point(25, 192);
            this.cbUniversitySuites.Name = "cbUniversitySuites";
            this.cbUniversitySuites.Size = new System.Drawing.Size(258, 28);
            this.cbUniversitySuites.TabIndex = 3;
            this.cbUniversitySuites.Text = "University Suites  $2,500";
            this.cbUniversitySuites.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 407);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.btnChoices);
            this.Controls.Add(this.grpMeals);
            this.Controls.Add(this.grpDorm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Dorm and Meal Plan Calculator";
            this.grpDorm.ResumeLayout(false);
            this.grpDorm.PerformLayout();
            this.grpMeals.ResumeLayout(false);
            this.grpMeals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDorm;
        private System.Windows.Forms.CheckBox cbUniversitySuites;
        private System.Windows.Forms.CheckBox cbFarthing;
        private System.Windows.Forms.CheckBox cbPike;
        private System.Windows.Forms.CheckBox cbAllen;
        private System.Windows.Forms.GroupBox grpMeals;
        private System.Windows.Forms.CheckBox cbUnlimitedMeals;
        private System.Windows.Forms.CheckBox cb14Meals;
        private System.Windows.Forms.CheckBox cb7Meals;
        private System.Windows.Forms.Button btnChoices;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

