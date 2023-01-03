﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patagames.Ocr;
using System.Drawing;

namespace PhysioTherapy
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var objOcr = OcrApi.Create())
            {
                objOcr.Init(Patagames.Ocr.Enums.Languages.English);

                string plainText = objOcr.GetTextFromImage(picTarget.ImageLocation);

                txtOutPut.Text = plainText;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            picTarget.ImageLocation = @"F:\NU UNI\BMD\Projects\PhysioTherapy\PhysioTherapy\NewFolder1\testocr.png";
        }

    }
}
