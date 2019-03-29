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
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            CreateNew();
            Rand();
            
        }

        public void CreateNew() {
            profileIdTB.Clear();
            nameTb.Clear();
            EmailTb.Clear();
            mobileTb.Clear();
            psswordTb.Clear();
            AddressRtb.Clear();
            roleCb.SelectedIndex = -1;
            statusCb.SelectedIndex = -1;
            Rand();
            nameTb.Focus();

        }
        void Rand()
        {
            Random r = new Random();
            int n = r.Next();
            profileIdTB.Text = "$safeprojectname$" + n.ToString();

        }

        private void profile_Load(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
        }

        private void SavaBtn_Click(object sender, EventArgs e)
        {
            if (nameTb.Text == "")
            {
                errorProvider1.SetError(nameTb, "Type Your Name");


            }
            else if (EmailTb.Text == "")
            {
                errorProvider1.SetError(EmailTb, "Type your Email");


            }
            else if (mobileTb.Text == "")
            {
                errorProvider1.SetError(mobileTb, "Type your Mobile");


            }
            else if (psswordTb.Text == "")
            {
                errorProvider1.SetError(psswordTb, "Type your Password");


            }
            else if (AddressRtb.Text == "")
            {
                errorProvider1.SetError(AddressRtb, "Type your Address");


            }
            else if (roleCb.Text == "")
            {
                errorProvider1.SetError(roleCb, "Sclete role ");


            }
            else if (statusCb.Text == "")
            {
                errorProvider1.SetError(statusCb, "Sclete status active or inactive");


            }
            else
            {
                errorProvider1.Clear();
                addRecord();
                MessageBox.Show("The Record is Save Sussessfully...!");
                CreateNew();
                ViewGrid();
            }
        }

        void addRecord() {

            Connection con = new Connection();
            MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM lms.profilemaster;INSERT INTO `lms`.`profilemaster`
            (`profile_user_id`,
            `pro_name`,
            `pro_email`,
            `pro_mobile`,
            `pro_password`,
            `pro_address`,
            `pro_role`,
            `por_status`)
            VALUES
            ('" + profileIdTB.Text + "','" + nameTb.Text + "','" + EmailTb.Text + "','" + mobileTb.Text + "','" + psswordTb.Text + "','" + AddressRtb.Text + "','" + roleCb.Text + "','" + statusCb.Text + "')", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }

        void ViewGrid()
        {
            Connection con = new Connection();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM lms.profilemaster", con.ActiveCon());
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["profile_user_id"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["pro_name"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["pro_address"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["pro_email"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["pro_mobile"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["pro_password"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item["pro_role"].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item["por_status"].ToString();
            }

            rawsCountlb.Text = dt.Rows.Count.ToString();


        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = dataGridView1.SelectedRows[0].Index;
            profileIdTB.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            nameTb.Text= dataGridView1.Rows[i].Cells[2].Value.ToString();
            AddressRtb.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            EmailTb.Text= dataGridView1.Rows[i].Cells[4].Value.ToString();
            mobileTb.Text= dataGridView1.Rows[i].Cells[5].Value.ToString();
            psswordTb.Text= dataGridView1.Rows[i].Cells[6].Value.ToString();
            roleCb.Text= dataGridView1.Rows[i].Cells[7].Value.ToString();
            statusCb.Text= dataGridView1.Rows[i].Cells[8].Value.ToString();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateRecord();
            ViewGrid();
            MessageBox.Show("The Record is Update Sussessfully...!");
        }

        void UpdateRecord()
        {
            Connection con = new Connection();
            MySqlCommand cmd = new MySqlCommand(@"UPDATE `lms`.`profilemaster`
                SET
                `pro_name` = '"+nameTb.Text+"',`pro_email` ='"+EmailTb.Text+"',`pro_mobile` = '"+mobileTb.Text+"',`pro_password` = '"+psswordTb.Text+"',`pro_address` = '"+AddressRtb.Text+"',`pro_role` = '"+roleCb.Text+"',`por_status` = '"+statusCb.Text+"'WHERE `profile_user_id` = '"+profileIdTB.Text+"'",con.ActiveCon());
            cmd.ExecuteNonQuery();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteRecord();
            ViewGrid();
            CreateNew();
            MessageBox.Show("The Record is Delete Sussessfully...!");
        }


        void DeleteRecord()
        {
            Connection con = new Connection();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM lms.profilemaster WHERE `profile_user_id` = '" + profileIdTB.Text + "' ", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
    }

}
