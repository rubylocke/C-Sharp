namespace Project_4_4_GroupBox_Radio_button_Check
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
            this.gbDrinkSelection = new System.Windows.Forms.GroupBox();
            this.gbPaymentSelection = new System.Windows.Forms.GroupBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbCoffee = new System.Windows.Forms.CheckBox();
            this.cbTea = new System.Windows.Forms.CheckBox();
            this.cbCappuccino = new System.Windows.Forms.CheckBox();
            this.rbCredit = new System.Windows.Forms.RadioButton();
            this.rbDebit = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.gbDrinkSelection.SuspendLayout();
            this.gbPaymentSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDrinkSelection
            // 
            this.gbDrinkSelection.Controls.Add(this.cbCappuccino);
            this.gbDrinkSelection.Controls.Add(this.cbTea);
            this.gbDrinkSelection.Controls.Add(this.cbCoffee);
            this.gbDrinkSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDrinkSelection.Location = new System.Drawing.Point(31, 34);
            this.gbDrinkSelection.Name = "gbDrinkSelection";
            this.gbDrinkSelection.Size = new System.Drawing.Size(200, 161);
            this.gbDrinkSelection.TabIndex = 0;
            this.gbDrinkSelection.TabStop = false;
            this.gbDrinkSelection.Text = "Drink Selection";
            // 
            // gbPaymentSelection
            // 
            this.gbPaymentSelection.Controls.Add(this.rbCash);
            this.gbPaymentSelection.Controls.Add(this.rbDebit);
            this.gbPaymentSelection.Controls.Add(this.rbCredit);
            this.gbPaymentSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPaymentSelection.Location = new System.Drawing.Point(291, 34);
            this.gbPaymentSelection.Name = "gbPaymentSelection";
            this.gbPaymentSelection.Size = new System.Drawing.Size(247, 161);
            this.gbPaymentSelection.TabIndex = 1;
            this.gbPaymentSelection.TabStop = false;
            this.gbPaymentSelection.Text = "Payment Selection";
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(31, 253);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(101, 57);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "&Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAll.Location = new System.Drawing.Point(184, 252);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(94, 57);
            this.btnSelectAll.TabIndex = 3;
            this.btnSelectAll.Text = "&Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(313, 252);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(100, 57);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "&Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(448, 252);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 57);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbCoffee
            // 
            this.cbCoffee.AutoSize = true;
            this.cbCoffee.Location = new System.Drawing.Point(7, 36);
            this.cbCoffee.Name = "cbCoffee";
            this.cbCoffee.Size = new System.Drawing.Size(92, 28);
            this.cbCoffee.TabIndex = 0;
            this.cbCoffee.Text = "Coffee";
            this.cbCoffee.UseVisualStyleBackColor = true;
            // 
            // cbTea
            // 
            this.cbTea.AutoSize = true;
            this.cbTea.Location = new System.Drawing.Point(7, 78);
            this.cbTea.Name = "cbTea";
            this.cbTea.Size = new System.Drawing.Size(68, 28);
            this.cbTea.TabIndex = 1;
            this.cbTea.Text = "Tea";
            this.cbTea.UseVisualStyleBackColor = true;
            // 
            // cbCappuccino
            // 
            this.cbCappuccino.AutoSize = true;
            this.cbCappuccino.Location = new System.Drawing.Point(7, 125);
            this.cbCappuccino.Name = "cbCappuccino";
            this.cbCappuccino.Size = new System.Drawing.Size(144, 28);
            this.cbCappuccino.TabIndex = 2;
            this.cbCappuccino.Text = "Cappuccino";
            this.cbCappuccino.UseVisualStyleBackColor = true;
            // 
            // rbCredit
            // 
            this.rbCredit.AutoSize = true;
            this.rbCredit.Location = new System.Drawing.Point(16, 36);
            this.rbCredit.Name = "rbCredit";
            this.rbCredit.Size = new System.Drawing.Size(86, 28);
            this.rbCredit.TabIndex = 0;
            this.rbCredit.TabStop = true;
            this.rbCredit.Text = "Credit";
            this.rbCredit.UseVisualStyleBackColor = true;
            // 
            // rbDebit
            // 
            this.rbDebit.AutoSize = true;
            this.rbDebit.Location = new System.Drawing.Point(16, 78);
            this.rbDebit.Name = "rbDebit";
            this.rbDebit.Size = new System.Drawing.Size(79, 28);
            this.rbDebit.TabIndex = 1;
            this.rbDebit.TabStop = true;
            this.rbDebit.Text = "Debit";
            this.rbDebit.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(16, 125);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(78, 28);
            this.rbCash.TabIndex = 2;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 336);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gbPaymentSelection);
            this.Controls.Add(this.gbDrinkSelection);
            this.Name = "Form1";
            this.Text = "Drink and Payment Selection";
            this.gbDrinkSelection.ResumeLayout(false);
            this.gbDrinkSelection.PerformLayout();
            this.gbPaymentSelection.ResumeLayout(false);
            this.gbPaymentSelection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDrinkSelection;
        private System.Windows.Forms.CheckBox cbCappuccino;
        private System.Windows.Forms.CheckBox cbTea;
        private System.Windows.Forms.CheckBox cbCoffee;
        private System.Windows.Forms.GroupBox gbPaymentSelection;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbDebit;
        private System.Windows.Forms.RadioButton rbCredit;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnExit;
    }
}

