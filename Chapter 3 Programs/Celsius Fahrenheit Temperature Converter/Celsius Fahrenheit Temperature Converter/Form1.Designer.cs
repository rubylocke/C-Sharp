namespace Celsius_Fahrenheit_Temperature_Converter
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
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.calculateFahrenheitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.calculateCelsiusFahrenheitButton = new System.Windows.Forms.Button();
            this.conversionLabel = new System.Windows.Forms.Label();
            this.enterTemperatureTextBox = new System.Windows.Forms.TextBox();
            this.conversionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureLabel.Location = new System.Drawing.Point(30, 31);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(186, 24);
            this.temperatureLabel.TabIndex = 0;
            this.temperatureLabel.Text = "Enter Temperature";
            // 
            // calculateFahrenheitButton
            // 
            this.calculateFahrenheitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateFahrenheitButton.Location = new System.Drawing.Point(34, 199);
            this.calculateFahrenheitButton.Name = "calculateFahrenheitButton";
            this.calculateFahrenheitButton.Size = new System.Drawing.Size(140, 73);
            this.calculateFahrenheitButton.TabIndex = 1;
            this.calculateFahrenheitButton.Text = "Convert to Fahrenheit";
            this.calculateFahrenheitButton.UseVisualStyleBackColor = true;
            this.calculateFahrenheitButton.Click += new System.EventHandler(this.calculateConversionButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(360, 199);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(140, 73);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(519, 199);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(140, 73);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // calculateCelsiusFahrenheitButton
            // 
            this.calculateCelsiusFahrenheitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateCelsiusFahrenheitButton.Location = new System.Drawing.Point(197, 199);
            this.calculateCelsiusFahrenheitButton.Name = "calculateCelsiusFahrenheitButton";
            this.calculateCelsiusFahrenheitButton.Size = new System.Drawing.Size(140, 73);
            this.calculateCelsiusFahrenheitButton.TabIndex = 4;
            this.calculateCelsiusFahrenheitButton.Text = "Convert to Celsius";
            this.calculateCelsiusFahrenheitButton.UseVisualStyleBackColor = true;
            this.calculateCelsiusFahrenheitButton.Click += new System.EventHandler(this.calculateCelsiusFahrenheitButton_Click);
            // 
            // conversionLabel
            // 
            this.conversionLabel.AutoSize = true;
            this.conversionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionLabel.Location = new System.Drawing.Point(100, 110);
            this.conversionLabel.Name = "conversionLabel";
            this.conversionLabel.Size = new System.Drawing.Size(116, 24);
            this.conversionLabel.TabIndex = 5;
            this.conversionLabel.Text = "Conversion";
            // 
            // enterTemperatureTextBox
            // 
            this.enterTemperatureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterTemperatureTextBox.Location = new System.Drawing.Point(287, 32);
            this.enterTemperatureTextBox.Name = "enterTemperatureTextBox";
            this.enterTemperatureTextBox.Size = new System.Drawing.Size(145, 28);
            this.enterTemperatureTextBox.TabIndex = 6;
            this.enterTemperatureTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // conversionTextBox
            // 
            this.conversionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionTextBox.Location = new System.Drawing.Point(287, 110);
            this.conversionTextBox.Name = "conversionTextBox";
            this.conversionTextBox.Size = new System.Drawing.Size(145, 28);
            this.conversionTextBox.TabIndex = 7;
            this.conversionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 304);
            this.Controls.Add(this.conversionTextBox);
            this.Controls.Add(this.enterTemperatureTextBox);
            this.Controls.Add(this.conversionLabel);
            this.Controls.Add(this.calculateCelsiusFahrenheitButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateFahrenheitButton);
            this.Controls.Add(this.temperatureLabel);
            this.Name = "Form1";
            this.Text = "Celsius and Fahrenheit Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Button calculateFahrenheitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button calculateCelsiusFahrenheitButton;
        private System.Windows.Forms.Label conversionLabel;
        private System.Windows.Forms.TextBox enterTemperatureTextBox;
        private System.Windows.Forms.TextBox conversionTextBox;
    }
}

