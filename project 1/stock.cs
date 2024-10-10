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
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
            showstock();
            ConfigureDataGridView();
            
        }
        private void showstock()
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from add_phone", connection);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void ConfigureDataGridView()
        {
            // Set alternating row colors for readability
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Set header styles
            dataGridView1.EnableHeadersVisualStyles = false;

            // dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 0, 255, 255);  // Cyan
            // dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192, 192); // Silver
            // dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 0, 0);    // Red
            // dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 0, 0, 255);   // Blue
            //  dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 0, 255, 0);  // Green
            // dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192, 192); // Silver
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 0, 255); // Magenta
            // dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 0, 255, 0); // Lime
            // dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 169, 169, 169); // Dark Gray
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 215, 0); // Gold

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Set grid line color
            dataGridView1.GridColor = Color.Black;

            // Set default row styles
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Set selection styles
            //  dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Brown;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fit columns to the DataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Adjust row height to fit content
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Disable column resize by the user for a consistent layout
            dataGridView1.AllowUserToResizeColumns = false;

            // Set row and column headers visibility if needed
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from add_phone ", connection);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from add_phone where company = @company", connection);
            cmd.Parameters.AddWithValue("@company", company.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            connection.Open();
            SqlCommand command = new SqlCommand("update add_phone set company=@company, model=@model,battery=@battery,price=@price,rear_camera =@rear_camera,front_camera=@front_camera ,network_type =@network_type where serial_number=@serial_number", connection);

            command.Parameters.AddWithValue("@company", company.Text);
            command.Parameters.AddWithValue("@model", model.Text);
            command.Parameters.AddWithValue("@battery",battery.Text);
            command.Parameters.AddWithValue("@price", price.Text);
            command.Parameters.AddWithValue("@rear_camera", rear_camera.Text);
            command.Parameters.AddWithValue("@front_camera", front_camera.Text);
            command.Parameters.AddWithValue("@network_type", network_type.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Successfully update");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            connection.Open();
            SqlCommand cmd = new SqlCommand("delete add_phone where serial_number=@serial_number", connection);
            cmd.Parameters.AddWithValue("@serial_number", serial_number.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Successfully delete");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user clicks on a valid row (not the header row)
            if (e.RowIndex >= 0)
            {
                // Get the current row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Display values from the row in TextBoxes
                company.Text = row.Cells["company"].Value.ToString();
                model.Text = row.Cells["model "].Value.ToString();
                battery.Text = row.Cells["battery"].Value.ToString();
                price.Text = row.Cells["price"].Value.ToString();
                rear_camera.Text = row.Cells["rear_camera"].Value.ToString();

                front_camera.Text = row.Cells["front_camera"].Value.ToString();
                serial_number.Text = row.Cells["serial_number"].Value.ToString();

                network_type.Text = row.Cells["network_type"].Value.ToString();
            }
        }

        private void stock_Load(object sender, EventArgs e)
        {

        }
    }
}
