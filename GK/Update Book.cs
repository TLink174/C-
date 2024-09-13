using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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

namespace GK
{
    public partial class Update_Book : Form
    {
        public Update_Book()
        {
            InitializeComponent();
        }

        MySqlConnection sqlCon = null;
        String conn = "server=localhost;user=root;database=my1;port=3306;password=linh17423";
        int result = -1;
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookID.Text) || string.IsNullOrWhiteSpace(txtBookName.Text) || string.IsNullOrWhiteSpace(txtAuthor.Text) || string.IsNullOrWhiteSpace(txtYear.Text))
            {
                MessageBox.Show("Please fill in all the fields before inserting.");
                return;
            }
            if (!int.TryParse(txtYear.Text, out int year))
            {
                MessageBox.Show("Please enter a valid year as a number.");
                return;
            }

            using (MySqlConnection sqlCon = new MySqlConnection(conn))
            {
                sqlCon.Open();

                if (sqlCon.State == ConnectionState.Open)
                {
                  

                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO BOOK(BookID, BOOKNAME, AUTHOR, PUBLICATION_YEAR) VALUES (@BookID, @BookName, @Author, @PublicationYear)", sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@BookID", txtBookID.Text);
                        cmd.Parameters.AddWithValue("@BookName", txtBookName.Text);
                        cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
                        cmd.Parameters.AddWithValue("@PublicationYear", txtYear.Text);

                        try
                        {
                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Insert successfully");
                            }
                            else
                            {
                                MessageBox.Show("Insert failed");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\nInsert failed. Please check your input data.");
                        }
                    }
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookID.Text))
            {
                MessageBox.Show("Please enter a book ID to delete.");
                return;
            }

            using (MySqlConnection sqlCon = new MySqlConnection(conn))
            {
                sqlCon.Open();

                if (sqlCon.State == ConnectionState.Open)
                {
                    using (MySqlCommand cmd = new MySqlCommand("DELETE FROM BOOK WHERE BookID = @BookID", sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@BookID", txtBookID.Text);

                        try
                        {
                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Delete successfully");
                            }
                            else
                            {
                                MessageBox.Show("No record found with the given book ID.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\nDelete failed. Please check your input data.");
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookID.Text) || string.IsNullOrWhiteSpace(txtBookName.Text) || string.IsNullOrWhiteSpace(txtAuthor.Text) || string.IsNullOrWhiteSpace(txtYear.Text))
            {
                MessageBox.Show("Please fill in all the fields before updating.");
                return;
            }
            if (!int.TryParse(txtYear.Text, out int year))
            {
                MessageBox.Show("Please enter a valid year as a number.");
                return;
            }

            using (MySqlConnection sqlCon = new MySqlConnection(conn))
            {
                sqlCon.Open();

                if (sqlCon.State == ConnectionState.Open)
                {
                    using (MySqlCommand cmdCheck = new MySqlCommand("SELECT COUNT(*) FROM BOOK WHERE BookID = @BookID", sqlCon))
                    {
                        cmdCheck.Parameters.AddWithValue("@BookID", txtBookID.Text);
                        int existingCount = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        if (existingCount == 0)
                        {
                            MessageBox.Show("No record found with the given book ID. Update failed.");
                            return;
                        }
                    }

                    using (MySqlCommand cmd = new MySqlCommand("UPDATE BOOK SET BOOKNAME = @BookName, AUTHOR = @Author, PUBLICATION_YEAR = @PublicationYear WHERE BookID = @BookID", sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@BookID", txtBookID.Text);
                        cmd.Parameters.AddWithValue("@BookName", txtBookName.Text);
                        cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
                        cmd.Parameters.AddWithValue("@PublicationYear", txtYear.Text);

                        try
                        {
                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Update successfully");
                            }
                            else
                            {
                                MessageBox.Show("Update failed");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\nUpdate failed. Please check your input data.");
                        }
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
