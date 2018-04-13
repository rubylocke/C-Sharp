namespace Calore_Counter
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
            this.bananaPictureBox = new System.Windows.Forms.PictureBox();
            this.orangePictureBox = new System.Windows.Forms.PictureBox();
            this.applePictureBox = new System.Windows.Forms.PictureBox();
            this.pearPictureBox = new System.Windows.Forms.PictureBox();
            this.totalCaptionLabel = new System.Windows.Forms.Label();
            this.caloriesCounter = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bananaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pearPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bananaPictureBox
            // 
            this.bananaPictureBox.Image = global::Calore_Counter.Properties.Resources.BananaCalories;
            this.bananaPictureBox.Location = new System.Drawing.Point(46, 54);
            this.bananaPictureBox.Name = "bananaPictureBox";
            this.bananaPictureBox.Size = new System.Drawing.Size(128, 155);
            this.bananaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bananaPictureBox.TabIndex = 0;
            this.bananaPictureBox.TabStop = false;
            this.bananaPictureBox.Click += new System.EventHandler(this.bananaPictureBox_Click);
            // 
            // orangePictureBox
            // 
            this.orangePictureBox.Image = global::Calore_Counter.Properties.Resources.OrangeCalories;
            this.orangePictureBox.Location = new System.Drawing.Point(46, 291);
            this.orangePictureBox.Name = "orangePictureBox";
            this.orangePictureBox.Size = new System.Drawing.Size(128, 155);
            this.orangePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.orangePictureBox.TabIndex = 1;
            this.orangePictureBox.TabStop = false;
            this.orangePictureBox.Click += new System.EventHandler(this.orangePictureBox_Click);
            // 
            // applePictureBox
            // 
            this.applePictureBox.Image = global::Calore_Counter.Properties.Resources.AppleCalories;
            this.applePictureBox.Location = new System.Drawing.Point(254, 54);
            this.applePictureBox.Name = "applePictureBox";
            this.applePictureBox.Size = new System.Drawing.Size(128, 155);
            this.applePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.applePictureBox.TabIndex = 2;
            this.applePictureBox.TabStop = false;
            this.applePictureBox.Click += new System.EventHandler(this.applePictureBox_Click);
            // 
            // pearPictureBox
            // 
            this.pearPictureBox.Image = global::Calore_Counter.Properties.Resources.PearCalories;
            this.pearPictureBox.Location = new System.Drawing.Point(254, 291);
            this.pearPictureBox.Name = "pearPictureBox";
            this.pearPictureBox.Size = new System.Drawing.Size(128, 155);
            this.pearPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pearPictureBox.TabIndex = 3;
            this.pearPictureBox.TabStop = false;
            this.pearPictureBox.Click += new System.EventHandler(this.pearPictureBox_Click);
            // 
            // totalCaptionLabel
            // 
            this.totalCaptionLabel.AutoSize = true;
            this.totalCaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCaptionLabel.Location = new System.Drawing.Point(485, 55);
            this.totalCaptionLabel.Name = "totalCaptionLabel";
            this.totalCaptionLabel.Size = new System.Drawing.Size(138, 24);
            this.totalCaptionLabel.TabIndex = 4;
            this.totalCaptionLabel.Text = "Total Calories";
            // 
            // caloriesCounter
            // 
            this.caloriesCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caloriesCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesCounter.Location = new System.Drawing.Point(489, 102);
            this.caloriesCounter.Name = "caloriesCounter";
            this.caloriesCounter.Size = new System.Drawing.Size(140, 39);
            this.caloriesCounter.TabIndex = 5;
            this.caloriesCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(503, 305);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(109, 36);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(503, 366);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(109, 36);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 491);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.caloriesCounter);
            this.Controls.Add(this.totalCaptionLabel);
            this.Controls.Add(this.pearPictureBox);
            this.Controls.Add(this.applePictureBox);
            this.Controls.Add(this.orangePictureBox);
            this.Controls.Add(this.bananaPictureBox);
            this.Name = "Form1";
            this.Text = "Calorie Counter";
            ((System.ComponentModel.ISupportInitialize)(this.bananaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pearPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bananaPictureBox;
        private System.Windows.Forms.PictureBox orangePictureBox;
        private System.Windows.Forms.PictureBox applePictureBox;
        private System.Windows.Forms.PictureBox pearPictureBox;
        private System.Windows.Forms.Label totalCaptionLabel;
        private System.Windows.Forms.Label caloriesCounter;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
    }
}

