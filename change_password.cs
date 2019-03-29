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
    public partial class change_password : Form
    {
        public change_password()
        {
            InitializeComponent();
        }
        void UpdateRecord()
        {
            Connection con = new Connection();
          MySqlCommand cmd = new MySqlCommand("UPDATE lms.profilemaster SET pro_password = '" + newpasswordTb.Text + "'WHERE profile_user_id = '" + userIDTB.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();

        }

        private void changebtn_Click(object sender, EventArgs e)
        {
            if (userIDTB.Text == "")
            {
                errorProvider1.SetError(userIDTB, "Type Your Usear ID");


            }
            else if (oldpasswordTb.Text == "")
            {
                errorProvider1.SetError(oldpasswordTb, "Type Your old password");


            }
            else if (newpasswordTb.Text == "")
            {
                errorProvider1.SetError(newpasswordTb, "Type Your new password");


            }
            else
            {
                Connection con = new Connection();
                MySqlDataAdapter adp = new MySqlDataAdapter("SELECT Count(*) FROM lms.profilemaster WHERE `profile_user_id` = '" + userIDTB.Text + "' AND `pro_password` = '" + oldpasswordTb.Text + "'", con.ActiveCon());
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    UpdateRecord();
                    MessageBox.Show("The password change sussessfully!!!!");
                    userIDTB.Clear();
                    oldpasswordTb.Clear();
                    newpasswordTb.Clear();
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(userIDTB, "Incorrect User ID");
                    errorProvider1.SetError(oldpasswordTb, "Incorrect Password");
                }
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            userIDTB.Clear();
            oldpasswordTb.Clear();
            newpasswordTb.Clear();
            errorProvider1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login ln = new Login();
            ln.Show();
            this.Hide();
        }
    }
}
