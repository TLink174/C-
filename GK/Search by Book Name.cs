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
    public partial class Search_by_Book_Name : Form
    {
        public Search_by_Book_Name()
        {
            InitializeComponent();
        }
        MySqlConnection sqlCon = null;
        String conn = "server=localhost;user=root;database=my1;port=3306;password=linh17423";
        DataTable dt = new DataTable();
        int result = -1;

        private void ViewList()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conn))
            {
                sqlCon.Open();

                if (sqlCon.State == ConnectionState.Open)
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * from Book where BookName like '%" + txtBookName.Text + "%'", sqlCon))
                    {
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
                        {
                            dataAdapter.Fill(dt);
                        }
                        datBook.DataSource = dt;
                    }
                }
            }
        }

        private void txtBookName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               ViewList();
            }
        }
    }
}
