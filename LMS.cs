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
    public partial class User : Form
    {
       

        public User(string role)
        {
            InitializeComponent();
            logoutLb.Text = role;
            
        }

        private void profleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profile pro = new profile();
            
            pro.MdiParent = this;
            pro.StartPosition = FormStartPosition.CenterScreen;
            pro.Show();
        }

        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            section sec = new section();
            
            sec.MdiParent = this;
            sec.StartPosition = FormStartPosition.CenterScreen;
            sec.Show();
        }

        
        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            member mem = new member();
            
            mem.MdiParent = this;
            mem.StartPosition = FormStartPosition.CenterScreen;
            mem.Show();
        }

        private void planToolStripMenuItem_Click(object sender, EventArgs e)
        {
            plan pl = new plan();
            
            pl.MdiParent = this;
            pl.StartPosition = FormStartPosition.CenterScreen;
            pl.Show();
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role ro = new Role();
            
            ro.MdiParent = this;
            ro.Show();
            
        }

        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchase pur = new purchase();
            
            pur.MdiParent = this;
            pur.StartPosition = FormStartPosition.CenterScreen;
            pur.Show();
        }

        private void bookInRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_in_register bir = new Book_in_register();
            
            bir.MdiParent = this;
            bir.Show();
        }

        private void bookOutRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            book_out_register bor = new book_out_register();
            
            bor.MdiParent = this;
            bor.StartPosition = FormStartPosition.CenterScreen;
            bor.Show();
        }

        private void memberTransectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            member_transaction mt = new member_transaction();
            
            mt.MdiParent = this;
            mt.StartPosition = FormStartPosition.CenterScreen;
            mt.Show();
        }

        private void rackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rack ra = new Rack();
            
            ra.MdiParent = this;
            ra.StartPosition = FormStartPosition.CenterScreen;
            ra.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            change_password cp = new change_password();
            cp.MdiParent = this;
            cp.StartPosition = FormStartPosition.CenterScreen;
            cp.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You want to LOGOUT???", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login log = new Login();
                log.Show();
                this.Hide();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void User_Load(object sender, EventArgs e)
        {
            logoutLb.Text = Controls["logoutLb"].Text;
            if (this.Controls["logoutLb"].Text != "Admin")
            {
                inventryToolStripMenuItem.Enabled = false;
                profleToolStripMenuItem.Enabled = false;
            }
            
            this.panel1.Hide();

            Home h = new Home();
            h.MdiParent = this;
            h.WindowState = FormWindowState.Maximized;
            h.Show();

        }

        private void logoutLb_MouseHover(object sender, EventArgs e)
        {
           
            this.panel1.Show();
            
        }

        private void logoutLb_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void bookEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookMaster bm = new BookMaster();
            bm.MdiParent = this;
            bm.StartPosition = FormStartPosition.WindowsDefaultLocation;
            bm.Show();
        }

        private void bookReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookReports bookRe = new BookReports();
            bookRe.MdiParent = this;
            bookRe.StartPosition = FormStartPosition.WindowsDefaultLocation;
            bookRe.Show();
        }

        private void memberReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberReports MemR = new MemberReports();
            MemR.MdiParent = this;
            MemR.StartPosition = FormStartPosition.CenterParent;
            MemR.Show();
        }

        private void transectionReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransectionReports tr = new TransectionReports();
            tr.MdiParent = this;
            tr.StartPosition = FormStartPosition.CenterParent;
            tr.Show();
        }

        private void purchaseReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseReports pr = new PurchaseReports();
            pr.MdiParent = this;
            pr.StartPosition = FormStartPosition.CenterParent;
            pr.Show();
        }
    }

}
