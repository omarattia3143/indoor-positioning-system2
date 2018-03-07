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
using System.IO;
using System.Windows.Forms.Design;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class CreateUser : UserControl
    {
        private string fileName;
        private string fileName_icon;
        private string fileName_picture;
        private int groupID;

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\source\repos\indoor-positioning-system2\Gradproject\WindowsFormsApp1\Database.mdf;Integrated Security=True");


        public CreateUser()
        {
            InitializeComponent();
            fillComboGroup();

        }

        private void fillComboGroup()
        {
            try
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("select * from Groups", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                string groupNames = reader["group_name"].ToString();
                                comboBox1.Items.Add(groupNames);
                            }
                        }
                    }

                }

                connection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }



        private byte[] saveImage(string fileName)
        {
            byte[] imageBt = null;
            FileStream fstream = new FileStream(this.fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
           return imageBt = br.ReadBytes((int)fstream.Length);
        }

        private void createBtn2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            byte[] picture = null;
            FileStream fstream1 = new FileStream(this.fileName_picture, FileMode.Open, FileAccess.Read);
            BinaryReader br1 = new BinaryReader(fstream1);
            picture = br1.ReadBytes((int)fstream1.Length);

            byte[] icon = null;
            FileStream fstream = new FileStream(this.fileName_icon, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            icon = br.ReadBytes((int)fstream.Length);


            cmd.Parameters.Add(new SqlParameter("@IMG", picture));
            cmd.Parameters.Add(new SqlParameter("@ICON", icon));

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Device(device_picture,device_name,device_bluetooth_address,device_icon,device_info,device_override_group_icon,group_id) values(@IMG,'" + nameTextbox.Text +
                              "','" + macTextbox.Text + "',@ICON,'" + descriptionBox.Text + "','" + checkbox.Checked + "','" + groupID + "')";
            cmd.ExecuteNonQuery();
            connection.Close();




        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void nameTextbox_OnValueChanged(object sender, EventArgs e)
        {

        }

        
        private void avatar_Click(object sender, EventArgs e)
        {
            fileName_picture = spawnImage(avatar);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fileName_icon = spawnImage(icon);
        }

        private string spawnImage(PictureBox imagebox)
        {
            using (FileDialog ofd = new OpenFileDialog()
            {
                Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*",
                ValidateNames = true,
                Multiselect = false
            })
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    imagebox.Image = Image.FromFile(fileName);
                }
            return fileName;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("select * from Groups where group_name = '" + comboBox1.Text + "'", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                groupID = (int)reader["group_id"];
                            }
                        }
                    }

                }

                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
