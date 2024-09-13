namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            lblShow.Text = txtPass.Text;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lblShow.Text = "";
            txtPass.Clear();
            txtPass.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
