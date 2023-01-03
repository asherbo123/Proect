namespace PhysioTherapy
{
    partial class Form5
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
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btSetApp = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDeletePatient = new System.Windows.Forms.Button();
            this.btNotes = new System.Windows.Forms.Button();
            this.btAddPatient = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelChildForm.Controls.Add(this.btSetApp);
            this.panelChildForm.Controls.Add(this.panel6);
            this.panelChildForm.Controls.Add(this.btUpdate);
            this.panelChildForm.Controls.Add(this.btDeletePatient);
            this.panelChildForm.Controls.Add(this.btNotes);
            this.panelChildForm.Controls.Add(this.btAddPatient);
            this.panelChildForm.Controls.Add(this.panel5);
            this.panelChildForm.Controls.Add(this.panel4);
            this.panelChildForm.Controls.Add(this.panel3);
            this.panelChildForm.Controls.Add(this.panel2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(958, 717);
            this.panelChildForm.TabIndex = 0;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btSetApp
            // 
            this.btSetApp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSetApp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btSetApp.FlatAppearance.BorderSize = 0;
            this.btSetApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSetApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSetApp.Location = new System.Drawing.Point(405, 403);
            this.btSetApp.Name = "btSetApp";
            this.btSetApp.Size = new System.Drawing.Size(150, 56);
            this.btSetApp.TabIndex = 21;
            this.btSetApp.Text = "Set Appointment";
            this.btSetApp.UseVisualStyleBackColor = false;
            // 
            // btUpdate
            // 
            this.btUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btUpdate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btUpdate.FlatAppearance.BorderSize = 0;
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(704, 556);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(150, 40);
            this.btUpdate.TabIndex = 19;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDeletePatient
            // 
            this.btDeletePatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDeletePatient.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btDeletePatient.FlatAppearance.BorderSize = 0;
            this.btDeletePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeletePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletePatient.Location = new System.Drawing.Point(110, 556);
            this.btDeletePatient.Name = "btDeletePatient";
            this.btDeletePatient.Size = new System.Drawing.Size(150, 40);
            this.btDeletePatient.TabIndex = 18;
            this.btDeletePatient.Text = "Delete Patient";
            this.btDeletePatient.UseVisualStyleBackColor = false;
            this.btDeletePatient.Click += new System.EventHandler(this.btDeletePatient_Click);
            // 
            // btNotes
            // 
            this.btNotes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btNotes.FlatAppearance.BorderSize = 0;
            this.btNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNotes.Location = new System.Drawing.Point(110, 216);
            this.btNotes.Name = "btNotes";
            this.btNotes.Size = new System.Drawing.Size(150, 40);
            this.btNotes.TabIndex = 17;
            this.btNotes.Text = "Notes";
            this.btNotes.UseVisualStyleBackColor = false;
            // 
            // btAddPatient
            // 
            this.btAddPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddPatient.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btAddPatient.FlatAppearance.BorderSize = 0;
            this.btAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddPatient.Location = new System.Drawing.Point(704, 216);
            this.btAddPatient.Name = "btAddPatient";
            this.btAddPatient.Size = new System.Drawing.Size(150, 40);
            this.btAddPatient.TabIndex = 16;
            this.btAddPatient.Text = "Add Patient";
            this.btAddPatient.UseVisualStyleBackColor = false;
            this.btAddPatient.Click += new System.EventHandler(this.btaddDoctor_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackgroundImage = global::PhysioTherapy.Properties.Resources.icons8_person_calendar_100;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(405, 247);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 150);
            this.panel6.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackgroundImage = global::PhysioTherapy.Properties.Resources.icons8_edit_account_100;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(704, 400);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 150);
            this.panel5.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackgroundImage = global::PhysioTherapy.Properties.Resources.icons8_delete_user_male_100;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(110, 400);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 150);
            this.panel4.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = global::PhysioTherapy.Properties.Resources.icons8_add_administrator_100;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(704, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 150);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PhysioTherapy.Properties.Resources.icons8_note_100;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(110, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 150);
            this.panel2.TabIndex = 8;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 717);
            this.Controls.Add(this.panelChildForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.panelChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDeletePatient;
        private System.Windows.Forms.Button btNotes;
        private System.Windows.Forms.Button btAddPatient;
        private System.Windows.Forms.Button btSetApp;
        private System.Windows.Forms.Panel panel6;
    }
}