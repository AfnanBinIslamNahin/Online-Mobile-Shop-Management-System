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
    public partial class service_center : Form
    {
        public service_center()
        {
            InitializeComponent();
            showmoble_service();
        }


        private void showmoble_service()
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from  mobile_service  ", connection);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.RowTemplate.Height = 75;
            dataGridView1.DataSource = dt;
            DataGridViewImageColumn pic1 = new DataGridViewImageColumn();
            pic1 = (DataGridViewImageColumn)dataGridView1.Columns[4];
            pic1.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void service_center_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            technician_Id.Clear();
            solution.Clear();
            service_id.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                if (technician_Id.Text != " " && solution.Text != "" && service_id.Text != "")
                {
                    connection.Open();
                    string query = "insert into service_center(technician_Id,solution,service_id) values(@technician_Id,@solution,@service_id)";
                    SqlCommand command = new SqlCommand(query, connection);

                  
                    command.Parameters.AddWithValue("@technician_Id", technician_Id.Text);
                    command.Parameters.AddWithValue("@solution", solution.Text);

                    command.Parameters.AddWithValue("@service_id", service_id.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("send ....");

                    technician_Id.Text = "";
                    solution.Text = "";
                   service_id.Text = "";
                   


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
    
