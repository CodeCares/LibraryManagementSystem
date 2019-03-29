namespace $safeprojectname$
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookInRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookOutRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberTransectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transectionReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.logoutLb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.inventryToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profleToolStripMenuItem,
            this.sectionToolStripMenuItem,
            this.memberToolStripMenuItem,
            this.planToolStripMenuItem,
            this.roleToolStripMenuItem,
            this.rackToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // profleToolStripMenuItem
            // 
            this.profleToolStripMenuItem.Name = "profleToolStripMenuItem";
            this.profleToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.profleToolStripMenuItem.Text = "Profile";
            this.profleToolStripMenuItem.Click += new System.EventHandler(this.profleToolStripMenuItem_Click);
            // 
            // sectionToolStripMenuItem
            // 
            this.sectionToolStripMenuItem.Name = "sectionToolStripMenuItem";
            this.sectionToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sectionToolStripMenuItem.Text = "Section";
            this.sectionToolStripMenuItem.Click += new System.EventHandler(this.sectionToolStripMenuItem_Click);
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.memberToolStripMenuItem.Text = "Member";
            this.memberToolStripMenuItem.Click += new System.EventHandler(this.memberToolStripMenuItem_Click);
            // 
            // planToolStripMenuItem
            // 
            this.planToolStripMenuItem.Name = "planToolStripMenuItem";
            this.planToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.planToolStripMenuItem.Text = "Plan";
            this.planToolStripMenuItem.Click += new System.EventHandler(this.planToolStripMenuItem_Click);
            // 
            // roleToolStripMenuItem
            // 
            this.roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            this.roleToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.roleToolStripMenuItem.Text = "Role";
            this.roleToolStripMenuItem.Click += new System.EventHandler(this.roleToolStripMenuItem_Click);
            // 
            // rackToolStripMenuItem
            // 
            this.rackToolStripMenuItem.Name = "rackToolStripMenuItem";
            this.rackToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.rackToolStripMenuItem.Text = "Rack";
            this.rackToolStripMenuItem.Click += new System.EventHandler(this.rackToolStripMenuItem_Click);
            // 
            // inventryToolStripMenuItem
            // 
            this.inventryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.bookInRegisterToolStripMenuItem,
            this.bookOutRegisterToolStripMenuItem,
            this.memberTransectionToolStripMenuItem,
            this.bookEntryToolStripMenuItem});
            this.inventryToolStripMenuItem.Name = "inventryToolStripMenuItem";
            this.inventryToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.inventryToolStripMenuItem.Text = "Inventry";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // bookInRegisterToolStripMenuItem
            // 
            this.bookInRegisterToolStripMenuItem.Name = "bookInRegisterToolStripMenuItem";
            this.bookInRegisterToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.bookInRegisterToolStripMenuItem.Text = "Book In Register";
            this.bookInRegisterToolStripMenuItem.Click += new System.EventHandler(this.bookInRegisterToolStripMenuItem_Click);
            // 
            // bookOutRegisterToolStripMenuItem
            // 
            this.bookOutRegisterToolStripMenuItem.Name = "bookOutRegisterToolStripMenuItem";
            this.bookOutRegisterToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.bookOutRegisterToolStripMenuItem.Text = "Book Out Register";
            this.bookOutRegisterToolStripMenuItem.Click += new System.EventHandler(this.bookOutRegisterToolStripMenuItem_Click);
            // 
            // memberTransectionToolStripMenuItem
            // 
            this.memberTransectionToolStripMenuItem.Name = "memberTransectionToolStripMenuItem";
            this.memberTransectionToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.memberTransectionToolStripMenuItem.Text = "Member Transection";
            this.memberTransectionToolStripMenuItem.Click += new System.EventHandler(this.memberTransectionToolStripMenuItem_Click);
            // 
            // bookEntryToolStripMenuItem
            // 
            this.bookEntryToolStripMenuItem.Name = "bookEntryToolStripMenuItem";
            this.bookEntryToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.bookEntryToolStripMenuItem.Text = "Book Entry";
            this.bookEntryToolStripMenuItem.Click += new System.EventHandler(this.bookEntryToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookReportsToolStripMenuItem,
            this.memberReportsToolStripMenuItem,
            this.transectionReportsToolStripMenuItem,
            this.purchaseReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // bookReportsToolStripMenuItem
            // 
            this.bookReportsToolStripMenuItem.Name = "bookReportsToolStripMenuItem";
            this.bookReportsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.bookReportsToolStripMenuItem.Text = "Book Reports";
            this.bookReportsToolStripMenuItem.Click += new System.EventHandler(this.bookReportsToolStripMenuItem_Click);
            // 
            // memberReportsToolStripMenuItem
            // 
            this.memberReportsToolStripMenuItem.Name = "memberReportsToolStripMenuItem";
            this.memberReportsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.memberReportsToolStripMenuItem.Text = "Member Reports";
            this.memberReportsToolStripMenuItem.Click += new System.EventHandler(this.memberReportsToolStripMenuItem_Click);
            // 
            // transectionReportsToolStripMenuItem
            // 
            this.transectionReportsToolStripMenuItem.Name = "transectionReportsToolStripMenuItem";
            this.transectionReportsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.transectionReportsToolStripMenuItem.Text = "Transection Reports";
            this.transectionReportsToolStripMenuItem.Click += new System.EventHandler(this.transectionReportsToolStripMenuItem_Click);
            // 
            // purchaseReportsToolStripMenuItem
            // 
            this.purchaseReportsToolStripMenuItem.Name = "purchaseReportsToolStripMenuItem";
            this.purchaseReportsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.purchaseReportsToolStripMenuItem.Text = "Purchase Reports";
            this.purchaseReportsToolStripMenuItem.Click += new System.EventHandler(this.purchaseReportsToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.DarkSeaGreen;
            // 
            // logoutLb
            // 
            this.logoutLb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutLb.AutoSize = true;
            this.logoutLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLb.ForeColor = System.Drawing.Color.Maroon;
            this.logoutLb.Location = new System.Drawing.Point(503, 4);
            this.logoutLb.Name = "logoutLb";
            this.logoutLb.Size = new System.Drawing.Size(23, 18);
            this.logoutLb.TabIndex = 4;
            this.logoutLb.Text = "...";
            this.logoutLb.Click += new System.EventHandler(this.logoutLb_Click);
            this.logoutLb.MouseHover += new System.EventHandler(this.logoutLb_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(474, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 91);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Exit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logout ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Log as ";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logoutLb);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "User";
            this.Text = "Library Management System";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.LightGreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.User_FormClosed);
            this.Load += new System.EventHandler(this.User_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookInRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookOutRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberTransectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rackToolStripMenuItem;
        private System.Windows.Forms.Label logoutLb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem bookReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transectionReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookEntryToolStripMenuItem;
    }
}



