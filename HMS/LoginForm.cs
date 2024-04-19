using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;

namespace HMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit this application?", "Close Apllication", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try { 
            Homepage h = new Homepage();
            //db CONNECTION
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SI0VT1I;Initial Catalog=HMS;Integrated Security=True;Encrypt=False");
            conn.Open();
            SqlCommand comm = new SqlCommand("select * from Users WHERE Username = @Username AND Password = @Password", conn);
            comm.Parameters.AddWithValue("@Username", txtUsername.Text);
            comm.Parameters.AddWithValue("@Password", txtPassword.Text);
           var reader = comm.ExecuteReader();
            if (reader.Read())
            {
                this.Hide();
                h.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Login Failed!");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.Show();
            this.Hide();
        }
    }
}
