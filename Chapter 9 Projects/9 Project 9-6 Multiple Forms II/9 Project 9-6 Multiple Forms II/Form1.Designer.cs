namespace _9_Project_9_6_Multiple_Forms_II
{
    partial class MainForm
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
            this.lblDisplayUserName = new System.Windows.Forms.Label();
            this.lblDisplayPassword = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplayUserName
            // 
            this.lblDisplayUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplayUserName.Location = new System.Drawing.Point(49, 34);
            this.lblDisplayUserName.Name = "lblDisplayUserName";
            this.lblDisplayUserName.Size = new System.Drawing.Size(256, 41);
            this.lblDisplayUserName.TabIndex = 0;
            this.lblDisplayUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplayPassword
            // 
            this.lblDisplayPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplayPassword.Location = new System.Drawing.Point(49, 90);
            this.lblDisplayPassword.Name = "lblDisplayPassword";
            this.lblDisplayPassword.Size = new System.Drawing.Size(256, 41);
            this.lblDisplayPassword.TabIndex = 1;
            this.lblDisplayPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(74, 164);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(185, 40);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 232);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblDisplayPassword);
            this.Controls.Add(this.lblDisplayUserName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Multiple Forms II";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDisplayUserName;
        private System.Windows.Forms.Label lblDisplayPassword;
        private System.Windows.Forms.Button btnAddUser;
    }
}

