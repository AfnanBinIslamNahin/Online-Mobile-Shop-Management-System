using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");
        private string full_name;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (radioButton1.Checked)
            {


                Form3 form3 = new Form3();
                this.Hide();
                form3.Show();

            }
            else if (radioButton2.Checked)
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (password.UseSystemPasswordChar)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                {
                    try
                    {
                        if (email.Text != "" && password.Text != "")
                        {
                            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30"))
                            {
                                connection.Open();
                                SqlCommand command = new SqlCommand("select full_name, gender, address, email FROM admin where email = @Email and password = @Password", connection);
                                command.Parameters.AddWithValue("@Email", email.Text);
                                command.Parameters.AddWithValue("@Password", password.Text);

                                SqlDataReader dr = command.ExecuteReader();
                                if (dr.Read())
                                {
                                    // Read user details
                                    string name = dr["full_name"].ToString();
                                    string gender = dr["gender"].ToString();
                                    string address = dr["address"].ToString();
                                    string email = dr["email"].ToString();

                                    // Pass the data to the next form or store it for later use
                                    Form4 Admin = new Form4(name,gender,address,email);
                                    Admin.Show();
                                    this.Hide();

                                    // Reset fields
                                    // email.Text = "";
                                    // password.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show("Error email or password", "Error!");

                                }
                            }
                        }

                        else
                        {
                            MessageBox.Show("Fill in the blanks...");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }


            else if (radioButton2.Checked)
            {
                try
                {
                    if (email.Text != "" && password.Text != "")
                    {
                        using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30"))
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand("select f_name, l_name, date, gender, address, email FROM users where email = @Email and password = @Password", connection);
                            command.Parameters.AddWithValue("@Email", email.Text);
                            command.Parameters.AddWithValue("@Password", password.Text);

                            SqlDataReader dr = command.ExecuteReader();
                            if (dr.Read())
                            {
                                // Read user details
                                string f_name = dr["f_name"].ToString();
                                string l_name = dr["l_name"].ToString();
                                string date = dr["date"].ToString();
                                string gender = dr["gender"].ToString();
                                string address = dr["address"].ToString();
                                string email = dr["email"].ToString();

                                // Pass the data to the next form or store it for later use
                                User_profile user = new User_profile(f_name, l_name, date, gender, address, email);
                                user.Show();
                                this.Hide();

                                // Reset fields
                                // email.Text = "";
                                // password.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Error email or password", "Error!");

                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("Fill in the blanks...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

    

