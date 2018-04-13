namespace _9_Project_9_1_Classes_I
{
    partial class frmClassesI
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
            this.btnClassDefault = new System.Windows.Forms.Button();
            this.btnDefaultParaConstructor = new System.Windows.Forms.Button();
            this.btnOverloadConst = new System.Windows.Forms.Button();
            this.btnDefaultConstEmpl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClassDefault
            // 
            this.btnClassDefault.Location = new System.Drawing.Point(46, 28);
            this.btnClassDefault.Name = "btnClassDefault";
            this.btnClassDefault.Size = new System.Drawing.Size(420, 37);
            this.btnClassDefault.TabIndex = 0;
            this.btnClassDefault.Text = "Customer Class Default Constructor";
            this.btnClassDefault.UseVisualStyleBackColor = true;
            this.btnClassDefault.Click += new System.EventHandler(this.btnClassDefault_Click);
            // 
            // btnDefaultParaConstructor
            // 
            this.btnDefaultParaConstructor.Location = new System.Drawing.Point(46, 91);
            this.btnDefaultParaConstructor.Name = "btnDefaultParaConstructor";
            this.btnDefaultParaConstructor.Size = new System.Drawing.Size(420, 37);
            this.btnDefaultParaConstructor.TabIndex = 1;
            this.btnDefaultParaConstructor.Text = "Default+Parameterized Constructors";
            this.btnDefaultParaConstructor.UseVisualStyleBackColor = true;
            this.btnDefaultParaConstructor.Click += new System.EventHandler(this.btnDefaultParaConstructor_Click);
            // 
            // btnOverloadConst
            // 
            this.btnOverloadConst.Location = new System.Drawing.Point(46, 154);
            this.btnOverloadConst.Name = "btnOverloadConst";
            this.btnOverloadConst.Size = new System.Drawing.Size(420, 37);
            this.btnOverloadConst.TabIndex = 2;
            this.btnOverloadConst.Text = "Overloading Constructors";
            this.btnOverloadConst.UseVisualStyleBackColor = true;
            this.btnOverloadConst.Click += new System.EventHandler(this.btnOverloadConst_Click);
            // 
            // btnDefaultConstEmpl
            // 
            this.btnDefaultConstEmpl.Location = new System.Drawing.Point(46, 217);
            this.btnDefaultConstEmpl.Name = "btnDefaultConstEmpl";
            this.btnDefaultConstEmpl.Size = new System.Drawing.Size(420, 37);
            this.btnDefaultConstEmpl.TabIndex = 3;
            this.btnDefaultConstEmpl.Text = "Employee Class Default Constructor";
            this.btnDefaultConstEmpl.UseVisualStyleBackColor = true;
            this.btnDefaultConstEmpl.Click += new System.EventHandler(this.btnDefaultConstEmpl_Click);
            // 
            // frmClassesI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 282);
            this.Controls.Add(this.btnDefaultConstEmpl);
            this.Controls.Add(this.btnOverloadConst);
            this.Controls.Add(this.btnDefaultParaConstructor);
            this.Controls.Add(this.btnClassDefault);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmClassesI";
            this.Text = "Classes I";
            this.Load += new System.EventHandler(this.frmClassesI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClassDefault;
        private System.Windows.Forms.Button btnDefaultParaConstructor;
        private System.Windows.Forms.Button btnOverloadConst;
        private System.Windows.Forms.Button btnDefaultConstEmpl;
    }
}

