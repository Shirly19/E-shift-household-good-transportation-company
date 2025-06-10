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
using System.Net;
using System.Net.Mail;

namespace AD_coursework
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnSendResetLink_Click(object sender, EventArgs e)
        {
           SendPasswordResetEmail();
        }
        private void SendPasswordResetEmail()
        {
            string email = txtemail.Text.Trim().ToLower(); // normalize casing
            string token = Guid.NewGuid().ToString();
            DateTime expiry = DateTime.Now.AddMinutes(15);

            using (SqlConnection conn = new SqlConnection("Data Source=ASUS_VIVOBOOK15;Initial Catalog=eshift;Integrated Security=True;Pooling=False;Encrypt=False;"))
            {
                conn.Open();

                // Check if email exists
                string checkEmailQuery = "SELECT Email FROM Customers WHERE Email = @Email UNION SELECT Email FROM Employees WHERE Email = @Email";
                SqlCommand checkCmd = new SqlCommand(checkEmailQuery, conn);
                checkCmd.Parameters.AddWithValue("@Email", email);
                var result = checkCmd.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Email not found.");
                    return;
                }

                // Remove previous tokens (clean state)
                string deleteOld = "DELETE FROM PasswordResets WHERE Email = @Email";
                SqlCommand delCmd = new SqlCommand(deleteOld, conn);
                delCmd.Parameters.AddWithValue("@Email", email);
                delCmd.ExecuteNonQuery();

                // Insert new token
                string insertQuery = "INSERT INTO PasswordResets (Email, Token, Expiration) VALUES (@Email, @Token, @Expiry)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@Email", email);
                insertCmd.Parameters.AddWithValue("@Token", token);
                insertCmd.Parameters.AddWithValue("@Expiry", expiry);
                insertCmd.ExecuteNonQuery();

                // Prepare email
                string resetLink = $"EMAIL: {email}\nTOKEN: {token}";
                string subject = "Password Reset Request";
                string body = $"Use the following details to reset your password in the application:\n\n{resetLink}\n\nThis token will expire in 15 minutes.";

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("no-reply@eshift.local", "E-Shift Support");
                mail.To.Add(email);
                mail.Subject = subject;
                mail.Body = body;

                SmtpClient client = new SmtpClient("localhost", 25)
                {
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    EnableSsl = false
                };

                try
                {
                    client.Send(mail);
                    MessageBox.Show("Password reset link sent to your email.", "Reset Link Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form8 form8 = new Form8();
                    form8.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Email sending failed: " + ex.Message);
                }

                // Clean up expired tokens
                SqlCommand cleanupCmd = new SqlCommand("DELETE FROM PasswordResets WHERE Expiration < @Now", conn);
                cleanupCmd.Parameters.AddWithValue("@Now", DateTime.Now);
                cleanupCmd.ExecuteNonQuery();

                txtemail.Clear();
            }
        }

    }
}

