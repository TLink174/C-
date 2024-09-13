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

namespace ConnectSQL
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        MySqlConnection sqlCon = null;
        String conn = "server=localhost;user=root;database=my1;port=3306;password=linh17423";
        DataTable dt = new DataTable();
        private void Form5_Load(object sender, EventArgs e)
        {
            ViewListofStuent();
        }
        private void ViewListofStuent()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conn))
            {
                sqlCon.Open();

                if (sqlCon.State == ConnectionState.Open)
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * from STUDENT", sqlCon))
                    {
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
                        {
                            dataAdapter.Fill(dt);
                        }
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }
        int result = -1;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conn))
            {
                sqlCon.Open();

                if (sqlCon.State == ConnectionState.Open)
                {
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO STUDENT(StudentID, Name, ClassID) VALUES (@StudentID, @Name, @ClassID)", sqlCon))
                    {
                        MySqlParameter param = new MySqlParameter("@StudentID", txtStudentID.Text);
                        cmd.Parameters.Add(param);
                        param = new MySqlParameter("@Name", txtName.Text);
                        cmd.Parameters.Add(param);
                        param = new MySqlParameter("@ClassID", txtClassID.Text);
                        cmd.Parameters.Add(param);
                        try
                        {
                            result = cmd.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\nInsert failed");
                        }
                        if (result > 0)
                        {
                            MessageBox.Show("Insert successfully");
                            dt.Clear();
                            ViewListofStuent();
                        }
                        else
                        {
                            MessageBox.Show("Insert failed");
                        }

                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtStudentID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtClassID.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conn))
            {
                sqlCon.Open();

                if (sqlCon.State == ConnectionState.Open)
                {
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE STUDENT SET Name = @Name, ClassID = @ClassID WHERE StudentID = @StudentID", sqlCon))
                    {
                        MySqlParameter param = new MySqlParameter("@StudentID", txtStudentID.Text);
                        cmd.Parameters.Add(param);
                        param = new MySqlParameter("@Name", txtName.Text);
                        cmd.Parameters.Add(param);
                        param = new MySqlParameter("@ClassID", txtClassID.Text);
                        cmd.Parameters.Add(param);
                        try
                        {
                            result = cmd.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("Update failed");
                        }
                        if (result > 0)
                        {
                            MessageBox.Show("Update successfully");
                            dt.Clear();
                            ViewListofStuent();
                        }
                    }
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conn))
            {
                sqlCon.Open();

                if (sqlCon.State == ConnectionState.Open)
                {
                    using (MySqlCommand cmd = new MySqlCommand("DELETE FROM STUDENT WHERE StudentID = @StudentID", sqlCon))
                    {
                        MySqlParameter param = new MySqlParameter("@StudentID", txtStudentID.Text);
                        cmd.Parameters.Add(param);
                        try
                        {
                            result = cmd.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("Delete failed");
                        }
                        if (result > 0)
                        {
                            MessageBox.Show("Delete successfully");
                            dt.Clear();
                            ViewListofStuent();
                            txtClassID.Text = "";
                            txtName.Text = "";
                            txtStudentID.Text = "";
                        }
                    }
                }
            }
        }
    }
}
