namespace AD_coursework
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            btnexit = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            linklog = new LinkLabel();
            txtcon = new TextBox();
            lblpassword = new Label();
            txtemail = new TextBox();
            lblusername = new Label();
            txtname = new TextBox();
            label2 = new Label();
            txtp = new TextBox();
            lblP = new Label();
            txtcp = new TextBox();
            label3 = new Label();
            btnsignup = new Button();
            picboxp = new PictureBox();
            picboxcp = new PictureBox();
            txtadd = new TextBox();
            lbladd = new Label();
            txtid = new TextBox();
            lblid = new Label();
            lblgen = new Label();
            rdbm = new RadioButton();
            rdbfm = new RadioButton();
            lbldb = new Label();
            dtp1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picboxp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picboxcp).BeginInit();
            SuspendLayout();
            // 
            // btnexit
            // 
            btnexit.BackColor = SystemColors.ButtonHighlight;
            btnexit.BackgroundImage = (Image)resources.GetObject("btnexit.BackgroundImage");
            btnexit.BackgroundImageLayout = ImageLayout.Stretch;
            btnexit.Location = new Point(1095, 2);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(28, 28);
            btnexit.TabIndex = 6;
            btnexit.UseVisualStyleBackColor = false;
            btnexit.UseWaitCursor = true;
            btnexit.Click += btnexit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.BackgroundImage = Properties.Resources.user1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(491, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 100);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(477, 14);
            label1.Name = "label1";
            label1.Size = new Size(154, 50);
            label1.TabIndex = 16;
            label1.Text = "Sign up";
            label1.Click += label1_Click;
            // 
            // linklog
            // 
            linklog.AutoSize = true;
            linklog.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linklog.Location = new Point(499, 683);
            linklog.Name = "linklog";
            linklog.Size = new Size(147, 20);
            linklog.TabIndex = 21;
            linklog.TabStop = true;
            linklog.Text = "LOGIN to the system";
            linklog.LinkClicked += linklog_LinkClicked;
            // 
            // txtcon
            // 
            txtcon.BackColor = Color.WhiteSmoke;
            txtcon.Location = new Point(118, 411);
            txtcon.Name = "txtcon";
            txtcon.Size = new Size(408, 27);
            txtcon.TabIndex = 20;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpassword.Location = new Point(118, 373);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(135, 23);
            lblpassword.TabIndex = 19;
            lblpassword.Text = "Contact number";
            // 
            // txtemail
            // 
            txtemail.BackColor = Color.WhiteSmoke;
            txtemail.Location = new Point(120, 329);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(408, 27);
            txtemail.TabIndex = 18;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusername.Location = new Point(120, 294);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(51, 23);
            lblusername.TabIndex = 17;
            lblusername.Text = "Email";
            // 
            // txtname
            // 
            txtname.BackColor = Color.WhiteSmoke;
            txtname.Location = new Point(120, 247);
            txtname.Name = "txtname";
            txtname.Size = new Size(896, 27);
            txtname.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(120, 212);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 22;
            label2.Text = "Full name";
            // 
            // txtp
            // 
            txtp.BackColor = Color.WhiteSmoke;
            txtp.Location = new Point(116, 586);
            txtp.Name = "txtp";
            txtp.PasswordChar = '*';
            txtp.Size = new Size(408, 27);
            txtp.TabIndex = 25;
            // 
            // lblP
            // 
            lblP.AutoSize = true;
            lblP.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblP.Location = new Point(118, 548);
            lblP.Name = "lblP";
            lblP.Size = new Size(82, 23);
            lblP.TabIndex = 24;
            lblP.Text = "Password";
            // 
            // txtcp
            // 
            txtcp.BackColor = Color.WhiteSmoke;
            txtcp.Location = new Point(603, 586);
            txtcp.Name = "txtcp";
            txtcp.PasswordChar = '*';
            txtcp.Size = new Size(408, 27);
            txtcp.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(604, 548);
            label3.Name = "label3";
            label3.Size = new Size(149, 23);
            label3.TabIndex = 26;
            label3.Text = "Confirm Password";
            // 
            // btnsignup
            // 
            btnsignup.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsignup.Location = new Point(513, 725);
            btnsignup.Name = "btnsignup";
            btnsignup.Size = new Size(118, 42);
            btnsignup.TabIndex = 28;
            btnsignup.Text = "SIGN UP";
            btnsignup.UseVisualStyleBackColor = true;
            btnsignup.Click += btnsignup_Click;
            btnsignup.MouseLeave += btnsignup_MouseLeave;
            btnsignup.MouseHover += btnsignup_MouseHover;
            // 
            // picboxp
            // 
            picboxp.Location = new Point(500, 589);
            picboxp.Name = "picboxp";
            picboxp.Size = new Size(24, 24);
            picboxp.TabIndex = 29;
            picboxp.TabStop = false;
            // 
            // picboxcp
            // 
            picboxcp.Location = new Point(987, 589);
            picboxcp.Name = "picboxcp";
            picboxcp.Size = new Size(24, 24);
            picboxcp.TabIndex = 30;
            picboxcp.TabStop = false;
            // 
            // txtadd
            // 
            txtadd.BackColor = Color.WhiteSmoke;
            txtadd.Location = new Point(601, 411);
            txtadd.Name = "txtadd";
            txtadd.Size = new Size(410, 27);
            txtadd.TabIndex = 34;
            // 
            // lbladd
            // 
            lbladd.AutoSize = true;
            lbladd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbladd.Location = new Point(604, 373);
            lbladd.Name = "lbladd";
            lbladd.Size = new Size(70, 23);
            lbladd.TabIndex = 33;
            lbladd.Text = "Address";
            // 
            // txtid
            // 
            txtid.BackColor = Color.WhiteSmoke;
            txtid.Location = new Point(603, 331);
            txtid.Name = "txtid";
            txtid.Size = new Size(408, 27);
            txtid.TabIndex = 32;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblid.Location = new Point(605, 294);
            lblid.Name = "lblid";
            lblid.Size = new Size(97, 23);
            lblid.TabIndex = 31;
            lblid.Text = "National ID";
            // 
            // lblgen
            // 
            lblgen.AutoSize = true;
            lblgen.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblgen.Location = new Point(120, 459);
            lblgen.Name = "lblgen";
            lblgen.Size = new Size(66, 23);
            lblgen.TabIndex = 35;
            lblgen.Text = "Gender";
            // 
            // rdbm
            // 
            rdbm.AutoSize = true;
            rdbm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            rdbm.Location = new Point(123, 499);
            rdbm.Name = "rdbm";
            rdbm.Size = new Size(64, 24);
            rdbm.TabIndex = 36;
            rdbm.TabStop = true;
            rdbm.Text = "Male";
            rdbm.UseVisualStyleBackColor = true;
            // 
            // rdbfm
            // 
            rdbfm.AutoSize = true;
            rdbfm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            rdbfm.Location = new Point(300, 499);
            rdbfm.Name = "rdbfm";
            rdbfm.Size = new Size(79, 24);
            rdbfm.TabIndex = 37;
            rdbfm.TabStop = true;
            rdbfm.Text = "Female";
            rdbfm.UseVisualStyleBackColor = true;
            // 
            // lbldb
            // 
            lbldb.AutoSize = true;
            lbldb.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldb.Location = new Point(603, 459);
            lbldb.Name = "lbldb";
            lbldb.Size = new Size(108, 23);
            lbldb.TabIndex = 38;
            lbldb.Text = "Date of Birth";
            // 
            // dtp1
            // 
            dtp1.Format = DateTimePickerFormat.Short;
            dtp1.Location = new Point(603, 499);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(250, 27);
            dtp1.TabIndex = 40;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1124, 804);
            ControlBox = false;
            Controls.Add(dtp1);
            Controls.Add(lbldb);
            Controls.Add(rdbfm);
            Controls.Add(rdbm);
            Controls.Add(lblgen);
            Controls.Add(txtadd);
            Controls.Add(lbladd);
            Controls.Add(txtid);
            Controls.Add(lblid);
            Controls.Add(picboxcp);
            Controls.Add(picboxp);
            Controls.Add(btnsignup);
            Controls.Add(txtcp);
            Controls.Add(label3);
            Controls.Add(txtp);
            Controls.Add(lblP);
            Controls.Add(txtname);
            Controls.Add(label2);
            Controls.Add(linklog);
            Controls.Add(txtcon);
            Controls.Add(lblpassword);
            Controls.Add(txtemail);
            Controls.Add(lblusername);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnexit);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picboxp).EndInit();
            ((System.ComponentModel.ISupportInitialize)picboxcp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnexit;
        private PictureBox pictureBox1;
        private Label label1;
        private LinkLabel linklog;
        private TextBox txtcon;
        private Label lblpassword;
        private TextBox txtemail;
        private Label lblusername;
        private TextBox txtname;
        private Label label2;
        private TextBox txtp;
        private Label lblP;
        private TextBox txtcp;
        private Label label3;
        private Button btnsignup;
        private PictureBox picboxp;
        private PictureBox picboxcp;
        private TextBox txtadd;
        private Label lbladd;
        private TextBox txtid;
        private Label lblid;
        private Label lblgen;
        private RadioButton rdbm;
        private RadioButton rdbfm;
        private Label lbldb;
        private DateTimePicker dtp1;
    }
}