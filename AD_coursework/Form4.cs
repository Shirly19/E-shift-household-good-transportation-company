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
    public partial class Form4 : Form
    {
        private string loggedInCustomerId;

        // Add this constructor
        public Form4(string customerId, string customerName)
        {
            InitializeComponent();
            btnupdate.Click += btnupdate_Click;
            loggedInCustomerId = customerId;

            // Set the customer ID label in the Services and Job Requested tab
            lblecusid.Text = loggedInCustomerId;

            this.Text = $"Welcome, {customerName}";
            LoadCustomerData(loggedInCustomerId);
        }

        // Existing default constructor (keep if needed)
        public Form4()
        {
            InitializeComponent();
            btnupdate.Click += btnupdate_Click;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        // 2. Fix radio button logic for payment method
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Card selected
            groupBox3.Visible = radioButton2.Checked;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a profile picture";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    picuserprof.Image = Image.FromFile(imagePath);
                    picuserprof.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        private void LoadCustomerData(string customerId)
        {
            using (SqlConnection conn = new SqlConnection("Data Source = ASUS_VIVOBOOK15; Initial Catalog = eshift; Integrated Security = True; Pooling = False; Encrypt = False;"))
            {
                conn.Open();
                string query = @"
            SELECT c.FullName, c.Email, c.ContactNumber, c.Address, c.NationalID, c.DateOfBirth, c.Gender, p.ProfilePic
            FROM Customers c
            LEFT JOIN CustomerProfilePics p ON c.CustomerID = p.CustomerID
            WHERE c.CustomerID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", customerId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtname.Text = reader["FullName"].ToString();
                            txtemail.Text = reader["Email"].ToString();
                            txtcon.Text = reader["ContactNumber"].ToString();
                            txtadd.Text = reader["Address"].ToString();
                            txtid.Text = reader["NationalID"].ToString();
                            dtp1.Value = Convert.ToDateTime(reader["DateOfBirth"]);

                            string gender = reader["Gender"].ToString();
                            rdbm.Checked = gender == "Male";
                            rdbfm.Checked = gender == "Female";

                            if (reader["ProfilePic"] != DBNull.Value)
                            {
                                byte[] imageBytes = (byte[])reader["ProfilePic"];
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    picuserprof.Image = Image.FromStream(ms);
                                }
                                picuserprof.SizeMode = PictureBoxSizeMode.StretchImage; // Ensure image fits the box
                            }
                            else
                            {
                                // Use the image from resources instead of loading from file
                                picuserprof.Image = Properties.Resources.user1; // Replace 'user1' with the actual resource name if different
                                picuserprof.SizeMode = PictureBoxSizeMode.StretchImage;
                            }

                            SetFieldsEditable(false);
                            lblcustomer.Text = txtname.Text;
                        }
                    }
                }
            }
        }

        private void SetFieldsEditable(bool editable)
        {
            txtname.ReadOnly = !editable;
            txtemail.ReadOnly = !editable;
            txtcon.ReadOnly = !editable;
            txtadd.ReadOnly = !editable;
            txtid.ReadOnly = !editable;
            dtp1.Enabled = editable;
            rdbm.Enabled = editable;
            rdbfm.Enabled = editable;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetFieldsEditable(true);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string customerId = loggedInCustomerId; // your logged-in customer ID

            UpdateCustomerInfo(customerId);

            if (picuserprof.Image != null)
            {
                SaveCustomerProfilePic(customerId, picuserprof.Image);
            }

            MessageBox.Show("Profile updated successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetFieldsEditable(false);
        }

        private void LoadJobTypes()
        {
            string connectionString = "Data Source = ASUS_VIVOBOOK15; Initial Catalog = eshift; Integrated Security = True; Pooling = False; Encrypt = False";
            string query = "SELECT JobTypeName FROM JobTypes";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbjobs.Items.Clear(); // Optional: clear existing items

                    while (reader.Read())
                    {
                        cmbjobs.Items.Add(reader["JobTypeName"].ToString());
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading job types: " + ex.Message);
                }
            }
        }

        // 3. Ensure payment data is saved to DB in btnpay_Click (already present, but ensure jobId and amount are correct)
        // 4. Make sure groupBox3 is hidden by default and toggled by radio buttons
        private void Form4_Load(object sender, EventArgs e)
        {
            LoadItemTypes();
            SetFieldsEditable(false);
            LoadCustomerData(loggedInCustomerId);
            dataitemdetails.CellContentClick += dataitemdetails_CellContentClick;

            dataitemdetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataitemdetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataitemdetails.Dock = DockStyle.None;
            dataitemdetails.ScrollBars = ScrollBars.Both;

            LoadJobTypes();

            // Hide card group by default
            groupBox3.Visible = radioButton2.Checked;
            // Attach CheckedChanged events if not already done
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            rdbm.CheckedChanged += rdbCash_CheckedChanged; // If rdbm is the cash radio button
        }
        private const decimal RATE_PER_KM = 500.00m;     // Cost per km (in code)
        private const decimal FRAGILE_FEE = 2000.00m;   // Fixed fee if fragile

        // Pseudocode plan:
        // 1. Ensure btncal_Click updates both lbltotal (payment tab) and lblcost (current tab) with the calculated price.
        // 2. Fix radio button logic so that selecting Card shows groupBox3, and selecting Cash hides it. Use CheckedChanged events for both radio buttons.
        // 3. Ensure payment data is saved to the database in btnpay_Click, and that the correct job/payment info is used.
        // 4. Make sure the groupBox3 visibility is toggled correctly when radio buttons are changed.

        // --- CODE CHANGES ---

        // 1. Update btncal_Click to update both labels
        private void btncal_Click(object sender, EventArgs e)
        {
            // 1. Calculate total item cost from DataGridView
            decimal itemTotal = 0;
            foreach (DataGridViewRow row in dataitemdetails.Rows)
            {
                if (row.Cells["colCost"].Value != null)
                {
                    decimal rowCost;
                    if (decimal.TryParse(row.Cells["colCost"].Value.ToString(), out rowCost))
                        itemTotal += rowCost;
                }
            }

            // 2. Get other job details from controls
            string addressFrom = txtaddF.Text;
            string addressTo = txtaddT.Text;
            string jobType = cmbjobs.SelectedItem?.ToString() ?? "";
            DateTime jobDate = dtpjdate.Value;
            int trips = (int)numtrip.Value;
            bool fragile = checkfragile.Checked;
            decimal distance = numdis.Value;
            string notes = textBox1.Text;
            decimal estimatedCost = itemTotal + (distance * RATE_PER_KM * trips) + (fragile ? FRAGILE_FEE : 0);

            // 3. Save job to DB and get new JobID
            int newJobId = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=ASUS_VIVOBOOK15;Initial Catalog=eshift;Integrated Security=True;Pooling=False;Encrypt=False;"))
                {
                    conn.Open();
                    string insertQuery = @"
                INSERT INTO Jobs 
                (CustomerID, AddressFrom, AddressTo, JobType, JobDate, Trips, Fragile, DistanceKm, Notes, EstimatedCost, CreatedAt)
                OUTPUT INSERTED.JobID
                VALUES
                (@CustomerID, @AddressFrom, @AddressTo, @JobType, @JobDate, @Trips, @Fragile, @DistanceKm, @Notes, @EstimatedCost, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", loggedInCustomerId);
                        cmd.Parameters.AddWithValue("@AddressFrom", addressFrom);
                        cmd.Parameters.AddWithValue("@AddressTo", addressTo);
                        cmd.Parameters.AddWithValue("@JobType", jobType);
                        cmd.Parameters.AddWithValue("@JobDate", jobDate);
                        cmd.Parameters.AddWithValue("@Trips", trips);
                        cmd.Parameters.AddWithValue("@Fragile", fragile);
                        cmd.Parameters.AddWithValue("@DistanceKm", distance);
                        cmd.Parameters.AddWithValue("@Notes", notes);
                        cmd.Parameters.AddWithValue("@EstimatedCost", estimatedCost);
                        newJobId = (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving job: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Show result in both labels
            lbltotal.Text = "Rs. " + estimatedCost.ToString("F2");
            lblcost.Text = "Rs. " + estimatedCost.ToString("F2");
            lbljobid.Text = newJobId.ToString(); // Show JobID for payment reference

            MessageBox.Show("Job request saved and cost calculated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveCustomerProfilePic(string customerId, Image profilePic)
        {
            byte[] picBytes = profilePic != null ? ImageToByteArray(profilePic) : null;

            using (SqlConnection conn = new SqlConnection("Data Source = ASUS_VIVOBOOK15; Initial Catalog = eshift; Integrated Security = True; Pooling = False; Encrypt = False;"))
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM CustomerProfilePics WHERE CustomerID = @id";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@id", customerId);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        string updateQuery = @"
                    UPDATE CustomerProfilePics
                    SET ProfilePic = @pic, UploadDate = GETDATE()
                    WHERE CustomerID = @id";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@pic", (object)picBytes ?? DBNull.Value);
                            updateCmd.Parameters.AddWithValue("@id", customerId);
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string insertQuery = @"
                    INSERT INTO CustomerProfilePics (CustomerID, ProfilePic, UploadDate)
                    VALUES (@id, @pic, GETDATE())";
                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@id", customerId);
                            insertCmd.Parameters.AddWithValue("@pic", (object)picBytes ?? DBNull.Value);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
        private void UpdateCustomerInfo(string customerId)
        {
            using (SqlConnection conn = new SqlConnection("Data Source = ASUS_VIVOBOOK15; Initial Catalog = eshift; Integrated Security = True; Pooling = False; Encrypt = False;"))
            {
                conn.Open();
                string query = @"
            UPDATE Customers SET 
                FullName = @name,
                Email = @email,
                ContactNumber = @contact,
                Address = @address,
                NationalID = @nid,
                DateOfBirth = @dob,
                Gender = @gender
            WHERE CustomerID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", txtname.Text);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@contact", txtcon.Text);
                    cmd.Parameters.AddWithValue("@address", txtadd.Text);
                    cmd.Parameters.AddWithValue("@nid", txtid.Text);
                    cmd.Parameters.AddWithValue("@dob", dtp1.Value.Date);
                    cmd.Parameters.AddWithValue("@gender", rdbm.Checked ? "Male" : "Female");
                    cmd.Parameters.AddWithValue("@id", customerId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void cmbjobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedJobType = cmbjobs.SelectedItem.ToString();
            MessageBox.Show("Selected Job Type: " + selectedJobType);
        }
        private void LoadItemTypes()
        {
            using (SqlConnection conn = new SqlConnection("Data Source = ASUS_VIVOBOOK15; Initial Catalog = eshift; Integrated Security = True; Pooling = False; Encrypt = False"))
            {
                conn.Open();
                string query = "SELECT TypeName FROM ItemTypes ORDER BY TypeName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbitemtypes.Items.Add(reader["TypeName"].ToString());
                    }
                }
            }
        }
        private void UpdateTotalCost()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataitemdetails.Rows)
            {
                if (row.Cells["colCost"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["colCost"].Value);
                }
            }

            lblcost.Text = "Rs. " + total.ToString("F2");
        }

        private void btnadd_Click(object sender, EventArgs e)

        {
            if (cmbitemtypes.SelectedItem == null || numquantity.Value == 0)
            {
                MessageBox.Show("Please select an item and enter a quantity.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedItem = cmbitemtypes.SelectedItem.ToString();
            int quantity = (int)numquantity.Value;

            // Get unit price from database
            decimal unitPrice = 0;
            using (SqlConnection conn = new SqlConnection("Data Source = ASUS_VIVOBOOK15; Initial Catalog = eshift; Integrated Security = True; Pooling = False; Encrypt = False"))
            {
                conn.Open();
                string query = "SELECT UnitPrice FROM ItemTypes WHERE TypeName = @type";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@type", selectedItem);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        unitPrice = Convert.ToDecimal(result);
                    }
                    else
                    {
                        MessageBox.Show("Unit price not found for the selected item.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // Calculate cost
            decimal totalCost = unitPrice * quantity;

            // Add to DataGridView
            dataitemdetails.Rows.Add(selectedItem, quantity, unitPrice.ToString("F2"), totalCost.ToString("F2"));

            // Update total cost label
            UpdateTotalCost();
        }

        private void dataitemdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataitemdetails.Columns["colRemove"].Index && e.RowIndex >= 0)
            {
                dataitemdetails.Rows.RemoveAt(e.RowIndex);
                UpdateTotalCost();
            }
        }
        public void SendEmail(string toEmail, string subject, string body)
        {
            var fromAddress = new MailAddress("noreply@yourapp.local", "Your App");
            var toAddress = new MailAddress(toEmail);

            var smtp = new SmtpClient
            {
                Host = "localhost",
                Port = 25,
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = true
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void picuserprof_Click(object sender, EventArgs e)
        {

        }

        private void numquantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnpay_Click(object sender, EventArgs e)

        {
            // Determine payment method
            string paymentMethod = radioButton2.Checked ? "Card" : "Cash";
            string amountText = lbltotal.Text.Replace("Rs. ", "").Trim();
            decimal amount = decimal.TryParse(amountText, out var amt) ? amt : 0;

            // Show total and ask to proceed
            var result = MessageBox.Show(
                $"Total to pay: Rs. {amount:F2}\nProceed with {paymentMethod} payment?",
                "Confirm Payment",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string status, jobStatus, msg;
                if (paymentMethod == "Card")
                {
                    // Optionally validate card fields here
                    status = "Payment Confirmed";
                    jobStatus = "Confirmed";
                    msg = $"Payment of Rs. {amount:F2} confirmed!";
                }
                else // Cash
                {
                    status = "Payment Needed";
                    jobStatus = "Pending";
                    msg = $"Payment of Rs. {amount:F2} needs to be done in cash. Status: Pending.";
                }

                // Insert payment record
                int newPaymentId = 0;
                try
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=ASUS_VIVOBOOK15;Initial Catalog=eshift;Integrated Security=True;Pooling=False;Encrypt=False;"))
                    {
                        conn.Open();
                        string insertQuery = @"
                    INSERT INTO Payments 
                        (JobID, PaymentMethod, PaymentDate, CardNumber, CardHolderName, ExpiryDate, CVV, Amount, Status, JobStatus)
                    OUTPUT INSERTED.PaymentID
                    VALUES 
                        (@jobId, @method, GETDATE(), @cardNumber, @cardHolderName, @expiry, @cvv, @amount, @status, @jobStatus)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@jobId", lbljobid.Text);
                            cmd.Parameters.AddWithValue("@method", paymentMethod);
                            cmd.Parameters.AddWithValue("@cardNumber", paymentMethod == "Card" ? txtcardNum.Text : (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@cardHolderName", paymentMethod == "Card" ? txtname.Text : (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@expiry", paymentMethod == "Card" ? txtex.Text : (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@cvv", paymentMethod == "Card" ? txtCVV.Text : (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@amount", amount);
                            cmd.Parameters.AddWithValue("@status", status);
                            cmd.Parameters.AddWithValue("@jobStatus", jobStatus);
                            newPaymentId = (int)cmd.ExecuteScalar();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update status label
                lbljobstatus.Text = jobStatus;

                // Show confirmation message
                MessageBox.Show(msg, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Build detailed email body
                string customerEmail = txtemail.Text;
                string subject = $"Payment {status} for Job #{lbljobid.Text}";
                string body = $"Dear {txtname.Text}, "
                    + $"Your payment for Job #{lbljobid.Text} has been recorded. "
                    + $"Payment Details: "
                    + $"- Payment ID: {newPaymentId} " 
                    + $"- Payment Method: {paymentMethod} "
                    + (paymentMethod == "Card"
                        ? $"- Card Number: ****{txtcardNum.Text?.Substring(Math.Max(0, txtcardNum.Text.Length - 4))} "
                        : "")
                    + $"- Amount: Rs. {amount:F2} "
                    + $"- Status: {status} "
                    + $"- Date: {DateTime.Now:yyyy-MM-dd HH:mm}"
                    + "Job Details:\n"
                    + $"- Customer Name: {txtname.Text} "
                    + $"- Job ID: {lbljobid.Text} "
                    + $"- Job Status: {jobStatus} "
                    + "Thank you for choosing us! Best regards, e-Shift.";

                try
                {
                    SendEmail(customerEmail, subject, body);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to send email: " + ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Payment declined
                MessageBox.Show($"Payment of Rs. {amount:F2} declined.", "Declined", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void rdbCard_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = radioButton2.Checked;
        }

        private void rdbCash_CheckedChanged(object sender, EventArgs e)
        {
            // Cash selected
            groupBox3.Visible = false;
        }
    }
}





