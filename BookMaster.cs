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
    public partial class BookMaster : Form
    {
        public BookMaster()
        {
            InitializeComponent();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = dataGridView1.SelectedRows[0].Index;
            BookIDTB.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            nameTb.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            authTb.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            editionTb.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            pagesTb.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            publish.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            SectionCB.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            RackCb.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            statusCb.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            pricetb.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();

        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            CreateNew();
            Rand();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (nameTb.Text == "")
            {
                errorProvider1.SetError(nameTb, "Type Your Name");


            }
            else if (authTb.Text == "")
            {
                errorProvider1.SetError(authTb, "Type your book authories");


            }
            else if (editionTb.Text == "")
            {
                errorProvider1.SetError(editionTb, "Type your Edition");


            }
            else if (pagesTb.Text == "")
            {
                errorProvider1.SetError(pagesTb, "Type your Address");


            }
            else if (pricetb.Text == "")
            {
                errorProvider1.SetError(publish, "Type your price ");


            }
            else if (publish.Text == "")
            {
                errorProvider1.SetError(publish, "Sclete publish date ");


            }
            else if (SectionCB.Text == "")
            {
                errorProvider1.SetError(SectionCB, "Sclete Sechtion Name");


            }
            else if (RackCb.Text == "")
            {
                errorProvider1.SetError(statusCb, "Sclete Rack Name");


            }
            else if (statusCb.Text == "")
            {
                errorProvider1.SetError(statusCb, "Sclete status active or inactive");


            }
            else
            {
                errorProvider1.Clear();
                updateRecord();
                CreateNew();
                ViewGrid();
                MessageBox.Show("The Record is Update Sussessfully...!");

            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (nameTb.Text == "")
            {
                errorProvider1.SetError(nameTb, "Type Your Name");


            }
            else if (authTb.Text == "")
            {
                errorProvider1.SetError(authTb, "Type your book authories");


            }
            else if (editionTb.Text == "")
            {
                errorProvider1.SetError(editionTb, "Type your Edition");


            }
            else if (pagesTb.Text == "")
            {
                errorProvider1.SetError(pagesTb, "Type your Address");


            }
            else if (publish.Text == "")
            {
                errorProvider1.SetError(publish, "Sclete publish date ");


            }
            else if (SectionCB.Text == "")
            {
                errorProvider1.SetError(SectionCB, "Sclete Sechtion Name");


            }
            else if (RackCb.Text == "")
            {
                errorProvider1.SetError(statusCb, "Sclete Rack Name");


            }
            else if (statusCb.Text == "")
            {
                errorProvider1.SetError(statusCb, "Sclete status active or inactive");


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

        private void SavaBtn_Click(object sender, EventArgs e)
        {
            if (nameTb.Text == "")
            {
                errorProvider1.SetError(nameTb, "Type Your Name");


            }
            else if (authTb.Text == "")
            {
                errorProvider1.SetError(authTb, "Type your book authories");


            }
            else if (editionTb.Text == "")
            {
                errorProvider1.SetError(editionTb, "Type your Edition");


            }
            else if (pagesTb.Text == "")
            {
                errorProvider1.SetError(pagesTb, "Type your Address");


            }
            else if (publish.Text == "")
            {
                errorProvider1.SetError(publish, "Sclete publish date ");


            }
            else if (SectionCB.Text == "")
            {
                errorProvider1.SetError(SectionCB, "Sclete Sechtion Name");


            }
            else if (RackCb.Text == "")
            {
                errorProvider1.SetError(statusCb, "Sclete Rack Name");


            }
            else if (statusCb.Text == "")
            {
                errorProvider1.SetError(statusCb, "Sclete status active or inactive");


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
        public void CreateNew()
        {
            BookIDTB.Clear();
            nameTb.Clear();
            authTb.Clear();
            editionTb.Clear();
            publish.Refresh();
            pagesTb.Clear();
            pricetb.Clear();
            SectionCB.SelectedIndex = -1;
            RackCb.SelectedIndex = -1;
            statusCb.SelectedIndex = -1;
            nameTb.Focus();

        }
        public void Rand()
        {
            Random r = new Random();
            int n = r.Next();
            BookIDTB.Text = "BK" + n.ToString();

        }
        public void ViewGrid()
        {
            Connection con = new Connection();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM `lms`.`book_master`", con.ActiveCon());
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["book_id"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["book_name"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["book_auth"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["book_edition"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["book_pages"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["book_publish"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item["sr_name"].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item["rack_name"].ToString();
                dataGridView1.Rows[n].Cells[9].Value = item["book_staus"].ToString();
                dataGridView1.Rows[n].Cells[10].Value = item["Price"].ToString();
            }

            rawsCountlb.Text = dt.Rows.Count.ToString();


        }
        public void deleteRecord()
        {
            Connection con = new Connection();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `lms`.`book_master` WHERE `book_id` = '" + BookIDTB.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }
        public void updateRecord()
        {
            Connection con = new Connection();
            MySqlCommand cmd = new MySqlCommand(@"UPDATE `lms`.`book_master`
            SET
            `book_name` = '" + nameTb.Text + "',`book_auth` = '" + authTb.Text + "',`book_edition` = '" + editionTb.Text + "',`book_pages` = '" + pagesTb.Text + "',`book_publish` = '" + publish.Text + "',`sr_name` = '" + SectionCB.Text + "',`rack_name` = '" + RackCb.Text + "', `book_staus` = '" + statusCb.Text + "',`Price`='"+pricetb.Text+"'WHERE `book_id` = '" + BookIDTB.Text + "'", con.ActiveCon());
            cmd.ExecuteNonQuery();
        }

        void addRecord()
        {
            try
            {

                Connection con = new Connection();
                MySqlCommand cmd = new MySqlCommand(@"INSERT INTO `lms`.`book_master`
            (`book_id`,
            `book_name`,
            `book_auth`,
            `book_edition`,
            `book_pages`,
            `book_publish`, 
            `sr_name`,
            `rack_name`,
            `book_staus`,
            `Price`)
            VALUES
            ('" + BookIDTB.Text + "','" + nameTb.Text + "','" + authTb.Text + "','" + editionTb.Text + "','" + pagesTb.Text + "','" + publish.Text + "','" + SectionCB.Text + "','" + RackCb.Text + "','" + statusCb.Text + "','"+pricetb.Text+"')", con.ActiveCon());
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BookMaster_Load(object sender, EventArgs e)
        {
            CreateNew();
            Rand();
            ViewGrid();
            Sectioncbox();
            rackCbox();
        }
        void Sectioncbox()
        {

            Connection con = new Connection();
            MySqlCommand adp = new MySqlCommand("SELECT sec_name FROM lms.section_master", con.ActiveCon());
            MySqlDataReader reader;
            reader = adp.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("sec_name", typeof(string));
            dt.Load(reader);
            SectionCB.ValueMember = "sec_name";
            SectionCB.DisplayMember = "sec_name";
            SectionCB.DataSource = dt;
        }
       public void rackCbox()
        {
            Connection con = new Connection();
            MySqlCommand adp = new MySqlCommand("SELECT rack_name FROM lms.rack_master;", con.ActiveCon());
            MySqlDataReader reader;
            reader = adp.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("rack_name", typeof(string));
            dt.Load(reader);
            RackCb.ValueMember = "rack_name";
            RackCb.DisplayMember = "rack_name";
            RackCb.DataSource = dt;

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
