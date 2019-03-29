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
using DGVPrinterHelper;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Reflection;


namespace $safeprojectname$
{
    public partial class member : Form
    {
        public member()
        {
            InitializeComponent();
        }

        private void member_Load(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
        }
        
        private void newBtn_Click(object sender, EventArgs e)
        {
            CreateNew();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
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
            else if (AddressRtb.Text == "")
            {
                errorProvider1.SetError(AddressRtb, "Type your Address");


            }
            else if (planCb.Text == "")
            {
                errorProvider1.SetError(planCb, "Sclete role ");


            }
            else if (statusCb.Text == "")
            {
                errorProvider1.SetError(statusCb, "Sclete status active or inactive");


            }
            else
            {
                errorProvider1.Clear();
                UpdateRecord();
                ViewGrid();
                MessageBox.Show("The Record is Update Sussessfully...!");

            }
          
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            DeleteRecord();
            ViewGrid();
            CreateNew();
            MessageBox.Show("The Record is Delete Sussessfully...!");
        }
        void Rand()
        {
            Random r = new Random();
            int n = r.Next();
            memberTB.Text = "M" + n.ToString();

        }

        public void CreateNew()
        {
            memberTB.Clear();
            nameTb.Clear();
            EmailTb.Clear();
            mobileTb.Clear();
            DateofBirth.Refresh();
            DateofJoin.Refresh();
            AddressRtb.Clear();
            planCb.SelectedIndex = -1;
            statusCb.SelectedIndex = -1;
            Rand();
            nameTb.Focus();

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
            else if (AddressRtb.Text == "")
            {
                errorProvider1.SetError(AddressRtb, "Type your Address");


            }
            else if (planCb.Text == "")
            {
                errorProvider1.SetError(planCb, "Sclete role ");


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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = dataGridView1.SelectedRows[0].Index;
            memberTB.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            nameTb.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            EmailTb.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            mobileTb.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            DateofBirth.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            DateofJoin.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            AddressRtb.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            planCb.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            statusCb.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
        }
        void ViewGrid()
        {
            Connection con = new Connection();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM `lms`.`member_master`", con.ActiveCon());
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["mem_id"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["mem_name"].ToString();             
                dataGridView1.Rows[n].Cells[3].Value = item["mem_email"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["mem_mobile"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["mem_dob"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["mem_doj"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item["mem_address"].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item["plan_id"].ToString();
                dataGridView1.Rows[n].Cells[9].Value = item["mem_status"].ToString();
            }

            rawsCountlb.Text = dt.Rows.Count.ToString();


        }
        void DeleteRecord()
        {
            Connection con = new Connection();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `lms`.`member_master` WHERE `mem_id` = '" + memberTB.Text + "' ", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
        void UpdateRecord()
        {
            Connection con = new Connection();
            MySqlCommand cmd = new MySqlCommand(@"UPDATE `lms`.`member_master`
                SET
                `mem_name` = '" + nameTb.Text + "',`mem_email` ='" + EmailTb.Text + "',`mem_mobile` = '" + mobileTb.Text + "',`mem_address` = '" + AddressRtb.Text + "',`mem_dob` = '" + DateofBirth.Text + "',`mem_doj`='"+DateofJoin.Text+"',`plan_id` = '" + planCb.Text + "',`mem_status` = '" + statusCb.Text + "'WHERE `mem_id` = '" + memberTB.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }

        void addRecord()
        {
            try
            {

                Connection con = new Connection();
                MySqlCommand cmd = new MySqlCommand(@"select*from member_master;INSERT INTO `lms`.`member_master`
            (`mem_id`,
            `mem_name`,
            `mem_email`,
            `mem_mobile`,
            `mem_address`,
            `mem_dob`,
            `mem_doj`,
            `plan_id`,
            `mem_status`)
            VALUES
            ('" + memberTB.Text + "','" + nameTb.Text + "','" + EmailTb.Text + "','" + mobileTb.Text + "','" + AddressRtb.Text + "','" + DateofBirth.Text + "','" + DateofJoin.Text + "','" + planCb.Text + "','" + statusCb.Text + "')", con.ActiveCon());
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            }

        private void printBtn_Click(object sender, EventArgs e)
        {


            ViewGrid();

            try
            {
                //Creating iTextSharp Table from the DataTable data
                PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 1;

                //Adding Header row
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                }

                //Adding DataRow
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                }


                //Exporting to PDF
                string folderPath = "C:\\PDFs\\";

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (FileStream stream = new FileStream(folderPath + "Member1.pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();

                }
                MessageBox.Show("The file saved PDF Format!!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
