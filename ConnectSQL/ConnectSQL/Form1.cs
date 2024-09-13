using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using MySql.Data.MySqlClient;
namespace ConnectSQL
{
    public partial class Form1 : Form
    {

        /*IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "qcp9HThZoWwatKoQB5ct26Lk5TpxeXj1Fv0u2945",
            BasePath = "https://conn-c-sharp-default-rtdb.asia-southeast1.firebasedatabase.app/",
        };

        IFirebaseClient client;*/
        MySqlConnection sqlCon = null;
        String conn = "server=localhost;user=root;database=my1;port=3306;password=linh17423";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon = new MySqlConnection(conn);
                sqlCon.ConnectionString = conn;
                sqlCon.Open();
                /*string sql = "select * from student";
                MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show(reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2));
                }*/
                MessageBox.Show("Connected to MySQL!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private async void btnDisconn_Click(object sender, EventArgs e)
        {
            /*if (client != null)
            {
                try
                {
                    await client.DeleteTaskAsync(""); // Delete the root node to disconnect from Firebase
                    client = null;
                    MessageBox.Show("Disconnected from Firebase!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to disconnect from Firebase \n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Client is not connected to Firebase!");
            }*/
            if (sqlCon != null && sqlCon.State == System.Data.ConnectionState.Open)
            {
                sqlCon.Close();
                MessageBox.Show("Disconnected from MySQL!");
            }
        }
    }
}
