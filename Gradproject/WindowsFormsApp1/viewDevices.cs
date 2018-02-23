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
        public static string editName;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\omarb\source\repos\indoor-positioning-system2\Gradproject\WindowsFormsApp1\Database.mdf;Integrated Security=True");
        public viewDevices()
        {
            InitializeComponent();
            display_data();
        }

        public void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Device";
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
            // TODO: This line of code loads data into the 'databaseDataSet3.View' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'databaseDataSet2.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.databaseDataSet2.Admin);
            // TODO: This line of code loads data into the 'databaseDataSet2._Device_Boundary' table. You can move, or remove it, as needed.
            this.device_BoundaryTableAdapter.Fill(this.databaseDataSet2._Device_Boundary);
            // TODO: This line of code loads data into the 'databaseDataSet2.Record' table. You can move, or remove it, as needed.
            this.recordTableAdapter.Fill(this.databaseDataSet2.Record);
            // TODO: This line of code loads data into the 'databaseDataSet2.Device' table. You can move, or remove it, as needed.
            this.deviceTableAdapter1.Fill(this.databaseDataSet2.Device);
            // TODO: This line of code loads data into the 'databaseDataSet1.Device' table. You can move, or remove it, as needed.
            //  this.deviceTableAdapter.Fill(this.databaseDataSet1.Device);

            /////////////////////////////////DROP LIST CODE
            editName = name.Text;
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Device inner join Groups on Device.group_id = Groups.group_id";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //CreateUser1.comboBox1.Items.Add(reader["group_name"].ToString());
            }
            connection.Close();
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
            createUser11.BringToFront();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Device where device_name = '" + name.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            datagrid.DataSource = dt;
            connection.Close();
        }

        public void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.datagrid.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                createUser11.nameTextbox.Text = row.Cells[0].Value.ToString();
                name.Text = row.Cells[1].Value.ToString();
                createUser11.macTextbox.Text = row.Cells[1].Value.ToString();
                createUser11.descriptionBox.Text = row.Cells[3].Value.ToString();
                createUser11.comboBox1.Text = row.Cells[5].Value.ToString();

            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            createUser11.nameTextbox.Text = "";
            createUser11.macTextbox.Text = "";
            createUser11.descriptionBox.Text = "";
            panel3.SendToBack();
            createUser11.BringToFront();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void name_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
