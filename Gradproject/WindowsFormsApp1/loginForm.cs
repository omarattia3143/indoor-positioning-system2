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
    public partial class loginForm : UserControl
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\omarb\source\repos\indoor-positioning-system2\Gradproject\WindowsFormsApp1\Database.mdf;Integrated Security=True");
            string query = "Select * from Admin Where admin_username = '"+ username.Text.Trim() +"' and admin_password = '" + password.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                admin_tools ss = new admin_tools();
                Form fc = Application.OpenForms["admin_tools"];
                if (fc != null)
                    fc.Close();
                    ss.Show();

            }
            else
            {
                MessageBox.Show("Please, enter the correct username and admin.");
            }
        }

        private void password_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void password_OnValueChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
