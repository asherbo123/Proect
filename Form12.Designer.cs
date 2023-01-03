namespace PhysioTherapy
{
    partial class Form12
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchD = new System.Windows.Forms.TextBox();
            this.databaseClinicalDataSet = new PhysioTherapy.DatabaseClinicalDataSet();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new PhysioTherapy.DatabaseClinicalDataSetTableAdapters.DoctorTableAdapter();
            this.doctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNationalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorGNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorGContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorPicDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.doctorsalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btUpdateD = new System.Windows.Forms.Button();
            this.btSearchD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseClinicalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorNameDataGridViewTextBoxColumn,
            this.doctorIDDataGridViewTextBoxColumn,
            this.doctorNationalIDDataGridViewTextBoxColumn,
            this.doctorAgeDataGridViewTextBoxColumn,
            this.doctorDOBDataGridViewTextBoxColumn,
            this.doctorAddressDataGridViewTextBoxColumn,
            this.doctorGenderDataGridViewTextBoxColumn,
            this.doctorPhoneDataGridViewTextBoxColumn,
            this.doctorEmailDataGridViewTextBoxColumn,
            this.doctorGNameDataGridViewTextBoxColumn,
            this.doctorGContactDataGridViewTextBoxColumn,
            this.doctorPicDataGridViewImageColumn,
            this.doctorsalaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doctorBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(958, 535);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearchD);
            this.panel1.Controls.Add(this.btUpdateD);
            this.panel1.Controls.Add(this.btSearchD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 535);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 182);
            this.panel1.TabIndex = 1;
            // 
            // txtSearchD
            // 
            this.txtSearchD.Location = new System.Drawing.Point(190, 61);
            this.txtSearchD.Name = "txtSearchD";
            this.txtSearchD.Size = new System.Drawing.Size(254, 22);
            this.txtSearchD.TabIndex = 7;
            // 
            // databaseClinicalDataSet
            // 
            this.databaseClinicalDataSet.DataSetName = "DatabaseClinicalDataSet";
            this.databaseClinicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.databaseClinicalDataSet;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // doctorNameDataGridViewTextBoxColumn
            // 
            this.doctorNameDataGridViewTextBoxColumn.DataPropertyName = "Doctor_Name";
            this.doctorNameDataGridViewTextBoxColumn.HeaderText = "Doctor_Name";
            this.doctorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorNameDataGridViewTextBoxColumn.Name = "doctorNameDataGridViewTextBoxColumn";
            this.doctorNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "Doctor_ID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "Doctor_ID";
            this.doctorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            this.doctorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.doctorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorNationalIDDataGridViewTextBoxColumn
            // 
            this.doctorNationalIDDataGridViewTextBoxColumn.DataPropertyName = "Doctor_National_ID";
            this.doctorNationalIDDataGridViewTextBoxColumn.HeaderText = "Doctor_National_ID";
            this.doctorNationalIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorNationalIDDataGridViewTextBoxColumn.Name = "doctorNationalIDDataGridViewTextBoxColumn";
            this.doctorNationalIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorAgeDataGridViewTextBoxColumn
            // 
            this.doctorAgeDataGridViewTextBoxColumn.DataPropertyName = "Doctor_Age";
            this.doctorAgeDataGridViewTextBoxColumn.HeaderText = "Doctor_Age";
            this.doctorAgeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorAgeDataGridViewTextBoxColumn.Name = "doctorAgeDataGridViewTextBoxColumn";
            this.doctorAgeDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorDOBDataGridViewTextBoxColumn
            // 
            this.doctorDOBDataGridViewTextBoxColumn.DataPropertyName = "Doctor_DOB";
            this.doctorDOBDataGridViewTextBoxColumn.HeaderText = "Doctor_DOB";
            this.doctorDOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorDOBDataGridViewTextBoxColumn.Name = "doctorDOBDataGridViewTextBoxColumn";
            this.doctorDOBDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorAddressDataGridViewTextBoxColumn
            // 
            this.doctorAddressDataGridViewTextBoxColumn.DataPropertyName = "Doctor_Address";
            this.doctorAddressDataGridViewTextBoxColumn.HeaderText = "Doctor_Address";
            this.doctorAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorAddressDataGridViewTextBoxColumn.Name = "doctorAddressDataGridViewTextBoxColumn";
            this.doctorAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorGenderDataGridViewTextBoxColumn
            // 
            this.doctorGenderDataGridViewTextBoxColumn.DataPropertyName = "Doctor_Gender";
            this.doctorGenderDataGridViewTextBoxColumn.HeaderText = "Doctor_Gender";
            this.doctorGenderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorGenderDataGridViewTextBoxColumn.Name = "doctorGenderDataGridViewTextBoxColumn";
            this.doctorGenderDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorPhoneDataGridViewTextBoxColumn
            // 
            this.doctorPhoneDataGridViewTextBoxColumn.DataPropertyName = "Doctor_Phone";
            this.doctorPhoneDataGridViewTextBoxColumn.HeaderText = "Doctor_Phone";
            this.doctorPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorPhoneDataGridViewTextBoxColumn.Name = "doctorPhoneDataGridViewTextBoxColumn";
            this.doctorPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorEmailDataGridViewTextBoxColumn
            // 
            this.doctorEmailDataGridViewTextBoxColumn.DataPropertyName = "Doctor_Email";
            this.doctorEmailDataGridViewTextBoxColumn.HeaderText = "Doctor_Email";
            this.doctorEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorEmailDataGridViewTextBoxColumn.Name = "doctorEmailDataGridViewTextBoxColumn";
            this.doctorEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorGNameDataGridViewTextBoxColumn
            // 
            this.doctorGNameDataGridViewTextBoxColumn.DataPropertyName = "Doctor_GName";
            this.doctorGNameDataGridViewTextBoxColumn.HeaderText = "Doctor_GName";
            this.doctorGNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorGNameDataGridViewTextBoxColumn.Name = "doctorGNameDataGridViewTextBoxColumn";
            this.doctorGNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorGContactDataGridViewTextBoxColumn
            // 
            this.doctorGContactDataGridViewTextBoxColumn.DataPropertyName = "Doctor_GContact";
            this.doctorGContactDataGridViewTextBoxColumn.HeaderText = "Doctor_GContact";
            this.doctorGContactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorGContactDataGridViewTextBoxColumn.Name = "doctorGContactDataGridViewTextBoxColumn";
            this.doctorGContactDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorPicDataGridViewImageColumn
            // 
            this.doctorPicDataGridViewImageColumn.DataPropertyName = "Doctor_Pic";
            this.doctorPicDataGridViewImageColumn.HeaderText = "Doctor_Pic";
            this.doctorPicDataGridViewImageColumn.MinimumWidth = 6;
            this.doctorPicDataGridViewImageColumn.Name = "doctorPicDataGridViewImageColumn";
            this.doctorPicDataGridViewImageColumn.Width = 125;
            // 
            // doctorsalaryDataGridViewTextBoxColumn
            // 
            this.doctorsalaryDataGridViewTextBoxColumn.DataPropertyName = "Doctor_salary";
            this.doctorsalaryDataGridViewTextBoxColumn.HeaderText = "Doctor_salary";
            this.doctorsalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorsalaryDataGridViewTextBoxColumn.Name = "doctorsalaryDataGridViewTextBoxColumn";
            this.doctorsalaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // btUpdateD
            // 
            this.btUpdateD.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btUpdateD.FlatAppearance.BorderSize = 0;
            this.btUpdateD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdateD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateD.Image = global::PhysioTherapy.Properties.Resources.icons8_available_updates_30;
            this.btUpdateD.Location = new System.Drawing.Point(12, 116);
            this.btUpdateD.Name = "btUpdateD";
            this.btUpdateD.Size = new System.Drawing.Size(157, 47);
            this.btUpdateD.TabIndex = 6;
            this.btUpdateD.Text = "Update";
            this.btUpdateD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUpdateD.UseVisualStyleBackColor = false;
            // 
            // btSearchD
            // 
            this.btSearchD.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btSearchD.FlatAppearance.BorderSize = 0;
            this.btSearchD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearchD.Image = global::PhysioTherapy.Properties.Resources.icons8_search_30;
            this.btSearchD.Location = new System.Drawing.Point(12, 36);
            this.btSearchD.Name = "btSearchD";
            this.btSearchD.Size = new System.Drawing.Size(157, 47);
            this.btSearchD.TabIndex = 5;
            this.btSearchD.Text = "Search";
            this.btSearchD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSearchD.UseVisualStyleBackColor = false;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(958, 717);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form12";
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseClinicalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchD;
        private System.Windows.Forms.Button btUpdateD;
        private System.Windows.Forms.Button btSearchD;
        private DatabaseClinicalDataSet databaseClinicalDataSet;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private DatabaseClinicalDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNationalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorGNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorGContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn doctorPicDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorsalaryDataGridViewTextBoxColumn;
    }
}