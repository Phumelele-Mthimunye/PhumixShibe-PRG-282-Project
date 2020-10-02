using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UserInterfaceV2
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        public static string userName;
        public static string Password;
        private void btnRegisterSubmit_Click(object sender, EventArgs e)
        {
            if (txtRePassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Passwords do not match", "Please re-enter password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                userName = txtUserName.Text;
                Password = txtPassword.Text;
                //string connection = "Data Source=.;Initial Catalog=dbUni;Integrated Security=True";
                //SqlConnection conn = new SqlConnection(connection);
                //conn.Open();
                //string insert = "INSERT INTO Users (Username,Password) VALUES ( '" + txtUserName.Text + "','" + txtPassword.Text + "' )"; //allows input from an external control
                //SqlCommand cmd = new SqlCommand(insert, conn);
                //cmd.ExecuteNonQuery();
                //conn.Close();
                //MessageBox.Show("User Successfully Added");
                string connection = "Data Source=.;Initial Catalog=FlightSimulation;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                string insert = "INSERT INTO Users (username,Password) VALUES ('" + userName + "','" + Password+ "')"; //allows input from an external control
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("User Successfully Added");
                Login frm = new Login();
                frm.Show();
                this.Close();
                this.Hide();
                
            }
        }

        private void llForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
