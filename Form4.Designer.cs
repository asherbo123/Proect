namespace PhysioTherapy
{
    partial class Form4
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
            this.btuptade = new System.Windows.Forms.Button();
            this.btdeleteDoctor = new System.Windows.Forms.Button();
            this.btviewappointment = new System.Windows.Forms.Button();
            this.btaddDoctor = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.panelChildForm.Controls.Add(this.btuptade);
            this.panelChildForm.Controls.Add(this.btdeleteDoctor);
            this.panelChildForm.Controls.Add(this.btviewappointment);
            this.panelChildForm.Controls.Add(this.btaddDoctor);
            this.panelChildForm.Controls.Add(this.panel5);
            this.panelChildForm.Controls.Add(this.panel4);
            this.panelChildForm.Controls.Add(this.panel3);
            this.panelChildForm.Controls.Add(this.panel2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(958, 717);
            this.panelChildForm.TabIndex = 0;
            // 
            // btuptade
            // 
            this.btuptade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btuptade.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btuptade.FlatAppearance.BorderSize = 0;
            this.btuptade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btuptade.Location = new System.Drawing.Point(576, 567);
            this.btuptade.Name = "btuptade";
            this.btuptade.Size = new System.Drawing.Size(150, 40);
            this.btuptade.TabIndex = 11;
            this.btuptade.Text = "Update";
            this.btuptade.UseVisualStyleBackColor = false;
            this.btuptade.Click += new System.EventHandler(this.btuptade_Click);
            // 
            // btdeleteDoctor
            // 
            this.btdeleteDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btdeleteDoctor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btdeleteDoctor.FlatAppearance.BorderSize = 0;
            this.btdeleteDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdeleteDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdeleteDoctor.Location = new System.Drawing.Point(214, 567);
            this.btdeleteDoctor.Name = "btdeleteDoctor";
            this.btdeleteDoctor.Size = new System.Drawing.Size(150, 40);
            this.btdeleteDoctor.TabIndex = 10;
            this.btdeleteDoctor.Text = "Delete Doctor";
            this.btdeleteDoctor.UseVisualStyleBackColor = false;
            this.btdeleteDoctor.Click += new System.EventHandler(this.btdeleteDoctor_Click);
            // 
            // btviewappointment
            // 
            this.btviewappointment.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btviewappointment.FlatAppearance.BorderSize = 0;
            this.btviewappointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btviewappointment.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btviewappointment.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btviewappointment.Location = new System.Drawing.Point(214, 276);
            this.btviewappointment.Name = "btviewappointment";
            this.btviewappointment.Size = new System.Drawing.Size(150, 61);
            this.btviewappointment.TabIndex = 9;
            this.btviewappointment.Text = "View Appoinment";
            this.btviewappointment.UseVisualStyleBackColor = false;
            // 
            // btaddDoctor
            // 
            this.btaddDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btaddDoctor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btaddDoctor.FlatAppearance.BorderSize = 0;
            this.btaddDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btaddDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaddDoctor.Location = new System.Drawing.Point(576, 276);
            this.btaddDoctor.Name = "btaddDoctor";
            this.btaddDoctor.Size = new System.Drawing.Size(150, 40);
            this.btaddDoctor.TabIndex = 8;
            this.btaddDoctor.Text = "Add Doctor";
            this.btaddDoctor.UseVisualStyleBackColor = false;
            this.btaddDoctor.Click += new System.EventHandler(this.btaddDoctor_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackgroundImage = global::PhysioTherapy.Properties.Resources.icons8_edit_account_100;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(576, 411);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 150);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackgroundImage = global::PhysioTherapy.Properties.Resources.icons8_delete_user_male_100;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(214, 411);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 150);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = global::PhysioTherapy.Properties.Resources.icons8_add_administrator_100;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(576, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 150);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PhysioTherapy.Properties.Resources.icons8_today_1001;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(214, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 150);
            this.panel2.TabIndex = 0;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 717);
            this.Controls.Add(this.panelChildForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.panelChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btuptade;
        private System.Windows.Forms.Button btdeleteDoctor;
        private System.Windows.Forms.Button btviewappointment;
        private System.Windows.Forms.Button btaddDoctor;
    }
}