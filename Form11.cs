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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseClinicalDataSet1.Doctor' table. You can move, or remove it, as needed.
           // this.doctorTableAdapter1.Fill(this.databaseClinicalDataSet1.Doctor);
           

        }

        private void btDeleteD_Click(object sender, EventArgs e)
        {
            
            
            
            
           // this.doctorTableAdapter.DeleteDoctor();
        }

        private void doctor_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
