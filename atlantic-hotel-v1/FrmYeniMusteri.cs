﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atlantic_hotel_v1
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnOda101_Click(object sender, EventArgs e)
        {
            txtOda.Text = "101";
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            txtOda.Text = "102";
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            txtOda.Text = "103";
        }

        private void btnOda104_Click(object sender, EventArgs e)
        {
            txtOda.Text = "104";
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            txtOda.Text = "105";
        }

        private void btnOda106_Click(object sender, EventArgs e)
        {
            txtOda.Text = "106";
        }

        private void btnOda107_Click(object sender, EventArgs e)
        {
            txtOda.Text = "107";
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            txtOda.Text = "108";
        }

        private void btnOda109_Click(object sender, EventArgs e)
        {
            txtOda.Text = "109";
        }

        private void btnOdaBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar boş odaları gösterir.");
        }

        private void btnOdaDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları gösterir.");
        }
    }
}
