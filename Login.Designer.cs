namespace $safeprojectname$
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.exitBT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.changepasswordLB = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // UsernameTB
            // 
            this.UsernameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTB.Location = new System.Drawing.Point(211, 60);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(221, 29);
            this.UsernameTB.TabIndex = 2;
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(211, 107);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(221, 29);
            this.passwordTB.TabIndex = 3;
            // 
            // exitBT
            // 
            this.exitBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBT.Location = new System.Drawing.Point(273, 148);
            this.exitBT.Name = "exitBT";
            this.exitBT.Size = new System.Drawing.Size(93, 47);
            this.exitBT.TabIndex = 4;
            this.exitBT.Text = "Exit";
            this.exitBT.UseVisualStyleBackColor = true;
            this.exitBT.Click += new System.EventHandler(this.exitBT_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(385, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // changepasswordLB
            // 
            this.changepasswordLB.AutoSize = true;
            this.changepasswordLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changepasswordLB.Location = new System.Drawing.Point(351, 209);
            this.changepasswordLB.Name = "changepasswordLB";
            this.changepasswordLB.Size = new System.Drawing.Size(119, 16);
            this.changepasswordLB.TabIndex = 6;
            this.changepasswordLB.TabStop = true;
            this.changepasswordLB.Text = "Forget password ?";
            this.changepasswordLB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.changepasswordLB_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(505, 244);
            this.Controls.Add(this.changepasswordLB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitBT);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button exitBT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel changepasswordLB;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}