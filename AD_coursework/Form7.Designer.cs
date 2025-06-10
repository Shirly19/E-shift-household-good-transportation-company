namespace AD_coursework
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            label1 = new Label();
            txtemail = new TextBox();
            btnSendResetLink = new Button();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 111);
            label1.Name = "label1";
            label1.Size = new Size(290, 23);
            label1.TabIndex = 0;
            label1.Text = "Enter your registered  email  address";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(132, 148);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(535, 27);
            txtemail.TabIndex = 1;
            // 
            // btnSendResetLink
            // 
            btnSendResetLink.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendResetLink.Location = new Point(351, 224);
            btnSendResetLink.Name = "btnSendResetLink";
            btnSendResetLink.Size = new Size(93, 48);
            btnSendResetLink.TabIndex = 2;
            btnSendResetLink.Text = "SEND";
            btnSendResetLink.UseVisualStyleBackColor = true;
            btnSendResetLink.Click += btnSendResetLink_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(770, 2);
            button1.Name = "button1";
            button1.Size = new Size(28, 28);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(262, 27);
            label2.Name = "label2";
            label2.Size = new Size(233, 31);
            label2.TabIndex = 18;
            label2.Text = "Reset your password";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP;
            ClientSize = new Size(800, 329);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(btnSendResetLink);
            Controls.Add(txtemail);
            Controls.Add(label1);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtemail;
        private Button btnSendResetLink;
        private Button button1;
        private Label label2;
    }
}