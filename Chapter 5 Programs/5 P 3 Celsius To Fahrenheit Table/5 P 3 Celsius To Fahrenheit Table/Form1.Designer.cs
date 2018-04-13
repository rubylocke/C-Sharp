namespace _5_P_3_Celsius_To_Fahrenheit_Table
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
            this.lbCeltoFah = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbCeltoFah
            // 
            this.lbCeltoFah.FormattingEnabled = true;
            this.lbCeltoFah.ItemHeight = 22;
            this.lbCeltoFah.Location = new System.Drawing.Point(31, 30);
            this.lbCeltoFah.Name = "lbCeltoFah";
            this.lbCeltoFah.Size = new System.Drawing.Size(325, 356);
            this.lbCeltoFah.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 407);
            this.Controls.Add(this.lbCeltoFah);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Celsius to Fahrenheit Table";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbCeltoFah;
    }
}

