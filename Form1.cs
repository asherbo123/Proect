using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysioTherapy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btmax.Visible = false;
            btmaxed.Location = btmax.Location;
            btmaxed.Visible = true;
        }

        private void btmaxed_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btmaxed.Visible = false;
            btmax.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                Reset();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtUserName.Clear();
            txtpassword.Clear();
            txtUserName.Focus();
        }

        private void Login()
        {
            if (txtUserName.Text == "Admin"
                && txtpassword.Text == "1234")
            {
                new Home().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The User name or Password is incorrect," +
                    "Try again");
                txtUserName.Clear();
                txtpassword.Clear();
                txtUserName.Focus();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
