namespace PhysioTherapy
{
    partial class Form8
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
            this.picTarget = new System.Windows.Forms.PictureBox();
            this.btnClickHere = new System.Windows.Forms.Button();
            this.txtOutPut = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // picTarget
            // 
            this.picTarget.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picTarget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picTarget.Location = new System.Drawing.Point(12, 12);
            this.picTarget.Name = "picTarget";
            this.picTarget.Size = new System.Drawing.Size(934, 414);
            this.picTarget.TabIndex = 0;
            this.picTarget.TabStop = false;
            this.picTarget.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnClickHere
            // 
            this.btnClickHere.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClickHere.FlatAppearance.BorderSize = 0;
            this.btnClickHere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClickHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickHere.Location = new System.Drawing.Point(290, 443);
            this.btnClickHere.Name = "btnClickHere";
            this.btnClickHere.Size = new System.Drawing.Size(322, 66);
            this.btnClickHere.TabIndex = 1;
            this.btnClickHere.Text = "Show Text";
            this.btnClickHere.UseVisualStyleBackColor = false;
            this.btnClickHere.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOutPut
            // 
            this.txtOutPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutPut.Location = new System.Drawing.Point(161, 541);
            this.txtOutPut.Multiline = true;
            this.txtOutPut.Name = "txtOutPut";
            this.txtOutPut.Size = new System.Drawing.Size(564, 164);
            this.txtOutPut.TabIndex = 2;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(958, 717);
            this.Controls.Add(this.txtOutPut);
            this.Controls.Add(this.btnClickHere);
            this.Controls.Add(this.picTarget);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTarget;
        private System.Windows.Forms.Button btnClickHere;
        private System.Windows.Forms.TextBox txtOutPut;
    }
}