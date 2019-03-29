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
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
        }

        void CreateNew() {
            RoleIDTB.Clear();
            RolenameTb.Clear();
            statusCb.SelectedIndex = -1;
            Rand();
            RolenameTb.Focus();


        }
        void Rand() {
            Random r = new Random();
            int n = r.Next();
            RoleIDTB.Text = "BK" + n.ToString();

        }

        private void SavaBtn_Click(object sender, EventArgs e)
        {
            if (RolenameTb.Text == "")
            {
                errorProvider1.SetError(RolenameTb,"Type role name");
                

            }else if (statusCb.Text == "")
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

        void AddRecord()
        { 
            Connection con = new Connection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO lms.role_master (role_id,role,role_status)VALUE('" + RoleIDTB.Text + "','" + RolenameTb.Text + "','" + statusCb.Text + "')", con.ActiveCon());
            cmd.ExecuteNonQuery();    
          
            
        }

        void UpdateRecord()
        {
            Connection con = new Connection();
            MySqlCommand cmd = new MySqlCommand(@"UPDATE lms.role_master
                SET
                role = '" + RolenameTb.Text + "',role_status = '" + statusCb.Text + "'WHERE role_id = '" + RoleIDTB.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
         void DeleteRecord()
        {
                Connection con = new Connection();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM lms.role_master WHERE role_id = '" + RoleIDTB.Text + "'", con.ActiveCon());
                cmd.ExecuteNonQuery();
         }

        private void Role_Load(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
        }

        void ViewGrid() {
            Connection con = new Connection();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM lms.role_master", con.ActiveCon());
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows) {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = (n+1).ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["role_id"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["role"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["role_status"].ToString();
            }

            Countlb.Text = dt.Rows.Count.ToString();

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = dataGridView1.SelectedRows[0].Index;
            RoleIDTB.Text= dataGridView1.Rows[i].Cells[1].Value.ToString();
            RolenameTb.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            statusCb.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateRecord();
            ViewGrid();
            MessageBox.Show("The Record is Update Sussessfully...!");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteRecord();
            ViewGrid();
            CreateNew();
            MessageBox.Show("The Record is Delete Sussessfully...!");
        }
    }
}
