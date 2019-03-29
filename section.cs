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
    public partial class section : Form
    {
        public section()
        {
            InitializeComponent();
        }

        private void section_Load(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateRecord();
            ViewGrid();
            MessageBox.Show("The Record is Update Sussessfully...!");

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = dataGridView1.SelectedRows[0].Index;
            SecdTB.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            ScenameTb.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            statusCb.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();

        }


        //start
        

        void CreateNew()
        {
            SecdTB.Clear();
            ScenameTb.Clear();
            statusCb.SelectedIndex = -1;
            Rand();
            ScenameTb.Focus();


        }
        void Rand()
        {
            Random r = new Random();
            int n = r.Next();
            SecdTB.Text =n.ToString();

        }

        

        void AddRecord()
        {
            try
            {
                Connection con = new Connection();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `lms`.`section_master`(`sec_id`,`sec_name`,`sec_status`)VALUES('" + SecdTB.Text + "','" + ScenameTb.Text + "','" + statusCb.Text + "')", con.ActiveCon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        void UpdateRecord()
        {
            Connection con = new Connection();
            MySqlCommand cmd = new MySqlCommand(@"UPDATE `lms`.`section_master`
            SET
            `sec_name` = '"+ScenameTb.Text+"',`sec_status` = '"+statusCb.Text+"' WHERE `sec_id` = '"+SecdTB.Text+"'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
        void DeleteRecord()
        {
            Connection con = new Connection();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM  `lms`.`section_master` WHERE `sec_id` = '" + SecdTB.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }

        
        void ViewGrid()
        {
            Connection con = new Connection();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM `lms`.`section_master`", con.ActiveCon());
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["sec_id"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["sec_name"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["sec_status"].ToString();
            }

            rawsCountlb.Text = dt.Rows.Count.ToString();

        }

        private void newBtn_Click_1(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
        }

        private void SavaBtn_Click_1(object sender, EventArgs e)
        {
            if (ScenameTb.Text == "")
            {
                errorProvider1.SetError(ScenameTb, "Type Section name");


            }
            else if (statusCb.Text == "")
            {
                errorProvider1.SetError(statusCb, "Sclete status active or inactive");


            }
            else
            {
                errorProvider1.Clear();
                AddRecord();
                MessageBox.Show("The Record is Save Sussessfully...!");
                CreateNew();
                ViewGrid();
            }
        }

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            DeleteRecord();
            ViewGrid();
            CreateNew();
            MessageBox.Show("The Record is Delete Sussessfully...!");
        }
    }
}
