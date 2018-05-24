using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1 {
    public partial class deviceInfo : Form {
        public deviceInfo() {
            InitializeComponent();
            OverRide.ForeColor = Color.White;
        }

        public void initialize(Device mydevice) {
            name.Text = mydevice.device_name;
            group.Text = "No Group";
            address.Text = mydevice.device_bluetooth_address;
            if(mydevice.Group != null)
                group.Text = mydevice.Group.group_name;
            info.Text = mydevice.device_info;
            if (mydevice.device_picture == null) {
                pictureBox1.Image = Resources.nomanbig;
            } else {
                pictureBox1.Image = ConvertToImage(mydevice.device_picture);
            }
            if (mydevice.device_icon == null) {
                myicon.Image = Resources.noman;
            } else {
                myicon.Image = ConvertToImage(mydevice.device_icon);
            }
            OverRide.Checked = mydevice.device_override_group_icon;
        }

        public static Image ConvertToImage(System.Data.Linq.Binary iBinary) {
            var arrayBinary = iBinary.ToArray();
            Image rImage = null;

            using (MemoryStream ms = new MemoryStream(arrayBinary)) {
                rImage = Image.FromStream(ms);
            }
            return rImage;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e) {
            this.Close();
        }

        private void header_Paint(object sender, PaintEventArgs e) {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e) {
            if (WindowState.ToString() == "Normal") {
                this.WindowState = FormWindowState.Maximized;
            } else {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void createAdmin1_Load(object sender, EventArgs e) {

        }

        private void minimize_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void createAdmin_Load(object sender, EventArgs e) {

        }


        private void tile1_Click(object sender, EventArgs e) {

        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void createAdmin_Load_1(object sender, EventArgs e) {

        }

    }
}
