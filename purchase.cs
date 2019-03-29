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
    public partial class purchase : Form
    {
        public purchase()
        {
            InitializeComponent();
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {

        }

        private void New_Click(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (regIdTb.Text == "")
            {
                errorProvider1.SetError(regIdTb, "Type Your purchase ID");


            }
            else if (MemIdTb.Text == "")
            {
                errorProvider1.SetError(MemIdTb, "Type your member id");


            }
            else if (bookIDTb.Text == "")
            {
                errorProvider1.SetError(bookIDTb, "Type your book ID");


            }
            else if (bookNameTb.Text == "")
            {
                errorProvider1.SetError(bookNameTb, "Type your Book Name");


            }
            else if (qtyTb.Text == "")
            {
                errorProvider1.SetError(qtyTb, "type your Qty  ");


            }
            else if (rateTb.Text == "")
            {
                errorProvider1.SetError(rateTb, "type your rate  ");


            }
            else if (statuscb.Text == "")
            {
                errorProvider1.SetError(statuscb, "Select active or inactive..!  ");


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

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (regIdTb.Text == "")
            {
                errorProvider1.SetError(regIdTb, "Type Your purchase ID");


            }
            else if (MemIdTb.Text == "")
            {
                errorProvider1.SetError(MemIdTb, "Type your member id");


            }
            else if (bookIDTb.Text == "")
            {
                errorProvider1.SetError(bookIDTb, "Type your book ID");


            }
            else if (bookNameTb.Text == "")
            {
                errorProvider1.SetError(bookNameTb, "Type your Book Name");


            }
            else if (qtyTb.Text == "")
            {
                errorProvider1.SetError(qtyTb, "type your Qty  ");


            }
            else if (rateTb.Text == "")
            {
                errorProvider1.SetError(rateTb, "type your rate  ");


            }
            else if (statuscb.Text == "")
            {
                errorProvider1.SetError(statuscb, "Select active or inactive..!  ");


            }
            else
            {
                errorProvider1.Clear();
                deleteRecord();
                ViewGrid();
                CreateNew();
                MessageBox.Show("The Record is Delete Sussessfully...!");

            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (regIdTb.Text == "")
            {
                errorProvider1.SetError(regIdTb, "Type Your purchase ID");


            }
            else if (MemIdTb.Text == "")
            {
                errorProvider1.SetError(MemIdTb, "Type your member id");


            }
            else if (bookIDTb.Text == "")
            {
                errorProvider1.SetError(bookIDTb, "Type your book ID");


            }
            else if (bookNameTb.Text == "")
            {
                errorProvider1.SetError(bookNameTb, "Type your Book Name");


            }
            else if (qtyTb.Text == "")
            {
                errorProvider1.SetError(qtyTb, "type your Qty  ");


            }
            else if (rateTb.Text == "")
            {
                errorProvider1.SetError(rateTb, "type your rate  ");


            }
            else if (statuscb.Text == "")
            {
                errorProvider1.SetError(statuscb, "Select active or inactive..!  ");


            }
            else
            {
                double qty,rate,amount;
                qty = Convert.ToDouble(qtyTb.Text);
                rate = Convert.ToDouble(rateTb.Text);
                amount = qty * rate;
                amountTb.Text = Convert.ToString(amount);

                errorProvider1.Clear();
                addRecord();
                ViewGrid();
                CreateNew();
                MessageBox.Show("The Record is Save Sussessfully...!");

            }
        }
        public void Rand()
        {
            Random r = new Random();
            int n = r.Next();
            regIdTb.Text = "P" + n.ToString();

        }
        public void CreateNew()
        {
            regIdTb.Clear();
            regdate.Refresh();
            MemIdTb.Clear();
            namelbl.Text = "";
            statuscb.SelectedIndex = -1;
            bookIDTb.Clear();
            bookNameTb.Clear();
            qtyTb.Clear();
            rateTb.Clear();
            amountTb.Clear();
            Rand();
            MemIdTb.Focus();
        }

        public void ViewGrid()
        {
            try
            {
                Connection con = new Connection();
                MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM lms.purchase_sub", con.ActiveCon());
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.Rows.Clear();
               double total = 0.0;
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item["pur_id"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["pur_date"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["mem_id"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item["mem_name"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item["book_id"].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item["book_name"].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item["qty"].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = item["rate"].ToString();
                    dataGridView1.Rows[n].Cells[9].Value = item["amount"].ToString();
                    dataGridView1.Rows[n].Cells[10].Value = item["status"].ToString();
                    total += Convert.ToDouble(dataGridView1.Rows[n].Cells[9].Value);

                }

                label10.Text = dt.Rows.Count.ToString();
                label12.Text = Convert.ToString(total);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void deleteRecord()
        {
            Connection con = new Connection();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `lms`.`purchase_sub`WHERE `pur_id` = '" + regIdTb.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
        public void updateRecord()
        {
            try
            {
                Connection con = new Connection();
                MySqlCommand cmd = new MySqlCommand(@"UPDATE `lms`.`purchase_sub`
                SET
                `pur_date` ='"+regdate.Text+ "',`mem_id` ='"+MemIdTb.Text+ "',`mem_name` ='"+namelbl.Text+ "',`book_id` ='"+bookIDTb.Text+ "',`book_name` ='"+bookNameTb.Text+ "',`qty` = '"+qtyTb.Text+ "',`rate` ='"+rateTb.Text+ "',`amount` = '"+amountTb.Text+ "',`status` ='"+statuscb.Text+ "'WHERE `pur_id` = '"+regIdTb.Text+"'", con.ActiveCon());
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
                MySqlCommand cmd = new MySqlCommand(@"INSERT INTO `lms`.`purchase_sub`
                (`pur_id`,
                `pur_date`,
                `mem_id`,
                `mem_name`,
                `book_id`,
                `book_name`,
                `qty`,
                `rate`,
                `amount`,
                `status`)
            VALUES
            ('" +regIdTb.Text+ "','" + regdate.Text + "','" + MemIdTb.Text + "','" + namelbl.Text + "','" + bookIDTb.Text+ "','"+bookNameTb.Text+ "','"+qtyTb.Text+ "','"+rateTb.Text+ "','"+amountTb.Text+ "','" + statuscb.Text + "')", con.ActiveCon());
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = dataGridView1.SelectedRows[0].Index;
            regIdTb.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            regdate.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            MemIdTb.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            namelbl.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            bookIDTb.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            bookNameTb.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            qtyTb.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            rateTb.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            amountTb.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            statuscb.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();

        }

        private void purchase_Load(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
        }

        private void MemIdTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Connection con = new Connection();
            MySqlCommand adp = new MySqlCommand("SELECT * FROM lms.member_master WHERE mem_id= '" + MemIdTb.Text + "'", con.ActiveCon());
            MySqlDataReader reader;
            reader = adp.ExecuteReader();
            if (reader.Read())
            {
           
                namelbl.Text = (reader["mem_name"].ToString());
            }
            reader.Close();

        }

        private void bookIDTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Connection con = new Connection();
            MySqlCommand adp1 = new MySqlCommand("SELECT * FROM lms.book_master WHERE book_id= '" + bookIDTb.Text + "'", con.ActiveCon());
            MySqlDataReader reader;
            reader = adp1.ExecuteReader();
            if (reader.Read())
            {
                bookNameTb.Text = (reader["book_name"].ToString());
                rateTb.Text = (reader["Price"].ToString());
            }
            reader.Close();
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
                using (FileStream stream = new FileStream(folderPath + "parchase.pdf", FileMode.Create))
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
