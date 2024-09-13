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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnHo_Click(object sender, EventArgs e)
        {
            lblName.Text = txtHo.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblName.Text = txtTen.Text;
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblName.Text = txtHo.Text + " " + txtTen.Text;
        }

        private void lblName_DoubleClick(object sender, EventArgs e)
        {
            lblName.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
