using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Beacon_Config : Form {
        public Beacon_Config() {
            InitializeComponent();
            beacon_Config_map1.initializeHistoryFunctions();
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
