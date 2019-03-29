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
    public partial class book_out_register : Form
    {
        public book_out_register()
        {
            InitializeComponent();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = dataGridView1.SelectedRows[0].Index;
            MemIdTb.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            memNameTb.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            bookIDTb.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            bookNameTb.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            qtyTb.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            fineTb.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            statuscb.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
        }

        private void New_Click(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

            if (MemIdTb.Text == "")
            {
                errorProvider1.SetError(MemIdTb, "Type Your member ID");


            }
            else if (memNameTb.Text == "")
            {
                errorProvider1.SetError(memNameTb, "Type your member name");


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
            else if (fineTb.Text == "")
            {
                errorProvider1.SetError(fineTb, "type your fine  ");


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
                MessageBox.Show("The Record is Update Sussessfully...!");

            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

            if (MemIdTb.Text == "")
            {
                errorProvider1.SetError(MemIdTb, "Type Your member ID");


            }
            else if (memNameTb.Text == "")
            {
                errorProvider1.SetError(memNameTb, "Type your member name");


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
            else if (fineTb.Text == "")
            {
                errorProvider1.SetError(fineTb, "type your fine  ");


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
            if (MemIdTb.Text == "")
            {
                errorProvider1.SetError(MemIdTb, "Type Your member ID");


            }
            else if (memNameTb.Text == "")
            {
                errorProvider1.SetError(memNameTb, "Type your member name");


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
            else if (fineTb.Text == "")
            {
                errorProvider1.SetError(fineTb, "type your fine  ");


            }
            else if (statuscb.Text == "")
            {
                errorProvider1.SetError(statuscb, "Select active or inactive..!  ");


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

        private void viewbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connection con = new Connection();
                MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM `lms`.`bookregister_sub`WHERE mem_id='" + textBox3.Text + "'OR book_id='" + textBox3.Text + "'", con.ActiveCon());
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dataGridView1.Rows.Clear();
                if(dt.Rows[1][1].ToString()==textBox3.Text || dt.Rows[3][3].ToString()==textBox3.Text)
                { 
                    foreach (DataRow item in dt.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item["mem_id"].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item["mem_name"].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item["book_id"].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = item["book_name"].ToString();
                        dataGridView1.Rows[n].Cells[5].Value = item["br_in_date"].ToString();
                        dataGridView1.Rows[n].Cells[6].Value = item["br_qty"].ToString();
                        dataGridView1.Rows[n].Cells[6].Value = item["br_fine"].ToString();
                        dataGridView1.Rows[n].Cells[6].Value = item["br_status"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Type again member id or book id");
                    ViewGrid();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MemIdTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Connection con = new Connection();
            MySqlCommand adp = new MySqlCommand("SELECT * FROM lms.member_master WHERE mem_id= '" +MemIdTb.Text + "'", con.ActiveCon());
            MySqlDataReader reader;
            reader = adp.ExecuteReader();
            if (reader.Read())
            {
                // memIdTb.Text = (reader["mem_id"].ToString());
                memNameTb.Text = (reader["mem_name"].ToString());
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
            }
            reader.Close();
        }
        public void CreateNew()
        {
            MemIdTb.Clear();
            memNameTb.Clear();
            bookIDTb.Clear();
            bookNameTb.Clear();
            dateTimePicker1.Refresh();
            qtyTb.Clear();
            MemIdTb.Focus();

        }

        public void ViewGrid()
        {
            Connection con = new Connection();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM `lms`.`bookregister_sub`", con.ActiveCon());
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["mem_id"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["mem_name"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["book_id"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["book_name"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["br_out_date"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["bot_qty"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item["br_fine"].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item["br_status"].ToString();
            }

            label10.Text = dt.Rows.Count.ToString();


        }
        public void deleteRecord()
        {
            Connection con = new Connection();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `lms`.`bookregister_sub`WHERE `mem_id`='" +MemIdTb.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
        public void updateRecord()
        {
            try
            {
                Connection con = new Connection();
                MySqlCommand cmd = new MySqlCommand(@"UPDATE `lms`.`bookregister_sub`
            SET
            `mem_name` ='" + memNameTb.Text + "',`book_id` ='" +bookIDTb.Text + "',`book_name`='" + bookNameTb.Text + "',`br_out_date` ='" + dateTimePicker1.Text + "',`bot_qty` ='" + qtyTb.Text + "',`br_fine` ='"+fineTb.Text+"',`br_status` ='"+statuscb.Text+"'WHERE `mem_id` ='" +MemIdTb.Text + "'", con.ActiveCon());
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
                MySqlCommand cmd = new MySqlCommand(@"INSERT INTO `lms`.`bookregister_sub`
               (
                `mem_id`,
                `mem_name`,
                `book_id`,
                `book_name`,
                `br_out_date`,
                `bot_qty`,
                `br_fine`,
                `br_status`
               )
            VALUES
            ('" + MemIdTb.Text + "','" + memNameTb.Text + "','" +bookIDTb.Text + "','" + bookNameTb.Text + "','" + dateTimePicker1.Text + "','" + qtyTb.Text + "','"+fineTb.Text+"','"+statuscb.Text+"')", con.ActiveCon());
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void book_out_register_Load(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
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
                using (FileStream stream = new FileStream(folderPath + "BKOUTReg1.pdf", FileMode.Create))
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
