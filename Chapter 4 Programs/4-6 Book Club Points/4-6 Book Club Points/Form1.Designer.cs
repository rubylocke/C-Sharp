namespace _4_6_Book_Club_Points
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
            this.lblBooksPurchaseQuestion = new System.Windows.Forms.Label();
            this.lblPointsEarn = new System.Windows.Forms.Label();
            this.lblCalculatedPoints = new System.Windows.Forms.Label();
            this.tbBooksPurchase = new System.Windows.Forms.TextBox();
            this.btnCalculatePoints = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBooksPurchaseQuestion
            // 
            this.lblBooksPurchaseQuestion.AutoSize = true;
            this.lblBooksPurchaseQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksPurchaseQuestion.Location = new System.Drawing.Point(13, 24);
            this.lblBooksPurchaseQuestion.Name = "lblBooksPurchaseQuestion";
            this.lblBooksPurchaseQuestion.Size = new System.Drawing.Size(377, 24);
            this.lblBooksPurchaseQuestion.TabIndex = 0;
            this.lblBooksPurchaseQuestion.Text = "How many books purchased this month";
            // 
            // lblPointsEarn
            // 
            this.lblPointsEarn.AutoSize = true;
            this.lblPointsEarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsEarn.Location = new System.Drawing.Point(245, 74);
            this.lblPointsEarn.Name = "lblPointsEarn";
            this.lblPointsEarn.Size = new System.Drawing.Size(141, 24);
            this.lblPointsEarn.TabIndex = 1;
            this.lblPointsEarn.Text = "Points Earned";
            // 
            // lblCalculatedPoints
            // 
            this.lblCalculatedPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCalculatedPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculatedPoints.Location = new System.Drawing.Point(444, 74);
            this.lblCalculatedPoints.Name = "lblCalculatedPoints";
            this.lblCalculatedPoints.Size = new System.Drawing.Size(100, 32);
            this.lblCalculatedPoints.TabIndex = 2;
            this.lblCalculatedPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBooksPurchase
            // 
            this.tbBooksPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBooksPurchase.Location = new System.Drawing.Point(424, 26);
            this.tbBooksPurchase.Name = "tbBooksPurchase";
            this.tbBooksPurchase.Size = new System.Drawing.Size(136, 28);
            this.tbBooksPurchase.TabIndex = 3;
            this.tbBooksPurchase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculatePoints
            // 
            this.btnCalculatePoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculatePoints.Location = new System.Drawing.Point(78, 147);
            this.btnCalculatePoints.Name = "btnCalculatePoints";
            this.btnCalculatePoints.Size = new System.Drawing.Size(131, 59);
            this.btnCalculatePoints.TabIndex = 4;
            this.btnCalculatePoints.Text = "&Calculate Points";
            this.btnCalculatePoints.UseVisualStyleBackColor = true;
            this.btnCalculatePoints.Click += new System.EventHandler(this.btnCalculatePoints_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(304, 147);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 59);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(477, 147);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 59);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 253);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculatePoints);
            this.Controls.Add(this.tbBooksPurchase);
            this.Controls.Add(this.lblCalculatedPoints);
            this.Controls.Add(this.lblPointsEarn);
            this.Controls.Add(this.lblBooksPurchaseQuestion);
            this.Name = "Form1";
            this.Text = "Serendipity Booksellers Book Club Points";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBooksPurchaseQuestion;
        private System.Windows.Forms.Label lblPointsEarn;
        private System.Windows.Forms.Label lblCalculatedPoints;
        private System.Windows.Forms.TextBox tbBooksPurchase;
        private System.Windows.Forms.Button btnCalculatePoints;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

