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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace project_1
{
    public partial class reply_service_center : Form
    {
        public reply_service_center()
        {
            InitializeComponent();
            showservice_center();
            ConfigureDataGridView();
        }

        private void showservice_center()
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from service_center", connection);

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
        private void reply_service_center_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from service_center where service_id = @service_id", connection);
            cmd.Parameters.AddWithValue("@service_id",service_id.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {


            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from service_center ", connection);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
