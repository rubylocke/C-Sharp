namespace _11_Problem_11_4_Use_SQL_for_Retrieval
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
            this.components = new System.ComponentModel.Container();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSortByDept = new System.Windows.Forms.Button();
            this.btnSalGR40000 = new System.Windows.Forms.Button();
            this.btnAvgSal = new System.Windows.Forms.Button();
            this.btnMinSalary = new System.Windows.Forms.Button();
            this.btnMaxSal = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSet = new _11_Problem_11_4_Use_SQL_for_Retrieval.EmployeeDataSet();
            this.employeeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new _11_Problem_11_4_Use_SQL_for_Retrieval.EmployeeDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new _11_Problem_11_4_Use_SQL_for_Retrieval.EmployeeDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.employeeDataGridView.DataSource = this.employeeBindingSource;
            this.employeeDataGridView.Location = new System.Drawing.Point(12, 24);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.RowTemplate.Height = 24;
            this.employeeDataGridView.Size = new System.Drawing.Size(711, 220);
            this.employeeDataGridView.TabIndex = 1;
            // 
            // btnSortByDept
            // 
            this.btnSortByDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortByDept.Location = new System.Drawing.Point(12, 283);
            this.btnSortByDept.Name = "btnSortByDept";
            this.btnSortByDept.Size = new System.Drawing.Size(148, 70);
            this.btnSortByDept.TabIndex = 2;
            this.btnSortByDept.Text = "Sort By Department";
            this.btnSortByDept.UseVisualStyleBackColor = true;
            this.btnSortByDept.Click += new System.EventHandler(this.btnSortByDept_Click);
            // 
            // btnSalGR40000
            // 
            this.btnSalGR40000.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalGR40000.Location = new System.Drawing.Point(166, 283);
            this.btnSalGR40000.Name = "btnSalGR40000";
            this.btnSalGR40000.Size = new System.Drawing.Size(168, 70);
            this.btnSalGR40000.TabIndex = 3;
            this.btnSalGR40000.Text = "Salaries greater than 40 K";
            this.btnSalGR40000.UseVisualStyleBackColor = true;
            this.btnSalGR40000.Click += new System.EventHandler(this.btnSalGR40000_Click);
            // 
            // btnAvgSal
            // 
            this.btnAvgSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvgSal.Location = new System.Drawing.Point(340, 283);
            this.btnAvgSal.Name = "btnAvgSal";
            this.btnAvgSal.Size = new System.Drawing.Size(120, 70);
            this.btnAvgSal.TabIndex = 4;
            this.btnAvgSal.Text = "Average Salary";
            this.btnAvgSal.UseVisualStyleBackColor = true;
            this.btnAvgSal.Click += new System.EventHandler(this.btnAvgSal_Click);
            // 
            // btnMinSalary
            // 
            this.btnMinSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinSalary.Location = new System.Drawing.Point(466, 283);
            this.btnMinSalary.Name = "btnMinSalary";
            this.btnMinSalary.Size = new System.Drawing.Size(120, 70);
            this.btnMinSalary.TabIndex = 5;
            this.btnMinSalary.Text = "Minimum Salary";
            this.btnMinSalary.UseVisualStyleBackColor = true;
            this.btnMinSalary.Click += new System.EventHandler(this.btnMinSalary_Click);
            // 
            // btnMaxSal
            // 
            this.btnMaxSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxSal.Location = new System.Drawing.Point(593, 283);
            this.btnMaxSal.Name = "btnMaxSal";
            this.btnMaxSal.Size = new System.Drawing.Size(120, 70);
            this.btnMaxSal.TabIndex = 6;
            this.btnMaxSal.Text = "Maximum Salary";
            this.btnMaxSal.UseVisualStyleBackColor = true;
            this.btnMaxSal.Click += new System.EventHandler(this.btnMaxSal_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmpID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EmpID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Department";
            this.dataGridViewTextBoxColumn4.HeaderText = "Department";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn5.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn7.HeaderText = "Email";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.employeeDataSet;
            // 
            // employeeDataSet
            // 
            this.employeeDataSet.DataSetName = "EmployeeDataSet";
            this.employeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDataSetBindingSource
            // 
            this.employeeDataSetBindingSource.DataSource = this.employeeDataSet;
            this.employeeDataSetBindingSource.Position = 0;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.UpdateOrder = _11_Problem_11_4_Use_SQL_for_Retrieval.EmployeeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 390);
            this.Controls.Add(this.btnMaxSal);
            this.Controls.Add(this.btnMinSalary);
            this.Controls.Add(this.btnAvgSal);
            this.Controls.Add(this.btnSalGR40000);
            this.Controls.Add(this.btnSortByDept);
            this.Controls.Add(this.employeeDataGridView);
            this.Name = "Form1";
            this.Text = "SQL for Retrieval";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource employeeDataSetBindingSource;
        private EmployeeDataSet employeeDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EmployeeDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private EmployeeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnSortByDept;
        private System.Windows.Forms.Button btnSalGR40000;
        private System.Windows.Forms.Button btnAvgSal;
        private System.Windows.Forms.Button btnMinSalary;
        private System.Windows.Forms.Button btnMaxSal;
    }
}

