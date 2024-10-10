using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace project_1
{
    public partial class Add_mobile : Form
    {
        public Add_mobile()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

        private void Add_mobile_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (company.Text != " " && model.Text != "" && ram.Text != "" && internal_storage.Text != "" && expandable_memory.Text != "" && display.Text != "" && serial_number.Text != "" && rear_camera.Text != "" && front_camera.Text != "" && fingerprint_sensor.Text != "" && battery.Text != "" && network_type.Text != "" && color_available.Text != "" && price.Text != "")
                {
                    connection.Open();
                    string query = "insert into add_phone(company,model,ram,internal_storage,expandable_memory,display,serial_number,rear_camera,front_camera,fingerprint_sensor,battery,network_type,color_available,price) values(@company,@model,@ram,@internal_storage,@expandable_memory,@display,@serial_number,@rear_camera,@front_camera,@fingerprint_sensor,@battery,@network_type,@color_available,@price)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@company", company.Text);
                    command.Parameters.AddWithValue("@model", model.Text);

                    command.Parameters.AddWithValue("@ram", ram.Text);
                    command.Parameters.AddWithValue("@internal_storage", internal_storage.Text);
                    command.Parameters.AddWithValue("@expandable_memory", expandable_memory.Text);
                    command.Parameters.AddWithValue("@display", display.Text);
                    command.Parameters.AddWithValue("@serial_number", int.Parse(serial_number.Text));
                    command.Parameters.AddWithValue("@rear_camera", rear_camera.Text);
                    command.Parameters.AddWithValue("@front_camera", front_camera.Text);
                    command.Parameters.AddWithValue("@fingerprint_sensor", fingerprint_sensor.Text);
                    command.Parameters.AddWithValue("@battery", battery.Text);
                    command.Parameters.AddWithValue("@network_type", network_type.Text);
                    command.Parameters.AddWithValue("@color_available", color_available.Text);
                    command.Parameters.AddWithValue("@price", price.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Save ....");
                    company.Text = "";
                    model.Text = "";

                    ram.Text = " ";
                    internal_storage.Text = "";
                    expandable_memory.Text = "";
                    display.Text = "";
                    serial_number.Text = "";
                    rear_camera.Text = "";
                    front_camera.Text = "";
                    fingerprint_sensor.Text = "";
                    battery.Text = "";
                    network_type.Text = "";
                    color_available.Text = "";
                    price.Text = "";

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

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            company.Clear();
            model.Clear();
            display.Clear();
            internal_storage.SelectedIndex = -1;
            ram.SelectedIndex = -1;
            expandable_memory.SelectedIndex = -1;
            rear_camera.Clear();
            front_camera.Clear();
            fingerprint_sensor.SelectedIndex = -1;
            battery.Clear();
            serial_number.Clear();
            network_type.Clear();
            color_available.SelectedIndex = -1;
            price.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select full_name, gender, address, email FROM admin ", connection);
                // command.Parameters.AddWithValue("@Email", email.Text);
                //command.Parameters.AddWithValue("@Password", password.Text);

                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    // Read user details
                    string name = dr["full_name"].ToString();
                    string gender = dr["gender"].ToString();
                    string address = dr["address"].ToString();
                    string email = dr["email"].ToString();

                    // Pass the data to the next form or store it for later use
                    Form4 Admin = new Form4(name, gender, address, email);
                    Admin.Show();
                    this.Hide();

                    // Reset fields
                    // email.Text = "";
                    // password.Text = "";
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            stock s = new stock();
            s.Show();
        }
    }
}
