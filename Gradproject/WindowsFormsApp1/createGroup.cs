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
    public partial class createGroup : UserControl
    {
        private string fileName;
        private string fileName_icon;
        private string fileName_picture;
        private int groupID;

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\source\repos\indoor-positioning-system2\Gradproject\WindowsFormsApp1\Database.mdf;Integrated Security=True");


        public createGroup()
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
            cmd.Parameters.Add(new SqlParameter("@IMG", saveImage(fileName_picture)));
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Groups(group_name,group_info,group_icon) values('" + nameTextbox.Text + "','" + descriptionBox.Text + "',@IMG)";
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
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void avatar_Click(object sender, EventArgs e)
        {
            fileName_picture = spawnImage(avatar);
        }
    }
}
