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
    public partial class purchase : Form
    {
        public purchase()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void payment_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void payment_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void payment_method_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }


        private void model_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Use parameterized query to prevent SQL injection
            string query = "select * from add_phone where model = @model";

            // Establish connection
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                // Create command
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@model", model.Text);  // Use parameters to prevent SQL injection

                // Execute command
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Check if any row is returned
                if (dt.Rows.Count > 0)
                {
                    // Access the appropriate field in the DataTable and assign it to TextBoxes
                    ram.Text = dt.Rows[0]["ram"].ToString();
                    internal_storage.Text = dt.Rows[0]["internal_storage"].ToString();

                    expandable_memory.Text = dt.Rows[0]["expandable_memory"].ToString();

                    rear_camera.Text = dt.Rows[0]["rear_camera"].ToString();

                    front_camera.Text = dt.Rows[0]["front_camera"].ToString();

                    sensor.Text = dt.Rows[0]["fingerprint_sensor"].ToString();

                    price.Text = dt.Rows[0]["price"].ToString();

                }
                else
                {
                    MessageBox.Show("No data found for the selected model.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Ensure connection is properly closed
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        private void company_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.Items.Clear();
            String com = company.Text;
           string query = "select model  from add_phone where company='" + com + "'";
            setComboBOX(query, model);
        }
        public SqlDataReader getForCombo(string query)
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            connection.Open();
            cmd = new SqlCommand(query, connection);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;

        }
        public void setComboBOX(String query,ComboBox combo)
        {
            SqlDataReader sdr = getForCombo(query);
            while (sdr.Read())
            {
                for(int i=0; i<sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
        }

        private void panel1_Enter(object sender, EventArgs e)
        {
            company.Items.Clear();
            string query = " select distinct company from add_phone";

            setComboBOX(query, company);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {

                if (payment_id.Text != " " && email.Text != "" && payment_date.Text != "" && payment_method.Text != "" && address.Text != "" && company.Text != "" && model.Text != "" && price.Text != "")
                {
                    connection.Open();
                    string query = "insert into payment(payment_id,customer_email,payment_date,payment_method,address,company,model,price) values(@payment_id,@email,@payment_date,@payment_method,@address,@company,@model,@price)";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlCommand cmd = new SqlCommand("delete add_phone where model=@model", connection);
                    cmd.Parameters.AddWithValue("@model", model.Text);
                    cmd.ExecuteNonQuery();
                    command.Parameters.AddWithValue("@payment_id",payment_id.Text);
                    command.Parameters.AddWithValue("@email", email.Text);

                    command.Parameters.AddWithValue("@payment_date", payment_date.Text);
                    command.Parameters.AddWithValue("@payment_method", payment_method.Text);
                    command.Parameters.AddWithValue("@address", address.Text);
                    command.Parameters.AddWithValue("@company", company.Text);
                    command.Parameters.AddWithValue("@model", model.Text);
                 
                    command.Parameters.AddWithValue("@price", price.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Purchase Successfull ....");

                    payment_id.Text = "";
                    email.Text = "";
                    payment_date.Text = "";
                    payment_method.Text = "";
                    address.Text = "";
                    company.Text = "";
                    model.Text = "";

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
    }
    }


