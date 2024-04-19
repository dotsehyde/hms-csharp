using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            try { 
            ///Registration Process
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            String conPassword = txtConPassword.Text;

            if (password.Length <= 0 || username.Length <= 0 || conPassword.Length <= 0)
            {
                MessageBox.Show("All fields are required", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (password != conPassword)
            {
                MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //db CONNECTION
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SI0VT1I;Initial Catalog=HMS;Integrated Security=True;Encrypt=False");
            conn.Open();
            SqlCommand comm = new SqlCommand("insert into Users (Username,Password) values (@Username,@Password)", conn);
            comm.Parameters.AddWithValue("@Username",username);
            comm.Parameters.AddWithValue ("@Password",password);
            comm.ExecuteNonQuery();
            MessageBox.Show("Registration successful");
            conn.Close();
            LoginForm l = new LoginForm();
            this.Close();
            l.Show();
        }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Close();
            lf.Show();
        }
    }
}
