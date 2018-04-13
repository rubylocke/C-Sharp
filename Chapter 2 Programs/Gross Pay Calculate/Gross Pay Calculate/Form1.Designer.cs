namespace Gross_Pay_Calculate
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
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.hourlyPayRateLabel = new System.Windows.Forms.Label();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.hoursWorkedtextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayRateTextBox = new System.Windows.Forms.TextBox();
            this.grossPayCalculatedLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.AutoSize = true;
            this.hoursWorkedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursWorkedLabel.Location = new System.Drawing.Point(34, 46);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.Size = new System.Drawing.Size(172, 20);
            this.hoursWorkedLabel.TabIndex = 0;
            this.hoursWorkedLabel.Text = "Enter hours worked";
            this.hoursWorkedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hourlyPayRateLabel
            // 
            this.hourlyPayRateLabel.AutoSize = true;
            this.hourlyPayRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlyPayRateLabel.Location = new System.Drawing.Point(34, 90);
            this.hourlyPayRateLabel.Name = "hourlyPayRateLabel";
            this.hourlyPayRateLabel.Size = new System.Drawing.Size(185, 20);
            this.hourlyPayRateLabel.TabIndex = 1;
            this.hourlyPayRateLabel.Text = "Enter hourly pay rate";
            this.hourlyPayRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hourlyPayRateLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.AutoSize = true;
            this.grossPayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossPayLabel.Location = new System.Drawing.Point(34, 134);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(97, 20);
            this.grossPayLabel.TabIndex = 2;
            this.grossPayLabel.Text = "Gross Pay";
            this.grossPayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursWorkedtextBox
            // 
            this.hoursWorkedtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursWorkedtextBox.Location = new System.Drawing.Point(268, 44);
            this.hoursWorkedtextBox.Name = "hoursWorkedtextBox";
            this.hoursWorkedtextBox.Size = new System.Drawing.Size(147, 30);
            this.hoursWorkedtextBox.TabIndex = 3;
            this.hoursWorkedtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hourlyPayRateTextBox
            // 
            this.hourlyPayRateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlyPayRateTextBox.Location = new System.Drawing.Point(268, 83);
            this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            this.hourlyPayRateTextBox.Size = new System.Drawing.Size(147, 30);
            this.hourlyPayRateTextBox.TabIndex = 4;
            this.hourlyPayRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grossPayCalculatedLabel
            // 
            this.grossPayCalculatedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grossPayCalculatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossPayCalculatedLabel.Location = new System.Drawing.Point(268, 132);
            this.grossPayCalculatedLabel.Name = "grossPayCalculatedLabel";
            this.grossPayCalculatedLabel.Size = new System.Drawing.Size(147, 23);
            this.grossPayCalculatedLabel.TabIndex = 5;
            this.grossPayCalculatedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(37, 221);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(93, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(159, 221);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(268, 221);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 321);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.grossPayCalculatedLabel);
            this.Controls.Add(this.hourlyPayRateTextBox);
            this.Controls.Add(this.hoursWorkedtextBox);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.hourlyPayRateLabel);
            this.Controls.Add(this.hoursWorkedLabel);
            this.Name = "Form1";
            this.Text = "Gross Pay Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoursWorkedLabel;
        private System.Windows.Forms.Label hourlyPayRateLabel;
        private System.Windows.Forms.Label grossPayLabel;
        private System.Windows.Forms.TextBox hoursWorkedtextBox;
        private System.Windows.Forms.TextBox hourlyPayRateTextBox;
        private System.Windows.Forms.Label grossPayCalculatedLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button closeButton;
    }
}

