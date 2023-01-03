using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysioTherapy
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        string photopath;
        byte[] binaryphoto;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg|Jpegs|*.Jpegs|png|*.png|GIf|*.Gif|Bitmaps|*.Bitmaps";
            file.Title = "Please Select an Image";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(file.OpenFile());
                photopath = file.FileName;
                FileStream fs = new FileStream(photopath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                binaryphoto = br.ReadBytes((int)fs.Length);
                fs.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtid.Clear();
            txtnationalid.Clear();
            txtaddress.Clear();
            // txtage.Clear();
            //numericAge.Equals(0);
            //numericSalry.Equals(0);
            txtemail.Clear();
            txtnumber.Clear();
            combgender.Text = String.Empty;
            MessageBox.Show("Clear!");
            txtDN.Clear();
            txtDC.Clear();
            txtname.Focus();
        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
