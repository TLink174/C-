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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection sqlCon = null;
        String conn = "server=localhost;user=root;database=my1;port=3306;password=linh17423";

        private void btnCaculate_Click(object sender, EventArgs e)
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
                        using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM STUDENT WHERE ClassID = @ClassID", sqlCon))
                        {
                            // Thêm tham số vào câu lệnh
                            cmd.Parameters.AddWithValue("@ClassID", txtClassID.Text);

                            // Thực thi truy vấn và lấy kết quả
                            int result = Convert.ToInt32(cmd.ExecuteScalar());
                            txtNumber.Text = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
