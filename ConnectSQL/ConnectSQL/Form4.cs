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
using System.Xml.Linq;

namespace ConnectSQL
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        MySqlConnection sqlCon = null;
        String conn = "server=localhost;user=root;database=my1;port=3306;password=linh17423";
        DataTable dt = new DataTable();
        private void Form4_Load(object sender, EventArgs e)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conn))
            {
                sqlCon.Open();

                if (sqlCon.State == ConnectionState.Open)
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * from CLASS", sqlCon))
                    {
                        lsbClasses.ClearSelected();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string line = reader["ClassID"].ToString() + "-" + reader["ClassName"].ToString() + "-" + reader["Year"].ToString();
                                lsbClasses.Items.Add(line);
                            }
                        }
                    }
                }
            }
        }

        private void lsbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Clear();
            if (lsbClasses.SelectedIndex == -1) return;
            string line = lsbClasses.SelectedItem.ToString();
            string[] arr = line.Split('-');
            string ClassID = arr[0];

            using (MySqlConnection sqlCon = new MySqlConnection(conn))
            {
                sqlCon.Open();

                if (sqlCon.State == ConnectionState.Open)
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * from STUDENT where ClassID = @ClassID", sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@ClassID", ClassID);

                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
                        {
                            dataAdapter.Fill(dt);
                            
                        }
                        datGVStudents.DataSource = dt;
                    }
                }
            }
        }
    }
}
