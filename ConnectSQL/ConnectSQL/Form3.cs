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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        MySqlConnection sqlCon = null;
        String conn = "server=localhost;user=root;database=my1;port=3306;password=linh17423";

        DataTable dt = new DataTable();
        private void btnDetail_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(conn))
                {
                    // Mở kết nối
                    sqlCon.Open();

                    // Kiểm tra xem kết nối đã mở chưa
                    if (sqlCon.State == ConnectionState.Open)
                    {
                        // Tạo đối tượng MySqlCommand với câu lệnh SQL và kết nối
                        using (MySqlCommand cmd = new MySqlCommand("SELECT * from CLASS WHERE ClassID = @ClassID", sqlCon))
                        {
                            // Thêm tham số vào câu lệnh    
                            cmd.Parameters.AddWithValue("@ClassID", txtClassID.Text);

                            // Thực thi truy vấn và lấy kết quả
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    txtID.Text = reader["ClassID"].ToString();
                                    txtName.Text = reader["ClassName"].ToString();
                                    txtYear.Text = reader["Year"].ToString();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dt.Clear();
            using (MySqlConnection sqlConn = new MySqlConnection(conn))
            {
                sqlConn.Open();

                if (sqlConn.State == ConnectionState.Open)
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * from STUDENT where ClassID = @ClassID", sqlConn))
                    {
                        cmd.Parameters.AddWithValue("@ClassID", txtClassID.Text);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                    lsStudents.DataSource = dt;
                }
            }
        }
    }
}
