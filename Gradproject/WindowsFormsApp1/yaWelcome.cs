using SharpCompress.Archives;
using SharpCompress.Archives.Rar;
using SharpCompress.Readers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class yaWelcome : Form {
        public yaWelcome() {
            InitializeComponent();
            //alreadyImported();
        }

        private void alreadyImported() {
            string MapsPath = AppDomain.CurrentDomain.BaseDirectory + "Maps";
            if (!System.IO.Directory.Exists(MapsPath)) {
                return;
            }
            System.IO.Directory.CreateDirectory(MapsPath);
            String[] directories = Directory.GetDirectories(MapsPath);
            for (int i = 0; i < directories.Length; i++) {
                if (!File.Exists(directories[i] + "/Rooms.shp") ||
                    !File.Exists(directories[i] + "/Coverage.shp") ||
                    !File.Exists(directories[i] + "/Beacons.shp")) {
                    errorText.Text = "Error Reading the file!";
                    errorText.Visible = true;
                    return;
                }
            }
            mapForm ss = new mapForm();
            Form fc = Application.OpenForms["mapForm"];
            if (fc != null)
                fc.Close();
            ss.Show();
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

        private void button1_Click(object sender, EventArgs e) {
            string MapsPath = AppDomain.CurrentDomain.BaseDirectory + "Maps";
            if (System.IO.Directory.Exists(MapsPath)) {
                Directory.Delete(MapsPath, true);
                while (Directory.Exists(MapsPath)) Thread.Sleep(0);
            }
            System.IO.Directory.CreateDirectory(MapsPath);
            String[] directories = Directory.GetDirectories(MapsPath);
            if (directories.Length == 0) {
                //Console.WriteLine( selectfile());
                using (var archive = RarArchive.Open(selectfile())) {
                    foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory)) {
                        entry.WriteToDirectory(MapsPath, new ExtractionOptions() {
                            ExtractFullPath = true
                        });
                    }
                }
                directories = Directory.GetDirectories(MapsPath);
                if (directories.Length == 0) {
                    errorText.Text = "Error Reading the file!";
                    errorText.Visible = true;
                    return;
                }
                for (int i = 0; i < directories.Length; i++) {
                    if (!File.Exists(directories[i] + "/Rooms.shp") ||
                        !File.Exists(directories[i] + "/Coverage.shp") ||
                        !File.Exists(directories[i] + "/Beacons.shp") ) {
                        errorText.Text = "Error Reading the file!";
                        errorText.Visible = true;
                        return;
                    }
                }
                errorText.Text = "Success!";
                errorText.Visible = true;
                /*System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
                this.Close();*/
                this.Hide();
                mapForm ss = new mapForm();
                Form fc = Application.OpenForms["mapForm"];
                if (fc != null)
                    fc.Close();
                ss.Show();
                ss.Closed += (s, args) => this.Close();
                //this.Close();
            }
        }

        private String selectfile() {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "*.zip|*.rar";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;
            if (choofdlog.ShowDialog() == DialogResult.OK) {
                string sFileName = choofdlog.FileName;
                return sFileName;
                //string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true           
            } else {
                if (System.Windows.Forms.Application.MessageLoop) {
                    // WinForms app
                    System.Windows.Forms.Application.Exit();
                } else {
                    // Console app
                    System.Environment.Exit(1);
                }
            }
            return "";
        }
    }
}
