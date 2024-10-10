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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace project_1
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
            showusers();
            ConfigureDataGridView();
        }

        private void showusers()
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from add_phone", connection);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the current row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Display values from the row in TextBoxes
                company.Text = row.Cells["company"].Value.ToString();

                model.Text = row.Cells["model "].Value.ToString();
                ram.Text = row.Cells["ram"].Value.ToString();
                internal_storage.Text = row.Cells["internal_storage"].Value.ToString();
                expandable_memory.Text = row.Cells["expandable_memory"].Value.ToString();

                display.Text = row.Cells["display"].Value.ToString();
                rear_camera.Text = row.Cells["rear_camera"].Value.ToString();
                front_camera.Text = row.Cells["front_camera"].Value.ToString();

                fingerprint_sensor.Text = row.Cells["fingerprint_sensor"].Value.ToString();

                battery.Text = row.Cells["battery"].Value.ToString();

                serial_number.Text = row.Cells["serial_number"].Value.ToString();

                network_type.Text = row.Cells["network_type"].Value.ToString();

                color_available.Text = row.Cells["color_available"].Value.ToString();

                price.Text = row.Cells["price"].Value.ToString();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from add_phone where price between 10000 and 30000", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from add_phone where price between 30000 and 70000", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from add_phone where price >=70000", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from add_phone ", connection);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
