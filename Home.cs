using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            BookMaster bm = new BookMaster();
            bm.MdiParent = MdiParent;
            bm.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            
            profile pro = new profile();
            pro.MdiParent = MdiParent;
            pro.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            member mem = new member();
            mem.MdiParent = MdiParent;
            mem.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

            BookReports bookRe = new BookReports();
            bookRe.MdiParent = MdiParent;
            bookRe.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MemberReports MemR = new MemberReports();
            MemR.MdiParent = MdiParent;
            MemR.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

            PurchaseReports pr = new PurchaseReports();
            pr.MdiParent = MdiParent;
            pr.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            TransectionReports tr = new TransectionReports();
            tr.MdiParent = MdiParent;
            tr.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            panel5.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            panel5.Hide();
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0,0);
            this.Size = new Size(w,h);
        }

        private void Home_MouseClick(object sender, MouseEventArgs e)
        {
            panel5.Hide();
        }
    }
}
