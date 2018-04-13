namespace _6_Problem_6_1_Retail_Price_Calculator
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
            this.lblWholeCost = new System.Windows.Forms.Label();
            this.lblMarkup = new System.Windows.Forms.Label();
            this.lblRetailPrice = new System.Windows.Forms.Label();
            this.lblOutputRetailPrice = new System.Windows.Forms.Label();
            this.btnCalculateRetailPrice = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbWholeSale = new System.Windows.Forms.TextBox();
            this.tbMarkUp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblWholeCost
            // 
            this.lblWholeCost.AutoSize = true;
            this.lblWholeCost.Location = new System.Drawing.Point(13, 34);
            this.lblWholeCost.Name = "lblWholeCost";
            this.lblWholeCost.Size = new System.Drawing.Size(249, 24);
            this.lblWholeCost.TabIndex = 0;
            this.lblWholeCost.Text = "Enter item wholesale cost";
            // 
            // lblMarkup
            // 
            this.lblMarkup.AutoSize = true;
            this.lblMarkup.Location = new System.Drawing.Point(17, 100);
            this.lblMarkup.Name = "lblMarkup";
            this.lblMarkup.Size = new System.Drawing.Size(192, 24);
            this.lblMarkup.TabIndex = 1;
            this.lblMarkup.Text = "Markup Percentage";
            // 
            // lblRetailPrice
            // 
            this.lblRetailPrice.AutoSize = true;
            this.lblRetailPrice.Location = new System.Drawing.Point(21, 176);
            this.lblRetailPrice.Name = "lblRetailPrice";
            this.lblRetailPrice.Size = new System.Drawing.Size(116, 24);
            this.lblRetailPrice.TabIndex = 2;
            this.lblRetailPrice.Text = "Retail Price";
            // 
            // lblOutputRetailPrice
            // 
            this.lblOutputRetailPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputRetailPrice.Location = new System.Drawing.Point(304, 176);
            this.lblOutputRetailPrice.Name = "lblOutputRetailPrice";
            this.lblOutputRetailPrice.Size = new System.Drawing.Size(98, 31);
            this.lblOutputRetailPrice.TabIndex = 3;
            this.lblOutputRetailPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculateRetailPrice
            // 
            this.btnCalculateRetailPrice.Location = new System.Drawing.Point(42, 229);
            this.btnCalculateRetailPrice.Name = "btnCalculateRetailPrice";
            this.btnCalculateRetailPrice.Size = new System.Drawing.Size(115, 107);
            this.btnCalculateRetailPrice.TabIndex = 4;
            this.btnCalculateRetailPrice.Text = "Calculate Retail Price";
            this.btnCalculateRetailPrice.UseVisualStyleBackColor = true;
            this.btnCalculateRetailPrice.Click += new System.EventHandler(this.btnCalculateRetailPrice_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(238, 253);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 58);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(371, 250);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 58);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "E&xit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbWholeSale
            // 
            this.tbWholeSale.Location = new System.Drawing.Point(304, 34);
            this.tbWholeSale.Name = "tbWholeSale";
            this.tbWholeSale.Size = new System.Drawing.Size(100, 28);
            this.tbWholeSale.TabIndex = 7;
            this.tbWholeSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMarkUp
            // 
            this.tbMarkUp.Location = new System.Drawing.Point(304, 100);
            this.tbMarkUp.Name = "tbMarkUp";
            this.tbMarkUp.Size = new System.Drawing.Size(100, 28);
            this.tbMarkUp.TabIndex = 8;
            this.tbMarkUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 348);
            this.Controls.Add(this.tbMarkUp);
            this.Controls.Add(this.tbWholeSale);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculateRetailPrice);
            this.Controls.Add(this.lblOutputRetailPrice);
            this.Controls.Add(this.lblRetailPrice);
            this.Controls.Add(this.lblMarkup);
            this.Controls.Add(this.lblWholeCost);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Retail Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWholeCost;
        private System.Windows.Forms.Label lblMarkup;
        private System.Windows.Forms.Label lblRetailPrice;
        private System.Windows.Forms.Label lblOutputRetailPrice;
        private System.Windows.Forms.Button btnCalculateRetailPrice;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbWholeSale;
        private System.Windows.Forms.TextBox tbMarkUp;
    }
}

