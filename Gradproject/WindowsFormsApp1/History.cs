using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class History : Form {
        public static DateTime startDate, endDate;
        public List<Device> mydevices;
        public History()
        {
            InitializeComponent();
            var dbContext = new DatabaseEntities1(); //class derived from DbContext
            mydevices = (from c in dbContext.Devices select c).ToList();
            checkedListBox1.DisplayMember = "device_name";
            foreach (Device myd in mydevices) {
                checkedListBox1.Items.Add(myd);
            }
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        
        private void c1ZoomPanel1_ZoomFactorChanged(object sender, EventArgs e)
        {

        }

        private void c1Zoom1_ZoomFactorChanged(object sender, EventArgs e)
        {

        }

        

        private void customize_view_Click_1(object sender, EventArgs e)
        {

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

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginForm1_Load(object sender, EventArgs e)
        {

        }
        
        private void continueButton_Click(object sender, EventArgs e)
        {
            // Create From to dates
            DateTime myfromDate = new DateTime(fromDate.Value.Year, fromDate.Value.Month, fromDate.Value.Day,
                fromTime.Value.Hour, fromTime.Value.Minute, fromTime.Value.Second);
            DateTime mytoDate = new DateTime(toDate.Value.Year, toDate.Value.Month, toDate.Value.Day,
                 toTime.Value.Hour, toTime.Value.Minute, toTime.Value.Second);
            // query
            startDate = myfromDate;
            endDate = mytoDate;
            if (endDate <= startDate)
                return;

            List<Device> myselectedItems = checkedListBox1.CheckedItems.Cast<Device>().ToList();
            List<int> myselItemsID = new List<int>();
            foreach (Device x in myselectedItems) {
                myselItemsID.Add(x.device_id);
            }
            var dbContext = new DatabaseEntities1(); //class derived from DbContext
            var myRecords = (from c in dbContext.Records
                             where 
                             c.record_time < mytoDate && c.record_time > myfromDate && myselItemsID.Contains(c.device_id)
                             select c).ToList(); //read data
            history_Galal1.inisializeMap();
            history_Galal1.initializeHistoryFunctions(startDate.TrimMilliseconds(), endDate.TrimMilliseconds(), myRecords, myselectedItems);
            panel1.BringToFront();
            history_Galal1.BringToFront();
            historypanel.SendToBack();

        }

        private void history_Map1_Load(object sender, EventArgs e)
        {

        }
    }
}
