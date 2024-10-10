using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public partial class service : Form
    {
        public service()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afnan\\OneDrive\\Documents\\users.mdf;Integrated Security=True;Connect Timeout=30");
        string pictuce = "";

      
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                //openFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg|jpg Files (*.jpg)|*.jpg";
                openFileDialog1.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictuce = openFileDialog1.FileName.ToString();
                    photo.ImageLocation = pictuce;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :"+ ex.Message);

            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (service_id.Text != " " && brand.Text != "" && model.Text != "" && issue.Text != "" && email.Text != "")
                {
                    connection.Open();
                    string query = "insert into mobile_service(service_id,brand,model,issue,picture,email) values(@service_id,@brand,@model,@issue,@picture,@email)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@service_id", service_id.Text);
                    command.Parameters.AddWithValue("@brand", brand.Text);
                    command.Parameters.AddWithValue("@model", model.Text);
                    command.Parameters.AddWithValue("@issue", issue.Text);

                    MemoryStream memstr = new MemoryStream();
                    photo.Image.Save(memstr, photo.Image.RawFormat);
                    command.Parameters.AddWithValue("picture", memstr.ToArray());

                    command.Parameters.AddWithValue("@email", email.Text);
                  
                   

                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show(" Wait 3 days for Service Center Reply....");
                    service_id.Text = "";
                    brand.Text = "";
                    model.Text = "";
                    issue.Text = "";
                    photo.Image = null; // Clear the PictureBox
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

        private void button4_Click(object sender, EventArgs e)
        {
            reply_service_center rs = new reply_service_center();
            rs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            service_id.Clear();

            brand.Clear();
            model.Clear();
            issue.Clear();
            email.Clear();

        }
    }
    }



