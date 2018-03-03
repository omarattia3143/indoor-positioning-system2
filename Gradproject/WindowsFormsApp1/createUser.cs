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
    public partial class CreateUser1 : UserControl
    {
        private string fileName;
        private string[] paths = { };


        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\omarb\source\repos\indoor-positioning-system2\Gradproject\WindowsFormsApp1\Database.mdf;Integrated Security=True");


        public CreateUser1()
        {
            InitializeComponent();
            CreateUser1_Load();
            populate();

        }

        private void CreateUser1_Load()
        {
            listView1.View = View.Details;

            listView1.Columns.Add("Icon Name", 250);


        }

        private void populate()
        {
            ImageList images = new ImageList();
            images.ImageSize = new Size(50,50);

            paths = Directory.GetFiles("C:/Users/omarb/Desktop/asd");

            try
            {
                foreach (string path in paths)
                {
                    images.Images.Add(Image.FromFile(path));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            listView1.SmallImageList = images;
            listView1.Items.Add("1",0);
            listView1.Items.Add("2", 1);
            listView1.Items.Add("3", 2);
            listView1.Items.Add("4", 3);

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
        {            // save image
            byte[] imageBt = null;
            FileStream fstream = new FileStream(this.fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);


            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.Parameters.Add(new SqlParameter("@IMG", imageBt));
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Device(device_name,device_bluetooth_address,device_picture) values('" + nameTextbox.Text +
                              "','" + macTextbox.Text + "',@IMG)";
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
