namespace PhysioTherapy
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btsetting = new System.Windows.Forms.Button();
            this.btreceptionist = new System.Windows.Forms.Button();
            this.btdoctor = new System.Windows.Forms.Button();
            this.bthome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btmaxed = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btmax = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btsetting);
            this.panel1.Controls.Add(this.btreceptionist);
            this.panel1.Controls.Add(this.btdoctor);
            this.panel1.Controls.Add(this.bthome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 717);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackgroundImage = global::PhysioTherapy.Properties.Resources.icons8_logout_rounded_left_481;
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(3, 666);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(48, 48);
            this.panel4.TabIndex = 7;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::PhysioTherapy.Properties.Resources.icons8_logout_rounded_left_32;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 48);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::PhysioTherapy.Properties.Resources.icons8_sick_48;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(212, 52);
            this.button4.TabIndex = 6;
            this.button4.Text = "Patient";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btsetting
            // 
            this.btsetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btsetting.FlatAppearance.BorderSize = 0;
            this.btsetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsetting.Image = global::PhysioTherapy.Properties.Resources.icons8_gear_32;
            this.btsetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsetting.Location = new System.Drawing.Point(2, 392);
            this.btsetting.Name = "btsetting";
            this.btsetting.Size = new System.Drawing.Size(212, 43);
            this.btsetting.TabIndex = 4;
            this.btsetting.Text = "Setting";
            this.btsetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsetting.UseVisualStyleBackColor = true;
            this.btsetting.Click += new System.EventHandler(this.btsetting_Click);
            // 
            // btreceptionist
            // 
            this.btreceptionist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btreceptionist.FlatAppearance.BorderSize = 0;
            this.btreceptionist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btreceptionist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btreceptionist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btreceptionist.Image = global::PhysioTherapy.Properties.Resources.icons8_reception_desk_with_bell_to_call_for_service_48;
            this.btreceptionist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btreceptionist.Location = new System.Drawing.Point(2, 276);
            this.btreceptionist.Name = "btreceptionist";
            this.btreceptionist.Size = new System.Drawing.Size(212, 52);
            this.btreceptionist.TabIndex = 3;
            this.btreceptionist.Text = "Receptionist";
            this.btreceptionist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btreceptionist.UseVisualStyleBackColor = true;
            this.btreceptionist.Click += new System.EventHandler(this.btreceptionist_Click);
            // 
            // btdoctor
            // 
            this.btdoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btdoctor.FlatAppearance.BorderSize = 0;
            this.btdoctor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btdoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdoctor.Image = global::PhysioTherapy.Properties.Resources.icons8_doctor_48;
            this.btdoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdoctor.Location = new System.Drawing.Point(2, 218);
            this.btdoctor.Name = "btdoctor";
            this.btdoctor.Size = new System.Drawing.Size(212, 52);
            this.btdoctor.TabIndex = 2;
            this.btdoctor.Text = "Doctor";
            this.btdoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btdoctor.UseVisualStyleBackColor = true;
            this.btdoctor.Click += new System.EventHandler(this.btdoctor_Click);
            // 
            // bthome
            // 
            this.bthome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bthome.FlatAppearance.BorderSize = 0;
            this.bthome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.bthome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthome.Image = ((System.Drawing.Image)(resources.GetObject("bthome.Image")));
            this.bthome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthome.Location = new System.Drawing.Point(2, 160);
            this.bthome.Name = "bthome";
            this.bthome.Size = new System.Drawing.Size(212, 52);
            this.bthome.TabIndex = 1;
            this.bthome.Text = "Home";
            this.bthome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bthome.UseVisualStyleBackColor = true;
            this.bthome.Click += new System.EventHandler(this.bthome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 154);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.panel3.Controls.Add(this.btmaxed);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btmax);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(217, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(958, 32);
            this.panel3.TabIndex = 1;
            // 
            // btmaxed
            // 
            this.btmaxed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btmaxed.BackColor = System.Drawing.Color.White;
            this.btmaxed.FlatAppearance.BorderSize = 0;
            this.btmaxed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmaxed.ForeColor = System.Drawing.Color.Black;
            this.btmaxed.Image = global::PhysioTherapy.Properties.Resources.icons8_maximize_window_25;
            this.btmaxed.Location = new System.Drawing.Point(790, 0);
            this.btmaxed.Name = "btmaxed";
            this.btmaxed.Size = new System.Drawing.Size(37, 32);
            this.btmaxed.TabIndex = 8;
            this.btmaxed.UseVisualStyleBackColor = false;
            this.btmaxed.Click += new System.EventHandler(this.btmaxed_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::PhysioTherapy.Properties.Resources.icons8_subtract_24__1_;
            this.button2.Location = new System.Drawing.Point(833, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 32);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btmax
            // 
            this.btmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btmax.BackColor = System.Drawing.Color.White;
            this.btmax.FlatAppearance.BorderSize = 0;
            this.btmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmax.ForeColor = System.Drawing.Color.Black;
            this.btmax.Image = global::PhysioTherapy.Properties.Resources.icons8_restore_down_16__1_;
            this.btmax.Location = new System.Drawing.Point(878, 0);
            this.btmax.Name = "btmax";
            this.btmax.Size = new System.Drawing.Size(37, 32);
            this.btmax.TabIndex = 6;
            this.btmax.UseVisualStyleBackColor = false;
            this.btmax.Click += new System.EventHandler(this.btmax_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::PhysioTherapy.Properties.Resources.icons8_close_24;
            this.button1.Location = new System.Drawing.Point(921, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 32);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChildForm.BackgroundImage")));
            this.panelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(217, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(958, 717);
            this.panelChildForm.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 717);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btmaxed;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btmax;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btsetting;
        private System.Windows.Forms.Button btreceptionist;
        private System.Windows.Forms.Button btdoctor;
        private System.Windows.Forms.Button bthome;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel4;
    }
}