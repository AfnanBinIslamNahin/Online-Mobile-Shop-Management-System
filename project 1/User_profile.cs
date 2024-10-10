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

namespace project_1
{
    public partial class User_profile : Form
    {
        private string f_name;
        private string l_name;
        private string date;
        private string gender;
        private string address;
        private string email;
        public User_profile(string f_name, string l_name, string date, string gender, string address, string email)
        {
            InitializeComponent();
            this.f_name = f_name;
            this.l_name = l_name;
            this.date = date;
            this.gender = gender;
            this.address = address;
            this.email = email;
        }

        private void User_profile_Load(object sender, EventArgs e)
        {

            textBox1.Text = f_name;
            textBox2.Text = l_name;
            textBox3.Text = gender;
            textBox4.Text = date;
            textBox5.Text = address;
            textBox6.Text = email;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search Search = new search();
           // this.Hide();
            Search.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            purchase purchase = new purchase();
           // this.Hide();
            purchase.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            service Service = new service();
           // this.Hide();
            Service.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            orderrequest Orderrequest = new orderrequest();
          // this.Hide();
            Orderrequest.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Review review = new Review();
           // this.Hide();
            review.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you already in your profile page");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string currentPassword = old_password.Text;
            string newPassword = new_password.Text;
            string confirmPassword = confirm_password.Text;

            if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New Password and Confirm Password do not match.");
                return;
            }

            string userEmail = email_text.Text;  // This would typically come from the user's session or login context.

            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;"))
            {
                con.Open();

                // Step 1: Verify current password
                string query = "SELECT password FROM users WHERE email=@Email";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", userEmail);

                    string storedPassword = cmd.ExecuteScalar()?.ToString();

                    if (storedPassword == null)
                    {
                        MessageBox.Show("User not found.");
                        return;
                    }

                    if (storedPassword != currentPassword)
                    {
                        MessageBox.Show("Current password is incorrect.");
                        return;
                    }
                }

                // Step 2: Update password
                string updateQuery = "UPDATE users SET password=@NewPassword WHERE email=@Email";
                using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                {
                    updateCmd.Parameters.AddWithValue("@NewPassword", newPassword);
                    updateCmd.Parameters.AddWithValue("@Email", userEmail);

                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password successfully changed.");
                    }
                    else
                    {
                        MessageBox.Show("Password update failed.");
                    }
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
