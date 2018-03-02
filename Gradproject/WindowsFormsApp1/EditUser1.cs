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
    public partial class EditUser1 : UserControl
    {
        private string fileName;
        private List<Device> list;

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\omarb\source\repos\indoor-positioning-system2\Gradproject\WindowsFormsApp1\Database.mdf;Integrated Security=True");


        public EditUser1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void password_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void username_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void createBtn2_Click(object sender, EventArgs e)
        {
            byte[] imageBt = null;
            FileStream fstream = new FileStream(this.fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);


            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.Parameters.Add(new SqlParameter("@IMG", imageBt));
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Device set device_name='"+nameTextbox.Text+"',device_bluetooth_address='"+macTextbox.Text+"',device_picture=@IMG where device_name='"+nameTextbox.Text+"'";
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

        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void avatar_Click(object sender, EventArgs e)
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
                    avatar.Image = Image.FromFile(fileName);
                }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
