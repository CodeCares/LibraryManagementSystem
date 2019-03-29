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
    public partial class plan : Form
    {
        public plan()
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

            if (PlanNameTb.Text == "")
            {
                errorProvider1.SetError(PlanNameTb, "Type plan name");


            }
            else if (LimitTB.Text == "")
            {
                errorProvider1.SetError(LimitTB, "Type limit name");


            }
            else if (CreationDate.Text == "")
            {
                errorProvider1.SetError(CreationDate, "Type date of creation name");


            }
            else if (ValidityTb.Text == "")
            {
                errorProvider1.SetError(ValidityTb, "Type validity name");


            }
            else if (amountTb.Text == "")
            {
                errorProvider1.SetError(amountTb, "Type amount name");


            }
            else if (discountTB.Text == "")
            {
                errorProvider1.SetError(discountTB, "Type discount name");


            }
            else if (StausCb.Text == "")
            {
                errorProvider1.SetError(StausCb, "Sclete status active or inactive");


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

            if (PlanNameTb.Text == "")
            {
                errorProvider1.SetError(PlanNameTb, "Type plan name");


            }
            else if (LimitTB.Text == "")
            {
                errorProvider1.SetError(LimitTB, "Type limit name");


            }
            else if (CreationDate.Text == "")
            {
                errorProvider1.SetError(CreationDate, "Type date of creation name");


            }
            else if (ValidityTb.Text == "")
            {
                errorProvider1.SetError(ValidityTb, "Type validity name");


            }
            else if (amountTb.Text == "")
            {
                errorProvider1.SetError(amountTb, "Type amount name");


            }
            else if (discountTB.Text == "")
            {
                errorProvider1.SetError(discountTB, "Type discount name");


            }
            else if (StausCb.Text == "")
            {
                errorProvider1.SetError(StausCb, "Sclete status active or inactive");


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
            

            if (PlanNameTb.Text == "")
            {
                errorProvider1.SetError(PlanNameTb, "Type plan name");


            }
            else if (LimitTB.Text == "")
            {
                errorProvider1.SetError(LimitTB, "Type limit name");


            }
            else if (CreationDate.Text == "")
            {
                errorProvider1.SetError(CreationDate, "Type date of creation name");


            }
            else if (ValidityTb.Text == "")
            {
                errorProvider1.SetError(ValidityTb, "Type validity name");


            }
            else if (amountTb.Text == "")
            {
                errorProvider1.SetError(amountTb, "Type amount name");


            }
            else if (discountTB.Text == "")
            {
                errorProvider1.SetError(discountTB, "Type discount name");


            }
            else if (StausCb.Text == "")
            {
                errorProvider1.SetError(StausCb, "Sclete status active or inactive");


            }
            else
            {

                errorProvider1.Clear();
                double dis, amount;
                dis = Convert.ToDouble(discountTB.Text);
                amount = Convert.ToDouble(amountTb.Text);
                dis = amount * dis/100;
                discountTB.Text = Convert.ToString(dis);
                AddRecord();
                MessageBox.Show("The Record is Save Sussessfully...!");
                CreateNew();
                ViewGrid();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = dataGridView1.SelectedRows[0].Index;
            PlanIDtb.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            PlanNameTb.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            LimitTB.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            CreationDate.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            bookcanholdTb.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            ValidityTb.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            amountTb.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            discountTB.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            StausCb.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();

        }
        void CreateNew()
        {
            PlanIDtb.Clear();
            PlanNameTb.Clear();
            LimitTB.Clear();
            bookcanholdTb.Clear();
            ValidityTb.Clear();
            amountTb.Clear();
            discountTB.Clear();
            StausCb.SelectedIndex = -1;
            Rand();
           PlanNameTb.Focus();
        }
        void Rand()
        {
            Random r = new Random();
            int n = r.Next();
            PlanIDtb.Text = "P" + n.ToString();

        }
        void AddRecord()
        {
            try
            {
                Connection con = new Connection();
                MySqlCommand cmd = new MySqlCommand(@"INSERT INTO `lms`.`plan_master`
                (`plan_id`,
                `plan_name`,
                `plan_doc`,
                `plan_book_limit`,
                `plan_book_hold`,
                `plan_validity`,
                `plan_amount`,
                `plan_dis`,
                `plan_status`)
                VALUES
('"+PlanIDtb.Text+"','"+PlanNameTb.Text+"','"+CreationDate.Text+"','"+LimitTB.Text+"','"+bookcanholdTb.Text+"','"+ValidityTb.Text+"','"+amountTb.Text+"','"+discountTB.Text+"','"+StausCb.Text+"')", con.ActiveCon());
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
            MySqlCommand cmd = new MySqlCommand(@"UPDATE `lms`.`plan_master`
            SET
            `plan_name` = '" + PlanNameTb.Text + "',`plan_doc` ='"+CreationDate.Text+ "',`plan_book_limit` = '"+LimitTB.Text+ "',`plan_book_hold` = '"+bookcanholdTb.Text+ "',`plan_validity` = '"+ValidityTb.Text+ "',`plan_amount` = '"+amountTb.Text+ "',`plan_dis` = '"+discountTB.Text+ "',`plan_status` = '"+StausCb.Text+ "' WHERE `plan_id` = '"+PlanIDtb.Text+"'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
        void DeleteRecord()
        {
            Connection con = new Connection();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM  `lms`.`plan_master` WHERE `plan_id` = '" + PlanIDtb.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }

        void ViewGrid()
        {
            Connection con = new Connection();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM lms.plan_master;", con.ActiveCon());
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["plan_id"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["plan_name"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["plan_book_limit"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["plan_doc"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["plan_book_hold"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["plan_validity"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item["plan_amount"].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item["plan_dis"].ToString();
                dataGridView1.Rows[n].Cells[9].Value = item["plan_status"].ToString();
            }

            rawsCountlb.Text = dt.Rows.Count.ToString();

        }

        private void plan_Load(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
        }
    }
}
