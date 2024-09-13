using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection sqlCon = null;
        String conn = "server=localhost;user=root;database=my1;port=3306;password=linh17423";
        DataTable dt = new DataTable();
        int result = -1;


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Book update_Book = new Update_Book();

            DialogResult result = update_Book.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Update book successfully");
            }
        }

        private void searchByBookNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_by_Book_Name search_By_Book_Name = new Search_by_Book_Name();
            DialogResult result = search_By_Book_Name.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("View list successfully");
            }
        }
    }
}
