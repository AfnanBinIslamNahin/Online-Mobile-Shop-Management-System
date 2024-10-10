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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project_1
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
            ConfigureDataGridView();
            showusers();
        
        }

        private void showusers()
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from users", connection);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void date_ValueChanged(object sender, EventArgs e)
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
       

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                if (f_name.Text != "" && l_name.Text != "" && date.Text != "" && gender.Text != "" && email.Text != "" && password.Text != "" && con_password.Text != "")
                {
                    if (password.Text == con_password.Text)
                    {
                        int v = check(email.Text);
                        if (v != 1)
                        {
                            connection.Open();
                            string query = "insert into users(f_name,l_name,date,gender,address,email,password) values(@f_name,@l_name,@date,@gender,@address,@email,@password)";
                            SqlCommand command = new SqlCommand(query, connection);

                            command.Parameters.AddWithValue("@f_name", f_name.Text);
                            command.Parameters.AddWithValue("@l_name", l_name.Text);
                            command.Parameters.AddWithValue("@date", Convert.ToDateTime(date.Text));
                            command.Parameters.AddWithValue("@gender", gender.Text);
                            command.Parameters.AddWithValue("@address", address.Text);
                            command.Parameters.AddWithValue("@email", email.Text);
                            command.Parameters.AddWithValue("@password", password.Text);
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show(" ADDED ....");
                            f_name.Text = "";
                            l_name.Text = "";
                            date.Text = "";
                            gender.Text = " ";
                            address.Text = "";
                            email.Text = "";
                            password.Text = "";
                            con_password.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("You are already ADDED THIS USER");
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
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            connection.Open();
            string query = "select count(*) from users where users.email ='" + email + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            connection.Open();
            SqlCommand cmd = new SqlCommand("delete users where id=@id", connection);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Successfully delete");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            connection.Open();
            SqlCommand command= new SqlCommand("update users set f_name=@f_name,l_name=@l_name,date=@date,gender=@gender,address=@address,password =@password where email=@email", connection);

            command.Parameters.AddWithValue("@f_name", f_name.Text);
            command.Parameters.AddWithValue("@l_name", l_name.Text);
            command.Parameters.AddWithValue("@date", Convert.ToDateTime(date.Text));
            command.Parameters.AddWithValue("@gender", gender.Text);
            command.Parameters.AddWithValue("@address", address.Text);
            command.Parameters.AddWithValue("@email", email.Text);
            command.Parameters.AddWithValue("@password", password.Text);
           command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Successfully update");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from users where email = @email", connection);
            cmd.Parameters.AddWithValue("@email", email.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void user_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user clicks on a valid row (not the header row)
            if (e.RowIndex >= 0)
            {
                // Get the current row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Display values from the row in TextBoxes
                f_name.Text = row.Cells["f_name"].Value.ToString();
                l_name.Text = row.Cells["l_name"].Value.ToString();
                email.Text = row.Cells["email"].Value.ToString();
                date.Text = row.Cells["date"].Value.ToString();
                gender.Text = row.Cells["gender"].Value.ToString();

                password.Text = row.Cells["password"].Value.ToString();
                address.Text = row.Cells["address"].Value.ToString();
            }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

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

        private void button5_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from users ", connection);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void con_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            // Ensure the user clicks on a valid row (not the header row)
            if (e.RowIndex >= 0)
            {
                // Get the current row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Display values from the row in TextBoxes
                f_name.Text = row.Cells["f_name"].Value.ToString();
                l_name.Text = row.Cells["l_name"].Value.ToString();
                email.Text = row.Cells["email"].Value.ToString();
                date.Text = row.Cells["date"].Value.ToString();
                gender.Text = row.Cells["gender"].Value.ToString();

                password.Text = row.Cells["password"].Value.ToString();
                address.Text = row.Cells["address"].Value.ToString();
            }
        }
    }
    }

