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
using System.Xml.Linq;

namespace project_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox1.Checked
            if (password.UseSystemPasswordChar)
            {
                password.UseSystemPasswordChar = false;
                con_password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
                con_password.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (fullname.Text != "" && address.Text != "" && gender.Text != "" && email.Text != "" && password.Text != "" && con_password.Text != "")
                {
                    if (password.Text == con_password.Text)
                    {
                        int v = check(email.Text);
                        if (v != 1)
                        {
                            connection.Open();
                            string query = "insert into admin(fullname,address,gender,email,password) values(@fullname,@address,@gender,@email,@password)";
                            SqlCommand command = new SqlCommand(query, connection);

                            command.Parameters.AddWithValue("@fullname", fullname.Text);
                            command.Parameters.AddWithValue("@address",address.Text);
                         
                            command.Parameters.AddWithValue("@gender", gender.Text);
                            command.Parameters.AddWithValue("@email", email.Text);
                            command.Parameters.AddWithValue("@password", password.Text);
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Registration Done ....");
                            fullname.Text = "";
                            address.Text = "";
                           
                            gender.Text = " ";
                            email.Text = "";
                            password.Text = "";
                            con_password.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("You are already registered");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password doesn't match..");
                    }
                }
                else
                {
                    MessageBox.Show("Fill in the blinks...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int check(string email)
        {
            connection.Open();
            string query = "select count(*) from admin where admin.email ='" + email + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
