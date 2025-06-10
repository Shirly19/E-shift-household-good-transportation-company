using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AD_coursework
{

    public partial class Form2 : Form
    {
        bool passwordVisible = false;
        public Form2()
        {
            InitializeComponent();
            pictogglepassword.Image = Properties.Resources.eye_closed;
            pictogglepassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pictogglepassword.Cursor = Cursors.Hand;
            pictogglepassword.Click += pictogglepassword_Click;
            txtp.UseSystemPasswordChar = true;
        }
        private void pictogglepassword_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;
            txtp.UseSystemPasswordChar = !passwordVisible;
            pictogglepassword.Image = passwordVisible
                ? Properties.Resources.eye_open
                : Properties.Resources.eye_closed;
            pictogglepassword.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_MouseHover(object sender, EventArgs e)
        {
            btnlogin.BackColor = Color.Green;
        }

        private void btnlogin_MouseLeave(object sender, EventArgs e)
        {
            btnlogin.BackColor = SystemColors.Control; // Resets to the default button color
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string email = txtE.Text.Trim();
            string password = txtp.Text.Trim();
            string userType = cmbU.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(userType))
            {
                MessageBox.Show("Please select a user type.");
                return;
            }

            using (SqlConnection conn = new SqlConnection("Data Source = ASUS_VIVOBOOK15; Initial Catalog = eshift; Integrated Security = True; Pooling = False; Encrypt = False;"))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                if (userType == "Administrator")
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM Admins WHERE Username = @input AND Password = @password";
                    cmd.Parameters.AddWithValue("@input", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        Form5 form5 = new Form5();
                        form5.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Admin credentials.");
                    }
                }
                else if (userType == "Customer")
                {
                    cmd.CommandText = "SELECT * FROM Customers WHERE Email = @input AND Password = @password";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@input", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string customerId = reader.GetString(reader.GetOrdinal("CustomerID"));
                            string customerName = reader.GetString(reader.GetOrdinal("FullName"));

                            Form4 form4 = new Form4(customerId, customerName);
                            form4.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Customer credentials.");
                        }
                    }
                }
                else if (userType == "Employee")
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM Employees WHERE Email = @input AND Password = @password";
                    cmd.Parameters.AddWithValue("@input", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        Form6 form6 = new Form6(); // Replace with your actual employee form
                        form6.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Employee credentials.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid user type.");
                }
            }
        }

        private void linksignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkfp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form7 form7 = new Form7();
            form7.Show();
        }
    }
}
