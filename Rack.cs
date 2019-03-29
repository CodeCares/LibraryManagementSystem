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
    public partial class Rack : Form
    {
        public Rack()
        {
            InitializeComponent();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (RacknameTb.Text == "")
            {
                errorProvider1.SetError(RacknameTb, "Type rack name");


            }
            else if (statusCb.Text == "")
            {
                errorProvider1.SetError(statusCb, "Sclete status active or inactive");


            }
            else
            {
                errorProvider1.Clear();
                UpdateRecord();
                MessageBox.Show("The Record is Update Sussessfully...!");
                CreateNew();
                ViewGrid();
            }
            
           
        }
        
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (RacknameTb.Text == "")
            {
                errorProvider1.SetError(RacknameTb, "Type rack name");


            }
            else if (statusCb.Text == "")
            {
                errorProvider1.SetError(statusCb, "Sclete status active or inactive");


            }
            else
            {
                errorProvider1.Clear();
                DeleteRecord();
                MessageBox.Show("The Record is Delete Sussessfully...!");
                CreateNew();
                ViewGrid();
            }
            
        }

        private void SavaBtn_Click(object sender, EventArgs e)
        {
            if (RacknameTb.Text == "")
            {
                errorProvider1.SetError(RacknameTb, "Type rack name");


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
        void CreateNew()
        {
            RackIDTB.Clear();
            RacknameTb.Clear();
            statusCb.SelectedIndex = -1;
            Rand();
            RacknameTb.Focus();


        }
        void Rand()
        {
            Random r = new Random();
            int n = r.Next();
            RackIDTB.Text =n.ToString();

        }
        void AddRecord()
        {
            try
            {
                Connection con = new Connection();
                MySqlCommand cmd = new MySqlCommand("select*from `lms`.`rack_master`;INSERT INTO `lms`.`rack_master`(`rack_id`,`rack_name`,`rack_status`)VALUES('" + RackIDTB.Text +"','" +RacknameTb.Text + "','" + statusCb.Text + "')", con.ActiveCon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void UpdateRecord()
        {
            Connection con = new Connection();
            MySqlCommand cmd = new MySqlCommand(@"UPDATE `lms`.`rack_master`
            SET
            `rack_name` = '" + RacknameTb.Text + "',`rack_status` = '" + statusCb.Text + "' WHERE `rack_id` = '" + RackIDTB.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
        void DeleteRecord()
        {
            Connection con = new Connection();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM  `lms`.`rack_master` WHERE `rack_id` = '" + RackIDTB.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }


        void ViewGrid()
        {
            Connection con = new Connection();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM `lms`.`rack_master`", con.ActiveCon());
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["rack_id"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["rack_name"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["rack_status"].ToString();
            }

            rawsCountlb.Text = dt.Rows.Count.ToString();

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = dataGridView1.SelectedRows[0].Index;
            RackIDTB.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            RacknameTb.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            statusCb.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void Rack_Load(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
        }
    }
}
