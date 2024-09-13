using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblMess.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblMess.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblMess.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblMess.ForeColor = Color.Black;
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            txtNhapTen.Focus();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblMess.Text = txtNhapTen.Text + ": " + txtMess.Text;
        }

        private void txtMess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblMess.Text = txtNhapTen.Text + ": " + txtMess.Text;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMess.Clear();
            txtNhapTen.Clear();
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            lblMess.Visible = chkVisible.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void picBig_Click(object sender, EventArgs e)
        {
            picBig.Visible = false;
            picSmall.Visible = true;
        }

        private void picSmall_Click(object sender, EventArgs e)
        {
            picBig.Visible = true;
            picSmall.Visible = false;
        }

    }
}
