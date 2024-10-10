using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public partial class Review : Form
    {
        public Review()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;");

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                if (review_id.Text != " " && customer_email.Text != "" && message.Text != "" && company.Text != "" && model.Text != "")
                {
                    connection.Open();
                    string query = "insert into review(review_id,customer_email,message,company,model) values(@review_id,@customer_email,@message,@company,@model)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@review_id", review_id.Text);
                    command.Parameters.AddWithValue("@customer_email", customer_email.Text);
                    command.Parameters.AddWithValue("@message", message.Text);
                    command.Parameters.AddWithValue("@company", company.Text);
                    command.Parameters.AddWithValue("@model", model.Text);

                 
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Review send successfull....");
                    review_id.Text = "";
                    customer_email.Text = "";
                    message.Text = "";
                    company.Text = "";
                    model.Text = "";

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

        private void button3_Click(object sender, EventArgs e)
        {

            review_id.Clear();
            customer_email.Clear();
            message.Clear();
            company.Clear();
            model.Clear();
                
           
        }
    }
}
