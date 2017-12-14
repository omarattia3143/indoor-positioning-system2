using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class createAdmin : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");    

        public createAdmin()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.adminTableAdapter.Fill(this.databaseDataSet.Admin);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Admin";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
            connection.Close();
        }

        private void createAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet2.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter1.Fill(this.databaseDataSet2.Admin);
            display_data();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            if (password.Text == password2.Text)
            {
                
                cmd.CommandText = "insert into Admin values('" + username.Text + "','" + password.Text + "')";
                cmd.ExecuteNonQuery();
            }
            else { MessageBox.Show("Passwords don't match!"); }
            connection.Close();
            display_data();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Admin where username='"+username.Text+"'";
            cmd.ExecuteNonQuery();
            connection.Close();
            display_data();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Admin where username='"+username.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
            connection.Close();
        }

        private void image1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
