using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace $safeprojectname$
{
    public partial class Login : Form
    {
      //  MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=123456;database=lms");
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UsernameTB.Text == "")
            {
                errorProvider1.SetError(UsernameTB, "Type Your User Name");


            }
            else if (passwordTB.Text == "")
            {
                errorProvider1.SetError(passwordTB, "Type Your password");


            }
            else
            {

                Connection con = new Connection();
                MySqlCommand cmd = new MySqlCommand("Select * From profileMaster where  profile_user_id='" + UsernameTB.Text + "' and pro_password='" + passwordTB.Text + "'", con.ActiveCon());
                //con.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    User lms = new User(dt.Rows[0][0].ToString());
                    lms.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Invalid User Name or Password....!", "Alart", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //con.Close();
            }
        } 

        private void exitBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changepasswordLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            change_password cp = new change_password();
           
            cp.StartPosition = FormStartPosition.CenterScreen;
            cp.Show();
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
