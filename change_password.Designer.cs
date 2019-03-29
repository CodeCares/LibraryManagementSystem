namespace $safeprojectname$
{
    partial class change_password
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
            this.label3 = new System.Windows.Forms.Label();
            this.userIDTB = new System.Windows.Forms.TextBox();
            this.oldpasswordTb = new System.Windows.Forms.TextBox();
            this.newpasswordTb = new System.Windows.Forms.TextBox();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.changebtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Old password : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password :";
            // 
            // userIDTB
            // 
            this.userIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDTB.Location = new System.Drawing.Point(163, 45);
            this.userIDTB.Name = "userIDTB";
            this.userIDTB.Size = new System.Drawing.Size(232, 26);
            this.userIDTB.TabIndex = 3;
            // 
            // oldpasswordTb
            // 
            this.oldpasswordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldpasswordTb.Location = new System.Drawing.Point(163, 81);
            this.oldpasswordTb.Name = "oldpasswordTb";
            this.oldpasswordTb.PasswordChar = '*';
            this.oldpasswordTb.Size = new System.Drawing.Size(232, 26);
            this.oldpasswordTb.TabIndex = 4;
            // 
            // newpasswordTb
            // 
            this.newpasswordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpasswordTb.Location = new System.Drawing.Point(163, 116);
            this.newpasswordTb.Name = "newpasswordTb";
            this.newpasswordTb.PasswordChar = '*';
            this.newpasswordTb.Size = new System.Drawing.Size(232, 26);
            this.newpasswordTb.TabIndex = 5;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.Location = new System.Drawing.Point(229, 169);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 34);
            this.Cancelbtn.TabIndex = 6;
            this.Cancelbtn.Text = "Clear";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // changebtn
            // 
            this.changebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changebtn.Location = new System.Drawing.Point(320, 169);
            this.changebtn.Name = "changebtn";
            this.changebtn.Size = new System.Drawing.Size(75, 34);
            this.changebtn.TabIndex = 7;
            this.changebtn.Text = "Change";
            this.changebtn.UseVisualStyleBackColor = true;
            this.changebtn.Click += new System.EventHandler(this.changebtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::$safeprojectname$.Properties.Resources.back1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 34);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // change_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(443, 215);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.changebtn);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.newpasswordTb);
            this.Controls.Add(this.oldpasswordTb);
            this.Controls.Add(this.userIDTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "change_password";
            this.Text = "change_password";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userIDTB;
        private System.Windows.Forms.TextBox oldpasswordTb;
        private System.Windows.Forms.TextBox newpasswordTb;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button changebtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
    }
}