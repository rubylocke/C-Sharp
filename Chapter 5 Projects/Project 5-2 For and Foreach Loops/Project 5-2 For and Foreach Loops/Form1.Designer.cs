namespace Project_5_2_For_and_Foreach_Loops
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
            this.lbNumbers = new System.Windows.Forms.ListBox();
            this.lbStrings = new System.Windows.Forms.ListBox();
            this.bnForFW = new System.Windows.Forms.Button();
            this.btnForBW = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnForEachString = new System.Windows.Forms.Button();
            this.btnForEachList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNumbers
            // 
            this.lbNumbers.FormattingEnabled = true;
            this.lbNumbers.ItemHeight = 22;
            this.lbNumbers.Location = new System.Drawing.Point(30, 38);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.Size = new System.Drawing.Size(164, 202);
            this.lbNumbers.TabIndex = 0;
            // 
            // lbStrings
            // 
            this.lbStrings.FormattingEnabled = true;
            this.lbStrings.ItemHeight = 22;
            this.lbStrings.Location = new System.Drawing.Point(290, 38);
            this.lbStrings.Name = "lbStrings";
            this.lbStrings.Size = new System.Drawing.Size(159, 202);
            this.lbStrings.TabIndex = 1;
            // 
            // bnForFW
            // 
            this.bnForFW.Location = new System.Drawing.Point(30, 295);
            this.bnForFW.Name = "bnForFW";
            this.bnForFW.Size = new System.Drawing.Size(124, 45);
            this.bnForFW.TabIndex = 2;
            this.bnForFW.Text = "For FW";
            this.bnForFW.UseVisualStyleBackColor = true;
            this.bnForFW.Click += new System.EventHandler(this.bnForFW_Click);
            // 
            // btnForBW
            // 
            this.btnForBW.Location = new System.Drawing.Point(30, 367);
            this.btnForBW.Name = "btnForBW";
            this.btnForBW.Size = new System.Drawing.Size(124, 39);
            this.btnForBW.TabIndex = 3;
            this.btnForBW.Text = "For BW";
            this.btnForBW.UseVisualStyleBackColor = true;
            this.btnForBW.Click += new System.EventHandler(this.btnForBW_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(207, 295);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 45);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(207, 367);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 39);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnForEachString
            // 
            this.btnForEachString.Location = new System.Drawing.Point(333, 295);
            this.btnForEachString.Name = "btnForEachString";
            this.btnForEachString.Size = new System.Drawing.Size(187, 45);
            this.btnForEachString.TabIndex = 6;
            this.btnForEachString.Text = "For Each, string";
            this.btnForEachString.UseVisualStyleBackColor = true;
            this.btnForEachString.Click += new System.EventHandler(this.btnForEachString_Click);
            // 
            // btnForEachList
            // 
            this.btnForEachList.Location = new System.Drawing.Point(333, 367);
            this.btnForEachList.Name = "btnForEachList";
            this.btnForEachList.Size = new System.Drawing.Size(187, 39);
            this.btnForEachList.TabIndex = 7;
            this.btnForEachList.Text = "For Each, list";
            this.btnForEachList.UseVisualStyleBackColor = true;
            this.btnForEachList.Click += new System.EventHandler(this.btnForEachList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 436);
            this.Controls.Add(this.btnForEachList);
            this.Controls.Add(this.btnForEachString);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnForBW);
            this.Controls.Add(this.bnForFW);
            this.Controls.Add(this.lbStrings);
            this.Controls.Add(this.lbNumbers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "For & Foreach Loops";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbNumbers;
        private System.Windows.Forms.ListBox lbStrings;
        private System.Windows.Forms.Button bnForFW;
        private System.Windows.Forms.Button btnForBW;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnForEachString;
        private System.Windows.Forms.Button btnForEachList;
    }
}

