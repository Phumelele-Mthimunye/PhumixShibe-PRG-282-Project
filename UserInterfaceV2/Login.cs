using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using System.IO;

namespace UserInterfaceV2
{
    public partial class Login : Form
    {
        public string connection = "Data Source=.;Initial Catalog=FlightSimulation;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        DataHandler dh = new DataHandler();
        List<Player> user = new List<Player>();
        List<Player> temp = new List<Player>();
        public static string userName;
        public static DateTime startTime;


        private void Login_Load(object sender, EventArgs e)
        {

        }

        public void Profile()
        {
            user = dh.UserRead();//Reads user from Database

                //foreach (var row in user)
                //{
                //    if (txtUserName.Text == row.UserName.Trim())
                //    {
                //        pictureBox1.Image = row.Image;
                //    }
                //}
        }
        private void btnLoginSubmit_Click(object sender, EventArgs e)
        {
            user = dh.UserRead();
            bool validLog = false;
            try
            {
                foreach (var row in user)
                {
                    if (txtUserName.Text == row.UserName.Trim() && txtPassword.Text == row.Password.Trim())
                    {
                        userName = txtUserName.Text;
                        startTime = DateTime.Now;
                        Game gamefrm = new Game();
                        gamefrm.Show();
                        this.Visible = false;
                        validLog = true;
                        break;
                    }
                }
                if (!validLog)
                {
                    throw new MyException("Invalid username and password combination");
                }
            }
            catch (MyException mx)
            {
                MessageBox.Show(mx.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void llNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register regfrm = new Register();
            regfrm.Show();
            this.Hide();
        }

        
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
         //   Profile();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            Profile();
            Thread t1 = new Thread(() =>
            {
                if(txtUserName.Text == null || txtUserName.Text == string.Empty)
                {
                    pictureBox1.Image = UserInterfaceV2.Resource1._20c58df99c;
                }
            });
            t1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
