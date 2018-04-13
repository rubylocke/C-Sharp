namespace _8_Project_8_6_Enumeration
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
            this.lbDays = new System.Windows.Forms.ListBox();
            this.lbDaysNumbers = new System.Windows.Forms.ListBox();
            this.btnLoadMembers = new System.Windows.Forms.Button();
            this.btnLoadIndexes = new System.Windows.Forms.Button();
            this.btnAccessAnElement = new System.Windows.Forms.Button();
            this.btnLoadonMB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDays
            // 
            this.lbDays.FormattingEnabled = true;
            this.lbDays.ItemHeight = 22;
            this.lbDays.Location = new System.Drawing.Point(70, 26);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(120, 158);
            this.lbDays.TabIndex = 0;
            // 
            // lbDaysNumbers
            // 
            this.lbDaysNumbers.FormattingEnabled = true;
            this.lbDaysNumbers.ItemHeight = 22;
            this.lbDaysNumbers.Location = new System.Drawing.Point(298, 26);
            this.lbDaysNumbers.Name = "lbDaysNumbers";
            this.lbDaysNumbers.Size = new System.Drawing.Size(120, 158);
            this.lbDaysNumbers.TabIndex = 1;
            // 
            // btnLoadMembers
            // 
            this.btnLoadMembers.Location = new System.Drawing.Point(53, 208);
            this.btnLoadMembers.Name = "btnLoadMembers";
            this.btnLoadMembers.Size = new System.Drawing.Size(166, 41);
            this.btnLoadMembers.TabIndex = 2;
            this.btnLoadMembers.Text = "Load Members";
            this.btnLoadMembers.UseVisualStyleBackColor = true;
            this.btnLoadMembers.Click += new System.EventHandler(this.btnLoadMembers_Click);
            // 
            // btnLoadIndexes
            // 
            this.btnLoadIndexes.Location = new System.Drawing.Point(278, 208);
            this.btnLoadIndexes.Name = "btnLoadIndexes";
            this.btnLoadIndexes.Size = new System.Drawing.Size(175, 41);
            this.btnLoadIndexes.TabIndex = 3;
            this.btnLoadIndexes.Text = "Load Indexes";
            this.btnLoadIndexes.UseVisualStyleBackColor = true;
            this.btnLoadIndexes.Click += new System.EventHandler(this.btnLoadIndexes_Click);
            // 
            // btnAccessAnElement
            // 
            this.btnAccessAnElement.Location = new System.Drawing.Point(38, 284);
            this.btnAccessAnElement.Name = "btnAccessAnElement";
            this.btnAccessAnElement.Size = new System.Drawing.Size(207, 36);
            this.btnAccessAnElement.TabIndex = 4;
            this.btnAccessAnElement.Text = "Access An Element";
            this.btnAccessAnElement.UseVisualStyleBackColor = true;
            this.btnAccessAnElement.Click += new System.EventHandler(this.btnAccessAnElement_Click);
            // 
            // btnLoadonMB
            // 
            this.btnLoadonMB.Location = new System.Drawing.Point(278, 284);
            this.btnLoadonMB.Name = "btnLoadonMB";
            this.btnLoadonMB.Size = new System.Drawing.Size(175, 36);
            this.btnLoadonMB.TabIndex = 5;
            this.btnLoadonMB.Text = "Load on MB";
            this.btnLoadonMB.UseVisualStyleBackColor = true;
            this.btnLoadonMB.Click += new System.EventHandler(this.btnLoadonMB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 348);
            this.Controls.Add(this.btnLoadonMB);
            this.Controls.Add(this.btnAccessAnElement);
            this.Controls.Add(this.btnLoadIndexes);
            this.Controls.Add(this.btnLoadMembers);
            this.Controls.Add(this.lbDaysNumbers);
            this.Controls.Add(this.lbDays);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Enumeration";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDays;
        private System.Windows.Forms.ListBox lbDaysNumbers;
        private System.Windows.Forms.Button btnLoadMembers;
        private System.Windows.Forms.Button btnLoadIndexes;
        private System.Windows.Forms.Button btnAccessAnElement;
        private System.Windows.Forms.Button btnLoadonMB;
    }
}

