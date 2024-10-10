using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace project_1
{
    public partial class orderrequest : Form
    {
        public orderrequest()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void color_available_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* {
                 OpenFileDialog openFileDialog1 = new OpenFileDialog();
                 //  openFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg|jpg Files (*.jpg)|*.jpg";
               //  if (openFileDialog1.ShowDialog() == DialogResult.OK)
                 {
                    // picloc = openFileDialog1.FileName.ToString();
                    // customerpic.ImageLocation = picloc;

                 }
             }*/
        }

            private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                if (order_id.Text != " " && brand.Text != "" && model.Text != "" && ram.Text != "" && internal_storage.Text != "" && color_available.Text != "" && expandable_memory.Text != "" && email.Text != "")
                {
                    connection.Open();
                    string query = "insert into order_request(order_id,brand,model,ram,internal_storage,color,expandable_memory,email) values(@order_id,@brand,@model,@ram,@internal_storage,@color_available,@expandable_memory,@email)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@order_id", order_id.Text);
                    command.Parameters.AddWithValue("@brand", brand.Text);

                    command.Parameters.AddWithValue("@model", model.Text);
                    command.Parameters.AddWithValue("@ram", ram.Text);
                    command.Parameters.AddWithValue("@internal_storage",internal_storage.Text);
                    command.Parameters.AddWithValue("@color_available", color_available.Text);
                    command.Parameters.AddWithValue("@expandable_memory", expandable_memory.Text);

                    command.Parameters.AddWithValue("@email", email.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show(" After 3 days you can purchase this phone from Stock ....");
                    order_id.Text = "";
                    brand.Text = "";
                    model.Text = "";
                    ram.Text = "";
                    internal_storage.Text = "";
                    color_available.Text = "";
                    expandable_memory.Text = "";

                    email.Text = "";

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

        private void button2_Click(object sender, EventArgs e)
        {
            order_id.Clear();
            model.Clear();
            brand.Clear();
            ram.SelectedIndex = -1;
            internal_storage.SelectedIndex = -1;
            expandable_memory.SelectedIndex = -1;
            email.Clear();
            color_available.SelectedIndex = -1;

        }
    }
}
    

