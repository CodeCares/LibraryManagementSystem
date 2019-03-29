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
    public partial class member_transaction : Form
    {
        public member_transaction()
        {
            InitializeComponent();
        }

        private void SavaBtn_Click(object sender, EventArgs e)
        {
            if (memberNameTb.Text == "")
            {
                errorProvider1.SetError(memberNameTb, "Type Your Name");


            }
            else if (amountTb.Text == "")
            {
                errorProvider1.SetError(amountTb, "Type your amount");


            }
            else if (FineTb.Text == "")
            {
                errorProvider1.SetError(FineTb, "Type your Mobile");


            }
            else if (typeCb.Text == "")
            {
                errorProvider1.SetError(typeCb, "Sclete type ");


            }
            else if (StausCb.Text == "")
            {
                errorProvider1.SetError(StausCb, "Sclete status active or inactive");


            }
            else
            {
                errorProvider1.Clear();
                addRecord();
                ViewGrid();
                CreateNew();
                MessageBox.Show("The Record is Save Sussessfully...!");

            }

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = dataGridView1.SelectedRows[0].Index;
            TaransectionTB.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            taransectionDate.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            memberIdTb.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            memberNameTb.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            amountTb.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            FineTb.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            typeCb.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            dcBox.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            cardNumber.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            StausCb.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (memberNameTb.Text == "")
            {
                errorProvider1.SetError(memberNameTb, "Type Your Name");


            }
            else if (amountTb.Text == "")
            {
                errorProvider1.SetError(amountTb, "Type your amount");


            }
            else if (FineTb.Text == "")
            {
                errorProvider1.SetError(FineTb, "Type your Mobile");


            }
            else if (typeCb.Text == "")
            {
                errorProvider1.SetError(typeCb, "Sclete type ");


            }
            else if (StausCb.Text == "")
            {
                errorProvider1.SetError(StausCb, "Sclete status active or inactive");


            }
            else
            {
                errorProvider1.Clear();
                updateRecord();
                ViewGrid();
                CreateNew();
                MessageBox.Show("The Record is update Sussessfully...!");

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (memberNameTb.Text == "")
            {
                errorProvider1.SetError(memberNameTb, "Type Your Name");


            }
            else if (amountTb.Text == "")
            {
                errorProvider1.SetError(amountTb, "Type your amount");


            }
            else if (FineTb.Text == "")
            {
                errorProvider1.SetError(FineTb, "Type your Mobile");


            }
            else if (typeCb.Text == "")
            {
                errorProvider1.SetError(typeCb, "Sclete type ");


            }
            else if (StausCb.Text == "")
            {
                errorProvider1.SetError(StausCb, "Sclete status active or inactive");


            }
            else
            {
                errorProvider1.Clear();
                deleteRecord();
                ViewGrid();
                CreateNew();
                MessageBox.Show("The Record is delete Sussessfully...!");

            }
        }
        public void CreateNew()
        {
            TaransectionTB.Clear();
            memberIdTb.Clear();
            memberNameTb.Clear();
            taransectionDate.Refresh();
            amountTb.Clear();
            typeCb.SelectedIndex = -1;
            StausCb.SelectedIndex = -1;
            Rand();
            memberNameTb.Focus();

        }

        public void ViewGrid()
        {
            Connection con = new Connection();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM `lms`.`mem_transection`", con.ActiveCon());
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["transection_id"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["transection_date"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["mem_id"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["mem_name"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["amount"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["fine"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item["type"].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item["debitCredit"].ToString();
                dataGridView1.Rows[n].Cells[9].Value = item["card_number"].ToString();
                dataGridView1.Rows[n].Cells[10].Value = item["status"].ToString();
            }

            rawsCountlb.Text = dt.Rows.Count.ToString();


        }
        public void deleteRecord()
        {
            Connection con = new Connection();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `lms`.`mem_transection` WHERE `transection_id` ='" + TaransectionTB.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
        public void updateRecord()
        {
            try
            {
                Connection con = new Connection();
                MySqlCommand cmd = new MySqlCommand(@"UPDATE `lms`.`mem_transection`
SET
`transection_date` = '"+taransectionDate.Text+ "',`mem_id` = '"+memberIdTb.Text+ "',`mem_name` ='"+memberNameTb.Text+ "',`amount` ='"+amountTb.Text+ "',`fine` ='"+FineTb.Text+ "',`type` ='"+typeCb.Text+ "',`debitCredit` ='"+dcBox.Text+ "',`card_number` ='"+cardNumber.Text+ "',`status` ='"+StausCb.Text+ "'WHERE `transection_id` ='"+TaransectionTB.Text+"'", con.ActiveCon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void addRecord()
        {
            try
            {

                Connection con = new Connection();
                MySqlCommand cmd = new MySqlCommand(@"INSERT INTO `lms`.`mem_transection`
                (`transection_id`,
                `transection_date`,
                `mem_id`,
                `mem_name`,
                `amount`,
                `fine`,
                `type`,
                `debitCredit`,
                `card_number`,
                `status`)
            VALUES
            ('" + TaransectionTB.Text+"','" + taransectionDate.Text + "','" + memberIdTb.Text + "','" + memberNameTb.Text + "','" + amountTb.Text + "','" + FineTb.Text + "','"+ typeCb.Text + "','"+dcBox.Text+"','"+cardNumber.Text+"','"+ StausCb.Text +"')", con.ActiveCon());
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void Rand()
        {
            Random r = new Random();
            int n = r.Next();
            TaransectionTB.Text =n.ToString();

        }

        private void member_transaction_Load(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
            dcBox.Hide();
            cardNumber.Hide();
        }

        private void memberIdTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Connection con = new Connection();
            MySqlCommand adp = new MySqlCommand("SELECT * FROM lms.member_master WHERE mem_id= '" +memberIdTb.Text + "'", con.ActiveCon());
            MySqlDataReader reader;
            reader = adp.ExecuteReader();
            if (reader.Read())
            {
                
                memberNameTb.Text = (reader["mem_name"].ToString());
            }
            reader.Close();
        }
        

        private void typeCb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (typeCb.SelectedText == "Debit/Credit Card")
            {
                dcBox.Show();
                cardNumber.Show();
                if (dcBox.Text == "")
                {
                    errorProvider1.SetError(dcBox, "Sclete type ");


                }
                else if (cardNumber.Text == "")
                {
                    errorProvider1.SetError(StausCb, "Type your Card Number");

                }

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
                using (FileStream stream = new FileStream(folderPath + "MemberTransec.pdf", FileMode.Create))
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
