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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure, Do you really need to EXIT without resettinf the passwoed?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            this.Close();
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void txttoken_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text.Trim().ToLower(); // normalize casing
            string token = txttoken.Text.Trim();
            string newPassword = txtnewpassword.Text;

            using (SqlConnection conn = new SqlConnection("Data Source=ASUS_VIVOBOOK15;Initial Catalog=eshift;Integrated Security=True;Pooling=False;Encrypt=False;"))
            {
                conn.Open();

                string verifyQuery = "SELECT Expiration FROM PasswordResets WHERE Email = @Email AND Token = @Token";
                SqlCommand verifyCmd = new SqlCommand(verifyQuery, conn);
                verifyCmd.Parameters.AddWithValue("@Email", email);
                verifyCmd.Parameters.AddWithValue("@Token", token);

                object result = verifyCmd.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("Invalid or expired token.");
                    return;
                }

                DateTime expiry = (DateTime)result;
                if (DateTime.Now > expiry)
                {
                    MessageBox.Show("Token has expired.");
                    return;
                }

                // Update both Customers and Employees
                string updateQuery = "UPDATE Customers SET Password = @NewPassword WHERE Email = @Email; " +
                                     "UPDATE Employees SET Password = @NewPassword WHERE Email = @Email;";
                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@NewPassword", newPassword);
                updateCmd.Parameters.AddWithValue("@Email", email);
                updateCmd.ExecuteNonQuery();

                // Delete used token
                SqlCommand delCmd = new SqlCommand("DELETE FROM PasswordResets WHERE Email = @Email", conn);
                delCmd.Parameters.AddWithValue("@Email", email);
                delCmd.ExecuteNonQuery();

                MessageBox.Show("Password has been reset successfully.", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtemail.ReadOnly = true;
                this.Close();
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

    }
}

