namespace SysArchPrelim
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
            this.DepartmentIDTextBox = new System.Windows.Forms.TextBox();
            this.CollegeIDTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentNameTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentCodeTextBox = new System.Windows.Forms.TextBox();
            this.AddRadioButton = new System.Windows.Forms.RadioButton();
            this.UpdateRadioButton = new System.Windows.Forms.RadioButton();
            this.DeleteRadioButton = new System.Windows.Forms.RadioButton();
            this.RetrieveRadioButton = new System.Windows.Forms.RadioButton();
            this.IsActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DepartmentDataGridView = new System.Windows.Forms.DataGridView();
            this.CollegeFormBtn = new System.Windows.Forms.Button();
            this.databaseDataSet = new SysArchPrelim.DatabaseDataSet();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new SysArchPrelim.DatabaseDataSetTableAdapters.DepartmentTableAdapter();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DepartmentIDTextBox
            // 
            this.DepartmentIDTextBox.Location = new System.Drawing.Point(35, 47);
            this.DepartmentIDTextBox.Name = "DepartmentIDTextBox";
            this.DepartmentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.DepartmentIDTextBox.TabIndex = 0;
            // 
            // CollegeIDTextBox
            // 
            this.CollegeIDTextBox.Location = new System.Drawing.Point(159, 47);
            this.CollegeIDTextBox.Name = "CollegeIDTextBox";
            this.CollegeIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.CollegeIDTextBox.TabIndex = 1;
            // 
            // DepartmentNameTextBox
            // 
            this.DepartmentNameTextBox.Location = new System.Drawing.Point(281, 47);
            this.DepartmentNameTextBox.Name = "DepartmentNameTextBox";
            this.DepartmentNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.DepartmentNameTextBox.TabIndex = 2;
            // 
            // DepartmentCodeTextBox
            // 
            this.DepartmentCodeTextBox.Location = new System.Drawing.Point(407, 47);
            this.DepartmentCodeTextBox.Name = "DepartmentCodeTextBox";
            this.DepartmentCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.DepartmentCodeTextBox.TabIndex = 3;
            // 
            // AddRadioButton
            // 
            this.AddRadioButton.AutoSize = true;
            this.AddRadioButton.Location = new System.Drawing.Point(43, 92);
            this.AddRadioButton.Name = "AddRadioButton";
            this.AddRadioButton.Size = new System.Drawing.Size(44, 17);
            this.AddRadioButton.TabIndex = 5;
            this.AddRadioButton.TabStop = true;
            this.AddRadioButton.Text = "Add";
            this.AddRadioButton.UseVisualStyleBackColor = true;
            this.AddRadioButton.CheckedChanged += new System.EventHandler(this.AddRadioButton_CheckedChanged);
            // 
            // UpdateRadioButton
            // 
            this.UpdateRadioButton.AutoSize = true;
            this.UpdateRadioButton.Location = new System.Drawing.Point(134, 92);
            this.UpdateRadioButton.Name = "UpdateRadioButton";
            this.UpdateRadioButton.Size = new System.Drawing.Size(60, 17);
            this.UpdateRadioButton.TabIndex = 6;
            this.UpdateRadioButton.TabStop = true;
            this.UpdateRadioButton.Text = "Update";
            this.UpdateRadioButton.UseVisualStyleBackColor = true;
            this.UpdateRadioButton.CheckedChanged += new System.EventHandler(this.UpdateRadioButton_CheckedChanged);
            // 
            // DeleteRadioButton
            // 
            this.DeleteRadioButton.AutoSize = true;
            this.DeleteRadioButton.Location = new System.Drawing.Point(225, 92);
            this.DeleteRadioButton.Name = "DeleteRadioButton";
            this.DeleteRadioButton.Size = new System.Drawing.Size(56, 17);
            this.DeleteRadioButton.TabIndex = 7;
            this.DeleteRadioButton.TabStop = true;
            this.DeleteRadioButton.Text = "Delete";
            this.DeleteRadioButton.UseVisualStyleBackColor = true;
            this.DeleteRadioButton.CheckedChanged += new System.EventHandler(this.DeleteRadioButton_CheckedChanged);
            // 
            // RetrieveRadioButton
            // 
            this.RetrieveRadioButton.AutoSize = true;
            this.RetrieveRadioButton.Location = new System.Drawing.Point(316, 92);
            this.RetrieveRadioButton.Name = "RetrieveRadioButton";
            this.RetrieveRadioButton.Size = new System.Drawing.Size(65, 17);
            this.RetrieveRadioButton.TabIndex = 8;
            this.RetrieveRadioButton.TabStop = true;
            this.RetrieveRadioButton.Text = "Retrieve";
            this.RetrieveRadioButton.UseVisualStyleBackColor = true;
            this.RetrieveRadioButton.CheckedChanged += new System.EventHandler(this.RetrieveRadioButton_CheckedChanged);
            // 
            // IsActiveCheckBox
            // 
            this.IsActiveCheckBox.AutoSize = true;
            this.IsActiveCheckBox.Location = new System.Drawing.Point(527, 50);
            this.IsActiveCheckBox.Name = "IsActiveCheckBox";
            this.IsActiveCheckBox.Size = new System.Drawing.Size(64, 17);
            this.IsActiveCheckBox.TabIndex = 9;
            this.IsActiveCheckBox.Text = "IsActive";
            this.IsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "DepartmentID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "CollegeID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "DepartmentName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "DepartmentCode";
            // 
            // DepartmentDataGridView
            // 
            this.DepartmentDataGridView.AutoGenerateColumns = false;
            this.DepartmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentIDDataGridViewTextBoxColumn,
            this.collegeIDDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn,
            this.departmentCodeDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.DepartmentDataGridView.DataSource = this.departmentBindingSource;
            this.DepartmentDataGridView.Location = new System.Drawing.Point(35, 202);
            this.DepartmentDataGridView.Name = "DepartmentDataGridView";
            this.DepartmentDataGridView.Size = new System.Drawing.Size(544, 207);
            this.DepartmentDataGridView.TabIndex = 14;
            // 
            // CollegeFormBtn
            // 
            this.CollegeFormBtn.Location = new System.Drawing.Point(680, 47);
            this.CollegeFormBtn.Name = "CollegeFormBtn";
            this.CollegeFormBtn.Size = new System.Drawing.Size(75, 23);
            this.CollegeFormBtn.TabIndex = 15;
            this.CollegeFormBtn.Text = "College form";
            this.CollegeFormBtn.UseVisualStyleBackColor = true;
            this.CollegeFormBtn.Click += new System.EventHandler(this.CollegeFormBtn_Click);
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.databaseDataSet;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            // 
            // collegeIDDataGridViewTextBoxColumn
            // 
            this.collegeIDDataGridViewTextBoxColumn.DataPropertyName = "CollegeID";
            this.collegeIDDataGridViewTextBoxColumn.HeaderText = "CollegeID";
            this.collegeIDDataGridViewTextBoxColumn.Name = "collegeIDDataGridViewTextBoxColumn";
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            // 
            // departmentCodeDataGridViewTextBoxColumn
            // 
            this.departmentCodeDataGridViewTextBoxColumn.DataPropertyName = "DepartmentCode";
            this.departmentCodeDataGridViewTextBoxColumn.HeaderText = "DepartmentCode";
            this.departmentCodeDataGridViewTextBoxColumn.Name = "departmentCodeDataGridViewTextBoxColumn";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CollegeFormBtn);
            this.Controls.Add(this.DepartmentDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsActiveCheckBox);
            this.Controls.Add(this.RetrieveRadioButton);
            this.Controls.Add(this.DeleteRadioButton);
            this.Controls.Add(this.UpdateRadioButton);
            this.Controls.Add(this.AddRadioButton);
            this.Controls.Add(this.DepartmentCodeTextBox);
            this.Controls.Add(this.DepartmentNameTextBox);
            this.Controls.Add(this.CollegeIDTextBox);
            this.Controls.Add(this.DepartmentIDTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DepartmentIDTextBox;
        private System.Windows.Forms.TextBox CollegeIDTextBox;
        private System.Windows.Forms.TextBox DepartmentNameTextBox;
        private System.Windows.Forms.TextBox DepartmentCodeTextBox;
        private System.Windows.Forms.RadioButton AddRadioButton;
        private System.Windows.Forms.RadioButton UpdateRadioButton;
        private System.Windows.Forms.RadioButton DeleteRadioButton;
        private System.Windows.Forms.RadioButton RetrieveRadioButton;
        private System.Windows.Forms.CheckBox IsActiveCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DepartmentDataGridView;
        private System.Windows.Forms.Button CollegeFormBtn;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DatabaseDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
    }
}

