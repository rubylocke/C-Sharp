namespace _5_5_Open_Read_Write_to_a_File
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
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnOpenRead = new System.Windows.Forms.Button();
            this.btnWriteSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(41, 38);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(490, 226);
            this.tbOutput.TabIndex = 0;
            // 
            // btnOpenRead
            // 
            this.btnOpenRead.Location = new System.Drawing.Point(41, 319);
            this.btnOpenRead.Name = "btnOpenRead";
            this.btnOpenRead.Size = new System.Drawing.Size(170, 48);
            this.btnOpenRead.TabIndex = 1;
            this.btnOpenRead.Text = "Open + Read";
            this.btnOpenRead.UseVisualStyleBackColor = true;
            this.btnOpenRead.Click += new System.EventHandler(this.btnOpenRead_Click);
            // 
            // btnWriteSave
            // 
            this.btnWriteSave.Location = new System.Drawing.Point(249, 318);
            this.btnWriteSave.Name = "btnWriteSave";
            this.btnWriteSave.Size = new System.Drawing.Size(137, 49);
            this.btnWriteSave.TabIndex = 2;
            this.btnWriteSave.Text = "Write + Save";
            this.btnWriteSave.UseVisualStyleBackColor = true;
            this.btnWriteSave.Click += new System.EventHandler(this.btnWriteSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(456, 318);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 49);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 400);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnWriteSave);
            this.Controls.Add(this.btnOpenRead);
            this.Controls.Add(this.tbOutput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Open, Read, Write to a File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnOpenRead;
        private System.Windows.Forms.Button btnWriteSave;
        private System.Windows.Forms.Button btnClose;
    }
}

