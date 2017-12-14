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

namespace WindowsFormsApp1
{
    public partial class viewDevices : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        public viewDevices()
        {
            InitializeComponent();
        }

        public void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Device";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            datagrid.DataSource = dt;
            connection.Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            // createAdmin.BringToFront();
        }



        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

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

        private void createAdmin1_Load(object sender, EventArgs e)
        {
            display_data();

        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void createAdmin_Load(object sender, EventArgs e)
        {

        }


        private void adminBtn_Click_2(object sender, EventArgs e)
        {
            
        }

        private void tile1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createAdmin_Load_1(object sender, EventArgs e)
        {

        }

        private void viewDevices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet2.Device' table. You can move, or remove it, as needed.
            this.deviceTableAdapter1.Fill(this.databaseDataSet2.Device);
            // TODO: This line of code loads data into the 'databaseDataSet1.Device' table. You can move, or remove it, as needed.
          //  this.deviceTableAdapter.Fill(this.databaseDataSet1.Device);

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Device where device_name='" + name.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            display_data();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            panel3.SendToBack();
            createUser1.BringToFront();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Device where device_name='" + name.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            datagrid.DataSource = dt;
            connection.Close();
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            panel3.SendToBack();
            createUser1.BringToFront();
        }

        private void name_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Device where device_name='" + name.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                datagrid.DataSource = dt;
                connection.Close();
            }
        }

        private void createUser1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
