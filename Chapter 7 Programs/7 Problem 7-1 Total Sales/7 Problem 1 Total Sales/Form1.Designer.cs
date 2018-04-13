namespace _7_Problem_1_Total_Sales
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
            this.lstSales = new System.Windows.Forms.ListBox();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCaptionTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSales
            // 
            this.lstSales.FormattingEnabled = true;
            this.lstSales.ItemHeight = 22;
            this.lstSales.Location = new System.Drawing.Point(58, 73);
            this.lstSales.Name = "lstSales";
            this.lstSales.Size = new System.Drawing.Size(207, 158);
            this.lstSales.TabIndex = 0;
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(116, 23);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(61, 24);
            this.lblSales.TabIndex = 1;
            this.lblSales.Text = "Sales";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(120, 256);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(145, 47);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptionTotal
            // 
            this.lblCaptionTotal.AutoSize = true;
            this.lblCaptionTotal.Location = new System.Drawing.Point(32, 268);
            this.lblCaptionTotal.Name = "lblCaptionTotal";
            this.lblCaptionTotal.Size = new System.Drawing.Size(62, 24);
            this.lblCaptionTotal.TabIndex = 3;
            this.lblCaptionTotal.Text = "Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 348);
            this.Controls.Add(this.lblCaptionTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.lstSales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Sales Tax";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSales;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCaptionTotal;
    }
}

