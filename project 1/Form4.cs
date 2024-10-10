using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace project_1
{
    public partial class Form4 : Form
    {
        private string name;
        private string gender;
        private string address;
        private string email;
        public Form4(string name, string gender, string address, string email)
        {
            InitializeComponent();
            this.name =name;
            this.gender = gender;
            this.address = address;
            this.email = email;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customer_records re = new customer_records();
          //  this.Hide();
            re.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_mobile add  = new Add_mobile();
           // this.Hide();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             user_information U = new user_information();
           // this.Hide();
            U.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            admin_order_request ad = new admin_order_request();
           // this.Hide();
            ad.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            admin_review rev = new admin_review();
           // this.Hide();
            rev.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text = name;
            textBox2.Text = gender;
            textBox4.Text = address;
            textBox6.Text = email;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
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

            string adminEmail = email_text.Text;  // This would typically come from the user's session or login context.

            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;"))
            {
                con.Open();

                // Step 1: Verify current password
                string query = "SELECT password FROM admin WHERE email=@Email";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", adminEmail);

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
                string updateQuery = "UPDATE admin SET password=@NewPassword WHERE email=@Email";
                using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                {
                    updateCmd.Parameters.AddWithValue("@NewPassword", newPassword);
                    updateCmd.Parameters.AddWithValue("@Email", adminEmail);

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox1.Checked
            if (new_password.UseSystemPasswordChar)
            {
                new_password.UseSystemPasswordChar = false;
                confirm_password.UseSystemPasswordChar = false;
            }
            else
            {
                new_password.UseSystemPasswordChar = true;
                confirm_password.UseSystemPasswordChar = true;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            service_center ac = new service_center();
            ac.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            admin_dashboard ad = new admin_dashboard();
            ad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are in Admin Profile Page");
        }
    }
}
