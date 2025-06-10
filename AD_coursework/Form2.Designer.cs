namespace AD_coursework
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            colorDialog1 = new ColorDialog();
            lblem = new Label();
            txtE = new TextBox();
            txtp = new TextBox();
            lblpassword = new Label();
            btnlogin = new Button();
            linksignup = new LinkLabel();
            label1 = new Label();
            linkfp = new LinkLabel();
            pictureBox1 = new PictureBox();
            pictogglepassword = new PictureBox();
            label2 = new Label();
            lblUtype = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            cmbU = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictogglepassword).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(796, 12);
            button1.Name = "button1";
            button1.Size = new Size(28, 28);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // lblem
            // 
            lblem.AutoSize = true;
            lblem.BackColor = SystemColors.ButtonHighlight;
            lblem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblem.Location = new Point(231, 297);
            lblem.Name = "lblem";
            lblem.Size = new Size(154, 23);
            lblem.TabIndex = 6;
            lblem.Text = "Username or Email";
            lblem.Click += label1_Click;
            // 
            // txtE
            // 
            txtE.BackColor = SystemColors.ButtonHighlight;
            txtE.Location = new Point(231, 332);
            txtE.Name = "txtE";
            txtE.Size = new Size(378, 27);
            txtE.TabIndex = 7;
            // 
            // txtp
            // 
            txtp.BackColor = SystemColors.ButtonHighlight;
            txtp.Location = new Point(231, 413);
            txtp.Name = "txtp";
            txtp.Size = new Size(378, 27);
            txtp.TabIndex = 9;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.BackColor = SystemColors.ButtonHighlight;
            lblpassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpassword.Location = new Point(231, 378);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(82, 23);
            lblpassword.TabIndex = 8;
            lblpassword.Text = "Password";
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.Location = new Point(337, 640);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(118, 42);
            btnlogin.TabIndex = 10;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            btnlogin.MouseLeave += btnlogin_MouseLeave;
            btnlogin.MouseHover += btnlogin_MouseHover;
            // 
            // linksignup
            // 
            linksignup.AutoSize = true;
            linksignup.BackColor = SystemColors.ButtonHighlight;
            linksignup.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            linksignup.Location = new Point(482, 712);
            linksignup.Name = "linksignup";
            linksignup.Size = new Size(61, 20);
            linksignup.TabIndex = 11;
            linksignup.TabStop = true;
            linksignup.Text = "Sign up";
            linksignup.LinkClicked += linksignup_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(251, 712);
            label1.Name = "label1";
            label1.Size = new Size(204, 20);
            label1.TabIndex = 12;
            label1.Text = "Do not have an account yet?";
            // 
            // linkfp
            // 
            linkfp.AutoSize = true;
            linkfp.BackColor = SystemColors.ControlLightLight;
            linkfp.Location = new Point(337, 581);
            linkfp.Name = "linkfp";
            linkfp.Size = new Size(118, 20);
            linkfp.TabIndex = 13;
            linkfp.TabStop = true;
            linkfp.Text = "Forgot Password";
            linkfp.LinkClicked += linkfp_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.BackgroundImage = Properties.Resources.user1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(362, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 125);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictogglepassword
            // 
            pictogglepassword.Location = new Point(585, 416);
            pictogglepassword.Name = "pictogglepassword";
            pictogglepassword.Size = new Size(24, 24);
            pictogglepassword.SizeMode = PictureBoxSizeMode.Zoom;
            pictogglepassword.TabIndex = 15;
            pictogglepassword.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(362, 50);
            label2.Name = "label2";
            label2.Size = new Size(135, 50);
            label2.TabIndex = 17;
            label2.Text = "LOGIN";
            // 
            // lblUtype
            // 
            lblUtype.AutoSize = true;
            lblUtype.BackColor = SystemColors.ButtonHighlight;
            lblUtype.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUtype.Location = new Point(231, 455);
            lblUtype.Name = "lblUtype";
            lblUtype.Size = new Size(85, 23);
            lblUtype.TabIndex = 18;
            lblUtype.Text = "User Type";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // cmbU
            // 
            cmbU.BackColor = SystemColors.InactiveBorder;
            cmbU.FormattingEnabled = true;
            cmbU.Items.AddRange(new object[] { "Administrator", "Customer", "Employee" });
            cmbU.Location = new Point(231, 495);
            cmbU.Name = "cmbU";
            cmbU.Size = new Size(269, 28);
            cmbU.TabIndex = 19;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(836, 796);
            ControlBox = false;
            Controls.Add(cmbU);
            Controls.Add(lblUtype);
            Controls.Add(label2);
            Controls.Add(pictogglepassword);
            Controls.Add(pictureBox1);
            Controls.Add(linkfp);
            Controls.Add(label1);
            Controls.Add(linksignup);
            Controls.Add(btnlogin);
            Controls.Add(txtp);
            Controls.Add(lblpassword);
            Controls.Add(txtE);
            Controls.Add(lblem);
            Controls.Add(button1);
            Name = "Form2";
            Text = " ";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictogglepassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ColorDialog colorDialog1;
        private Label lblem;
        private TextBox txtE;
        private TextBox txtp;
        private Label lblpassword;
        private Button btnlogin;
        private LinkLabel linksignup;
        private Label label1;
        private LinkLabel linkfp;
        private PictureBox pictureBox1;
        private PictureBox pictogglepassword;
        private Label label2;
        private Label lblUtype;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox cmbU;
    }
}