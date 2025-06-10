namespace AD_coursework
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            label1 = new Label();
            btnexit = new Button();
            btnreset = new Button();
            txtemail = new TextBox();
            label2 = new Label();
            txttoken = new TextBox();
            lbltoken = new Label();
            txtnewpassword = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 40);
            label1.Name = "label1";
            label1.Size = new Size(233, 31);
            label1.TabIndex = 17;
            label1.Text = "Reset your password";
            // 
            // btnexit
            // 
            btnexit.BackColor = SystemColors.ButtonHighlight;
            btnexit.BackgroundImage = (Image)resources.GetObject("btnexit.BackgroundImage");
            btnexit.BackgroundImageLayout = ImageLayout.Stretch;
            btnexit.Location = new Point(825, 2);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(28, 28);
            btnexit.TabIndex = 18;
            btnexit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnexit.UseVisualStyleBackColor = false;
            btnexit.UseWaitCursor = true;
            btnexit.Click += btnexit_Click;
            // 
            // btnreset
            // 
            btnreset.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnreset.Location = new Point(305, 420);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(243, 47);
            btnreset.TabIndex = 21;
            btnreset.Text = "RESET the Password";
            btnreset.UseVisualStyleBackColor = true;
            btnreset.Click += btnreset_Click;
            // 
            // txtemail
            // 
            txtemail.BackColor = SystemColors.InactiveBorder;
            txtemail.Location = new Point(160, 156);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(535, 30);
            txtemail.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(160, 119);
            label2.Name = "label2";
            label2.Size = new Size(153, 23);
            label2.TabIndex = 19;
            label2.Text = "Your Email address";
            // 
            // txttoken
            // 
            txttoken.BackColor = SystemColors.ButtonHighlight;
            txttoken.Location = new Point(299, 248);
            txttoken.Name = "txttoken";
            txttoken.Size = new Size(249, 30);
            txttoken.TabIndex = 23;
            txttoken.TextChanged += txttoken_TextChanged;
            // 
            // lbltoken
            // 
            lbltoken.AutoSize = true;
            lbltoken.BackColor = SystemColors.ButtonHighlight;
            lbltoken.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltoken.Location = new Point(358, 212);
            lbltoken.Name = "lbltoken";
            lbltoken.Size = new Size(121, 23);
            lbltoken.TabIndex = 22;
            lbltoken.Text = "Received code";
            // 
            // txtnewpassword
            // 
            txtnewpassword.BackColor = SystemColors.ButtonHighlight;
            txtnewpassword.Location = new Point(242, 337);
            txtnewpassword.Name = "txtnewpassword";
            txtnewpassword.Size = new Size(388, 30);
            txtnewpassword.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(369, 297);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 24;
            label3.Text = "New password";
            label3.Click += label3_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(853, 518);
            ControlBox = false;
            Controls.Add(txtnewpassword);
            Controls.Add(label3);
            Controls.Add(txttoken);
            Controls.Add(lbltoken);
            Controls.Add(btnreset);
            Controls.Add(txtemail);
            Controls.Add(label2);
            Controls.Add(btnexit);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnexit;
        private Button btnreset;
        private TextBox txtemail;
        private Label label2;
        private TextBox txttoken;
        private Label lbltoken;
        private TextBox txtnewpassword;
        private Label label3;
    }
}