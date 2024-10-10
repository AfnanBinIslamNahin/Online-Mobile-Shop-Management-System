using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project_1
{
    public partial class admin_dashboard : Form
    {
        public admin_dashboard()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void admin_dashboard_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count (*) from users",connection);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            user.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("select count (*) from add_phone", connection);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            mobile_stock.Text = dt2.Rows[0][0].ToString();

            SqlDataAdapter sda3 = new SqlDataAdapter("select count (*) from order_request", connection);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            order_request.Text = dt3.Rows[0][0].ToString();

            SqlDataAdapter sda4 = new SqlDataAdapter("select count (*) from payment", connection);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            phone_purchase.Text = dt4.Rows[0][0].ToString();
           

            SqlDataAdapter sda5 = new SqlDataAdapter("select count (*) from service_center", connection);
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);
            service_center.Text = dt5.Rows[0][0].ToString();
            connection.Close();
        }
    }
}
