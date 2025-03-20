namespace SysArchPrelim
{
    partial class Form2
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
            this.DepartmentFormBtn = new System.Windows.Forms.Button();
            this.CollegeDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.CollegeNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CollegeIsActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.RetrieveRadioButtonCollege = new System.Windows.Forms.RadioButton();
            this.DeleteRadioButtonCollege = new System.Windows.Forms.RadioButton();
            this.UpdateRadioButtonCollege = new System.Windows.Forms.RadioButton();
            this.AddRadioButtonCollege = new System.Windows.Forms.RadioButton();
            this.CollegeCodeTextBox = new System.Windows.Forms.TextBox();
            this.CollegeNameTextBox = new System.Windows.Forms.TextBox();
            this.CollegeIDTextBox = new System.Windows.Forms.TextBox();
            this.databaseDataSet = new SysArchPrelim.DatabaseDataSet();
            this.collegeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeTableAdapter = new SysArchPrelim.DatabaseDataSetTableAdapters.CollegeTableAdapter();
            this.collegeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CollegeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DepartmentFormBtn
            // 
            this.DepartmentFormBtn.Location = new System.Drawing.Point(687, 52);
            this.DepartmentFormBtn.Name = "DepartmentFormBtn";
            this.DepartmentFormBtn.Size = new System.Drawing.Size(75, 23);
            this.DepartmentFormBtn.TabIndex = 30;
            this.DepartmentFormBtn.Text = "College form";
            this.DepartmentFormBtn.UseVisualStyleBackColor = true;
            this.DepartmentFormBtn.Click += new System.EventHandler(this.DepartmentFormBtn_Click);
            // 
            // CollegeDataGridView
            // 
            this.CollegeDataGridView.AutoGenerateColumns = false;
            this.CollegeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CollegeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collegeIDDataGridViewTextBoxColumn,
            this.collegeNameDataGridViewTextBoxColumn,
            this.collegeCodeDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.CollegeDataGridView.DataSource = this.collegeBindingSource;
            this.CollegeDataGridView.Location = new System.Drawing.Point(42, 207);
            this.CollegeDataGridView.Name = "CollegeDataGridView";
            this.CollegeDataGridView.Size = new System.Drawing.Size(444, 207);
            this.CollegeDataGridView.TabIndex = 29;
            this.CollegeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CollegeDataGridView_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "DepartmentCode";
            // 
            // CollegeNameLabel
            // 
            this.CollegeNameLabel.AutoSize = true;
            this.CollegeNameLabel.Location = new System.Drawing.Point(285, 36);
            this.CollegeNameLabel.Name = "CollegeNameLabel";
            this.CollegeNameLabel.Size = new System.Drawing.Size(70, 13);
            this.CollegeNameLabel.TabIndex = 27;
            this.CollegeNameLabel.Text = "CollegeName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "CollegeID";
            // 
            // CollegeIsActiveCheckBox
            // 
            this.CollegeIsActiveCheckBox.AutoSize = true;
            this.CollegeIsActiveCheckBox.Location = new System.Drawing.Point(534, 55);
            this.CollegeIsActiveCheckBox.Name = "CollegeIsActiveCheckBox";
            this.CollegeIsActiveCheckBox.Size = new System.Drawing.Size(64, 17);
            this.CollegeIsActiveCheckBox.TabIndex = 24;
            this.CollegeIsActiveCheckBox.Text = "IsActive";
            this.CollegeIsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // RetrieveRadioButtonCollege
            // 
            this.RetrieveRadioButtonCollege.AutoSize = true;
            this.RetrieveRadioButtonCollege.Location = new System.Drawing.Point(323, 97);
            this.RetrieveRadioButtonCollege.Name = "RetrieveRadioButtonCollege";
            this.RetrieveRadioButtonCollege.Size = new System.Drawing.Size(65, 17);
            this.RetrieveRadioButtonCollege.TabIndex = 23;
            this.RetrieveRadioButtonCollege.TabStop = true;
            this.RetrieveRadioButtonCollege.Text = "Retrieve";
            this.RetrieveRadioButtonCollege.UseVisualStyleBackColor = true;
            this.RetrieveRadioButtonCollege.CheckedChanged += new System.EventHandler(this.RetrieveRadioButtonCollege_CheckedChanged);
            // 
            // DeleteRadioButtonCollege
            // 
            this.DeleteRadioButtonCollege.AutoSize = true;
            this.DeleteRadioButtonCollege.Location = new System.Drawing.Point(232, 97);
            this.DeleteRadioButtonCollege.Name = "DeleteRadioButtonCollege";
            this.DeleteRadioButtonCollege.Size = new System.Drawing.Size(56, 17);
            this.DeleteRadioButtonCollege.TabIndex = 22;
            this.DeleteRadioButtonCollege.TabStop = true;
            this.DeleteRadioButtonCollege.Text = "Delete";
            this.DeleteRadioButtonCollege.UseVisualStyleBackColor = true;
            this.DeleteRadioButtonCollege.CheckedChanged += new System.EventHandler(this.DeleteRadioButtonCollege_CheckedChanged);
            // 
            // UpdateRadioButtonCollege
            // 
            this.UpdateRadioButtonCollege.AutoSize = true;
            this.UpdateRadioButtonCollege.Location = new System.Drawing.Point(141, 97);
            this.UpdateRadioButtonCollege.Name = "UpdateRadioButtonCollege";
            this.UpdateRadioButtonCollege.Size = new System.Drawing.Size(60, 17);
            this.UpdateRadioButtonCollege.TabIndex = 21;
            this.UpdateRadioButtonCollege.TabStop = true;
            this.UpdateRadioButtonCollege.Text = "Update";
            this.UpdateRadioButtonCollege.UseVisualStyleBackColor = true;
            this.UpdateRadioButtonCollege.CheckedChanged += new System.EventHandler(this.UpdateRadioButtonCollege_CheckedChanged);
            // 
            // AddRadioButtonCollege
            // 
            this.AddRadioButtonCollege.AutoSize = true;
            this.AddRadioButtonCollege.Location = new System.Drawing.Point(50, 97);
            this.AddRadioButtonCollege.Name = "AddRadioButtonCollege";
            this.AddRadioButtonCollege.Size = new System.Drawing.Size(44, 17);
            this.AddRadioButtonCollege.TabIndex = 20;
            this.AddRadioButtonCollege.TabStop = true;
            this.AddRadioButtonCollege.Text = "Add";
            this.AddRadioButtonCollege.UseVisualStyleBackColor = true;
            this.AddRadioButtonCollege.CheckedChanged += new System.EventHandler(this.AddRadioButtonCollege_CheckedChanged);
            // 
            // CollegeCodeTextBox
            // 
            this.CollegeCodeTextBox.Location = new System.Drawing.Point(414, 52);
            this.CollegeCodeTextBox.Name = "CollegeCodeTextBox";
            this.CollegeCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.CollegeCodeTextBox.TabIndex = 19;
            // 
            // CollegeNameTextBox
            // 
            this.CollegeNameTextBox.Location = new System.Drawing.Point(288, 52);
            this.CollegeNameTextBox.Name = "CollegeNameTextBox";
            this.CollegeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.CollegeNameTextBox.TabIndex = 18;
            // 
            // CollegeIDTextBox
            // 
            this.CollegeIDTextBox.Location = new System.Drawing.Point(166, 52);
            this.CollegeIDTextBox.Name = "CollegeIDTextBox";
            this.CollegeIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.CollegeIDTextBox.TabIndex = 17;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // collegeBindingSource
            // 
            this.collegeBindingSource.DataMember = "College";
            this.collegeBindingSource.DataSource = this.databaseDataSet;
            // 
            // collegeTableAdapter
            // 
            this.collegeTableAdapter.ClearBeforeFill = true;
            // 
            // collegeIDDataGridViewTextBoxColumn
            // 
            this.collegeIDDataGridViewTextBoxColumn.DataPropertyName = "CollegeID";
            this.collegeIDDataGridViewTextBoxColumn.HeaderText = "CollegeID";
            this.collegeIDDataGridViewTextBoxColumn.Name = "collegeIDDataGridViewTextBoxColumn";
            // 
            // collegeNameDataGridViewTextBoxColumn
            // 
            this.collegeNameDataGridViewTextBoxColumn.DataPropertyName = "CollegeName";
            this.collegeNameDataGridViewTextBoxColumn.HeaderText = "CollegeName";
            this.collegeNameDataGridViewTextBoxColumn.Name = "collegeNameDataGridViewTextBoxColumn";
            // 
            // collegeCodeDataGridViewTextBoxColumn
            // 
            this.collegeCodeDataGridViewTextBoxColumn.DataPropertyName = "CollegeCode";
            this.collegeCodeDataGridViewTextBoxColumn.HeaderText = "CollegeCode";
            this.collegeCodeDataGridViewTextBoxColumn.Name = "collegeCodeDataGridViewTextBoxColumn";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DepartmentFormBtn);
            this.Controls.Add(this.CollegeDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CollegeNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CollegeIsActiveCheckBox);
            this.Controls.Add(this.RetrieveRadioButtonCollege);
            this.Controls.Add(this.DeleteRadioButtonCollege);
            this.Controls.Add(this.UpdateRadioButtonCollege);
            this.Controls.Add(this.AddRadioButtonCollege);
            this.Controls.Add(this.CollegeCodeTextBox);
            this.Controls.Add(this.CollegeNameTextBox);
            this.Controls.Add(this.CollegeIDTextBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CollegeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DepartmentFormBtn;
        private System.Windows.Forms.DataGridView CollegeDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CollegeNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CollegeIsActiveCheckBox;
        private System.Windows.Forms.RadioButton RetrieveRadioButtonCollege;
        private System.Windows.Forms.RadioButton DeleteRadioButtonCollege;
        private System.Windows.Forms.RadioButton UpdateRadioButtonCollege;
        private System.Windows.Forms.RadioButton AddRadioButtonCollege;
        private System.Windows.Forms.TextBox CollegeCodeTextBox;
        private System.Windows.Forms.TextBox CollegeNameTextBox;
        private System.Windows.Forms.TextBox CollegeIDTextBox;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource collegeBindingSource;
        private DatabaseDataSetTableAdapters.CollegeTableAdapter collegeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
    }
}