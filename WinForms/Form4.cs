﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text;
            txtNhapTen.Focus();
        }

        private void btnEXit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Red;
            txtNhapTen.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Green;
            txtNhapTen.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Blue;
            txtNhapTen.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Black;
            txtNhapTen.ForeColor = Color.Black;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Italic);

        }

        private void chkGach_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Underline);

        }
    }
}
