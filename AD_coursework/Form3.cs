using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 


namespace AD_coursework
{
    public partial class Form3 : Form
    {
        private string GenerateCustomerID()
        {
            string newCustomerId = "ESC00001"; // default if no records
            string connectionString = "Data Source=ASUS_VIVOBOOK15;Initial Catalog=eshift;Integrated Security=True;Pooling=False;Encrypt=False;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TOP 1 CustomerID FROM Customers ORDER BY CustomerID DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string lastId = result.ToString(); // e.g., ESC00005
                    int num = int.Parse(lastId.Substring(3));
                    num++;
                    newCustomerId = "ESC" + num.ToString("D5");
                }
            }

            return newCustomerId;
        }

        public Form3()
        {
            InitializeComponent();
            picboxp.Image = Properties.Resources.eye_closed;
            picboxcp.Image = Properties.Resources.eye_closed;
            picboxp.Click += picTogglePwd_Click;
            picboxcp.Click += picToggleConfirmPwd_Click;
            picboxp.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxcp.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linklog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            string fullName = txtname.Text.Trim();
            string email = txtemail.Text.Trim();
            string contact = txtcon.Text.Trim();
            string password = txtp.Text;
            string confirmPassword = txtcp.Text;
            string gender = rdbm.Checked ? "Male" : rdbfm.Checked ? "Female" : "";
            DateTime dob = dtp1.Value;
            string nationalID = txtid.Text.Trim();
            string address = txtadd.Text.Trim();

            // Basic validation
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(contact) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) || string.IsNullOrEmpty(gender) ||
                string.IsNullOrWhiteSpace(nationalID))
            {
                MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Generate unique CustomerID
            string customerId = GenerateCustomerID();

            // Save to database
            string connectionString = "Data Source=ASUS_VIVOBOOK15;Initial Catalog=eshift;Integrated Security=True;Pooling=False;Encrypt=False;";
            string query = @"INSERT INTO Customers (CustomerID, FullName, Email, ContactNumber, Password, Gender, DateOfBirth, NationalID, Address)
                     VALUES (@CustomerID, @FullName, @Email, @ContactNumber, @Password, @Gender, @DateOfBirth, @NationalID, @Address)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@ContactNumber", contact);
                    cmd.Parameters.AddWithValue("@Password", password); // Consider hashing in real apps
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dob);
                    cmd.Parameters.AddWithValue("@NationalID", nationalID);
                    cmd.Parameters.AddWithValue("@Address", address);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        DialogResult result = MessageBox.Show(
                            $"Sign-Up successful!\nYour Customer ID is: {customerId}",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            this.Hide();
                            Form2 loginForm = new Form2();
                            loginForm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sign-Up failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void clearFields()
        {
            txtname.Clear();
            txtemail.Clear();
            txtcon.Clear();
            txtp.Clear();
            txtcp.Clear();
            rdbm.Checked = false;
            rdbfm.Checked = false;
            dtp1.Value = DateTime.Now;
            txtid.Clear();
            txtadd.Clear();
        }
        private bool isPwdVisible = false;
        private bool isConfirmPwdVisible = false;

        private void picTogglePwd_Click(object sender, EventArgs e)
        {
            isPwdVisible = !isPwdVisible;
            txtp.PasswordChar = isPwdVisible ? '\0' : '*';
            picboxp.Image = isPwdVisible ? Properties.Resources.eye_open : Properties.Resources.eye_closed;
        }

        private void picToggleConfirmPwd_Click(object sender, EventArgs e)
        {
            isConfirmPwdVisible = !isConfirmPwdVisible;
            txtcp.PasswordChar = isConfirmPwdVisible ? '\0' : '*';
            picboxcp.Image = isConfirmPwdVisible ? Properties.Resources.eye_open : Properties.Resources.eye_closed;
        }
        private void btnsignup_MouseHover(object sender, EventArgs e)
        {
            btnsignup.BackColor = Color.Green; // Resets to the default button color
        }

        private void btnsignup_MouseLeave(object sender, EventArgs e)
        {
            btnsignup.BackColor = SystemColors.Control; // Resets to the default button color
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
