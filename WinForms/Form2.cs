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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was clicked");

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, Welcome to C# 2024 programming!");
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form was clicked.");
        }
    }
}
