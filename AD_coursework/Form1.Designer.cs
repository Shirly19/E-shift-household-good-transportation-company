namespace AD_coursework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnmove = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(247, 53);
            label1.Name = "label1";
            label1.Size = new Size(259, 81);
            label1.TabIndex = 0;
            label1.Text = "e - Shift";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightCyan;
            pictureBox1.BackgroundImage = Properties.Resources.Untitled__9_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(198, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(377, 247);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Font = new Font("STXingkai", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.Location = new Point(211, 463);
            label2.Name = "label2";
            label2.Size = new Size(339, 46);
            label2.TabIndex = 2;
            label2.Text = "Welcome to e - Shift";
            label2.Click += label2_Click;
            // 
            // btnmove
            // 
            btnmove.BackColor = Color.LightCyan;
            btnmove.BackgroundImage = Properties.Resources.icons8_right_94;
            btnmove.BackgroundImageLayout = ImageLayout.Stretch;
            btnmove.Location = new Point(672, 551);
            btnmove.Name = "btnmove";
            btnmove.Size = new Size(74, 64);
            btnmove.TabIndex = 3;
            btnmove.UseVisualStyleBackColor = false;
            btnmove.UseWaitCursor = true;
            btnmove.Click += btnmove_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(744, 12);
            button1.Name = "button1";
            button1.Size = new Size(28, 28);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImage = Properties.Resources.OIP;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 648);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(btnmove);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnmove;
        private Button button1;
    }
}
