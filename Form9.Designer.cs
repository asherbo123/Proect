namespace PhysioTherapy
{
    partial class Form9
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
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pateintAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientGNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientGContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientPicDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseClinicalDataSet = new PhysioTherapy.DatabaseClinicalDataSet();
            this.patientTableAdapter = new PhysioTherapy.DatabaseClinicalDataSetTableAdapters.PatientTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchP = new System.Windows.Forms.TextBox();
            this.btDeleteP = new System.Windows.Forms.Button();
            this.btSearchP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseClinicalDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientNameDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn,
            this.patientNIDDataGridViewTextBoxColumn,
            this.patientAgeDataGridViewTextBoxColumn,
            this.patientDOBDataGridViewTextBoxColumn,
            this.pateintAdressDataGridViewTextBoxColumn,
            this.patientGenderDataGridViewTextBoxColumn,
            this.patientPhoneDataGridViewTextBoxColumn,
            this.patientEmailDataGridViewTextBoxColumn,
            this.patientGNameDataGridViewTextBoxColumn,
            this.patientGContactDataGridViewTextBoxColumn,
            this.patientPicDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.patientBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(958, 535);
            this.dataGridView1.TabIndex = 0;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "Patient_Name";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "Patient_Name";
            this.patientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            this.patientNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientNIDDataGridViewTextBoxColumn
            // 
            this.patientNIDDataGridViewTextBoxColumn.DataPropertyName = "Patient_NID";
            this.patientNIDDataGridViewTextBoxColumn.HeaderText = "Patient_NID";
            this.patientNIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientNIDDataGridViewTextBoxColumn.Name = "patientNIDDataGridViewTextBoxColumn";
            this.patientNIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientAgeDataGridViewTextBoxColumn
            // 
            this.patientAgeDataGridViewTextBoxColumn.DataPropertyName = "Patient_Age";
            this.patientAgeDataGridViewTextBoxColumn.HeaderText = "Patient_Age";
            this.patientAgeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientAgeDataGridViewTextBoxColumn.Name = "patientAgeDataGridViewTextBoxColumn";
            this.patientAgeDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientDOBDataGridViewTextBoxColumn
            // 
            this.patientDOBDataGridViewTextBoxColumn.DataPropertyName = "Patient_DOB";
            this.patientDOBDataGridViewTextBoxColumn.HeaderText = "Patient_DOB";
            this.patientDOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientDOBDataGridViewTextBoxColumn.Name = "patientDOBDataGridViewTextBoxColumn";
            this.patientDOBDataGridViewTextBoxColumn.Width = 125;
            // 
            // pateintAdressDataGridViewTextBoxColumn
            // 
            this.pateintAdressDataGridViewTextBoxColumn.DataPropertyName = "Pateint_Adress";
            this.pateintAdressDataGridViewTextBoxColumn.HeaderText = "Pateint_Adress";
            this.pateintAdressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pateintAdressDataGridViewTextBoxColumn.Name = "pateintAdressDataGridViewTextBoxColumn";
            this.pateintAdressDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientGenderDataGridViewTextBoxColumn
            // 
            this.patientGenderDataGridViewTextBoxColumn.DataPropertyName = "Patient_Gender";
            this.patientGenderDataGridViewTextBoxColumn.HeaderText = "Patient_Gender";
            this.patientGenderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientGenderDataGridViewTextBoxColumn.Name = "patientGenderDataGridViewTextBoxColumn";
            this.patientGenderDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientPhoneDataGridViewTextBoxColumn
            // 
            this.patientPhoneDataGridViewTextBoxColumn.DataPropertyName = "Patient_Phone";
            this.patientPhoneDataGridViewTextBoxColumn.HeaderText = "Patient_Phone";
            this.patientPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientPhoneDataGridViewTextBoxColumn.Name = "patientPhoneDataGridViewTextBoxColumn";
            this.patientPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientEmailDataGridViewTextBoxColumn
            // 
            this.patientEmailDataGridViewTextBoxColumn.DataPropertyName = "Patient_Email";
            this.patientEmailDataGridViewTextBoxColumn.HeaderText = "Patient_Email";
            this.patientEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientEmailDataGridViewTextBoxColumn.Name = "patientEmailDataGridViewTextBoxColumn";
            this.patientEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientGNameDataGridViewTextBoxColumn
            // 
            this.patientGNameDataGridViewTextBoxColumn.DataPropertyName = "Patient_GName";
            this.patientGNameDataGridViewTextBoxColumn.HeaderText = "Patient_GName";
            this.patientGNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientGNameDataGridViewTextBoxColumn.Name = "patientGNameDataGridViewTextBoxColumn";
            this.patientGNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientGContactDataGridViewTextBoxColumn
            // 
            this.patientGContactDataGridViewTextBoxColumn.DataPropertyName = "Patient_GContact";
            this.patientGContactDataGridViewTextBoxColumn.HeaderText = "Patient_GContact";
            this.patientGContactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientGContactDataGridViewTextBoxColumn.Name = "patientGContactDataGridViewTextBoxColumn";
            this.patientGContactDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientPicDataGridViewImageColumn
            // 
            this.patientPicDataGridViewImageColumn.DataPropertyName = "Patient_Pic";
            this.patientPicDataGridViewImageColumn.HeaderText = "Patient_Pic";
            this.patientPicDataGridViewImageColumn.MinimumWidth = 6;
            this.patientPicDataGridViewImageColumn.Name = "patientPicDataGridViewImageColumn";
            this.patientPicDataGridViewImageColumn.Width = 125;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.databaseClinicalDataSet;
            // 
            // databaseClinicalDataSet
            // 
            this.databaseClinicalDataSet.DataSetName = "DatabaseClinicalDataSet";
            this.databaseClinicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearchP);
            this.panel1.Controls.Add(this.btDeleteP);
            this.panel1.Controls.Add(this.btSearchP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 535);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 182);
            this.panel1.TabIndex = 1;
            // 
            // txtSearchP
            // 
            this.txtSearchP.Location = new System.Drawing.Point(202, 47);
            this.txtSearchP.Name = "txtSearchP";
            this.txtSearchP.Size = new System.Drawing.Size(258, 22);
            this.txtSearchP.TabIndex = 6;
            // 
            // btDeleteP
            // 
            this.btDeleteP.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btDeleteP.FlatAppearance.BorderSize = 0;
            this.btDeleteP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteP.Image = global::PhysioTherapy.Properties.Resources.icons8_delete_document_24;
            this.btDeleteP.Location = new System.Drawing.Point(12, 110);
            this.btDeleteP.Name = "btDeleteP";
            this.btDeleteP.Size = new System.Drawing.Size(157, 38);
            this.btDeleteP.TabIndex = 5;
            this.btDeleteP.Text = "Delete";
            this.btDeleteP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDeleteP.UseVisualStyleBackColor = false;
            // 
            // btSearchP
            // 
            this.btSearchP.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btSearchP.FlatAppearance.BorderSize = 0;
            this.btSearchP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearchP.Image = global::PhysioTherapy.Properties.Resources.icons8_search_client_24;
            this.btSearchP.Location = new System.Drawing.Point(12, 29);
            this.btSearchP.Name = "btSearchP";
            this.btSearchP.Size = new System.Drawing.Size(157, 40);
            this.btSearchP.TabIndex = 4;
            this.btSearchP.Text = "Search";
            this.btSearchP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSearchP.UseVisualStyleBackColor = false;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(958, 717);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseClinicalDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseClinicalDataSet databaseClinicalDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private DatabaseClinicalDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pateintAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientGNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientGContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn patientPicDataGridViewImageColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchP;
        private System.Windows.Forms.Button btDeleteP;
        private System.Windows.Forms.Button btSearchP;
    }
}