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
        List<Beacon>[] mapBeacons;
        DatabaseEntities1 dbContext = new DatabaseEntities1(); //class derived from DbContext
        int beaconLastIndex = 0;

        public Beacon_Config() {
            InitializeComponent();
            beacon_Config_map1.initializeMap();
            beacon_Config_map1.initializeHistoryFunctions();
            //beacon_Config_map1.sfMap1[2].RenderSettings.IsSelectable = true;
            beacon_Config_map1.sfMap1.SelectedRecordsChanged += SfMap1_SelectedRecordsChanged;
            beacon_Config_map1.sfMap1.MouseClick += SfMap1_MouseClick;
            int tempFloors = 0;
            for (int i=0; i< beacon_Config_map1.sfMap1.ShapeFileCount; i+=3) {
                tempFloors++;
                floorDropList.AddItem("Floor " + tempFloors);
            }
            floorDropList.selectedIndex = 0;
            //var value = MyList.First(item => item.name == "foo").value;
            mapBeacons = new List<Beacon>[tempFloors];
            for (int i = 0; i<tempFloors; i++) {
                beacon_Config_map1.sfMap1[(3 * i) + 2].RenderSettings.SelectOutlineColor = Color.Red;
                mapBeacons[i] = (from c in dbContext.Beacons where c.beacon_floor == i select c).ToList();
            }
            updateBeaconsCombo(0);
            beacon_Config_map1.sfMap1[(3*beacon_Config_map1.SelectedFloor)+ 2].SelectRecord(0,true);
            macAddressTextBox.Text = mapBeacons[beacon_Config_map1.SelectedFloor][0].beacon_bluetooth_address;
            beaconCombo.selectedIndex = 0;
        }

        private void updateBeaconsCombo(int index) {
            beaconCombo.Clear();
            for (int i = 0; i < mapBeacons[index].Count; i++) {
                beaconCombo.AddItem("Beacon " + (i+1));//mapBeacons[index][i].beacon_idonmap);
            }
        }

        private void SfMap1_MouseClick(object sender, MouseEventArgs e) {
            //throw new NotImplementedException();
            if (e.Button == System.Windows.Forms.MouseButtons.Left) {
                Console.WriteLine("X = " + beacon_Config_map1.sfMap1.MousePosToGisPoint(e.Location).X +
                    ", Y = " + beacon_Config_map1.sfMap1.MousePosToGisPoint(e.Location).Y);
            }

        }

        private void SfMap1_SelectedRecordsChanged(object sender, EventArgs e) {
            Console.WriteLine("An Item was Selected");
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

        private void addressTextBox_TextChanged(object sender, EventArgs e) {

        }

        private void floorDropList_onItemSelected(object sender, EventArgs e) {
            if (floorDropList.selectedIndex != beacon_Config_map1.SelectedFloor) {
                mapBeacons[beacon_Config_map1.SelectedFloor][beaconLastIndex].beacon_bluetooth_address = macAddressTextBox.Text;
                int tempint = beacon_Config_map1.SelectedFloor * 3;
                for (int i = 0; i < 3; i++) {
                    beacon_Config_map1.makeLayerInvisible(tempint + i);
                }
                beacon_Config_map1.SelectedFloor = floorDropList.selectedIndex;
                tempint = beacon_Config_map1.SelectedFloor * 3;
                for (int i = 0; i < 3; i++) {
                    //if (i == 1)
                    //    continue;
                    beacon_Config_map1.makeLayerVisible(tempint + i);
                }
                // beacon Combo
                macAddressTextBox.Text = mapBeacons[beacon_Config_map1.SelectedFloor][0].beacon_bluetooth_address;
                updateBeaconsCombo(beacon_Config_map1.SelectedFloor);
                beaconLastIndex = 0;
                beaconCombo.selectedIndex = 0;
                beacon_Config_map1.sfMap1[(3 * beacon_Config_map1.SelectedFloor) + 2].ClearSelectedRecords();
                beacon_Config_map1.sfMap1[(3 * beacon_Config_map1.SelectedFloor) + 2].SelectRecord(0, true);
                // beacon Combo
                beacon_Config_map1.sfMap1.FitToExtent(beacon_Config_map1.sfMap1[tempint].GetActualExtent());
            }
        }

        private void zoomOut_Click(object sender, EventArgs e) {
            beacon_Config_map1.sfMap1.Refresh();
            beacon_Config_map1.sfMap1.FitToExtent(beacon_Config_map1.sfMap1[beacon_Config_map1.SelectedFloor * 3].GetActualExtent());
        }

        private void beaconCombo_onItemSelected(object sender, EventArgs e) {
            mapBeacons[beacon_Config_map1.SelectedFloor][beaconLastIndex].beacon_bluetooth_address = macAddressTextBox.Text;
            beacon_Config_map1.sfMap1[(3 * beacon_Config_map1.SelectedFloor) + 2].ClearSelectedRecords();
            beacon_Config_map1.sfMap1[(3 * beacon_Config_map1.SelectedFloor) + 2].SelectRecord(beaconCombo.selectedIndex, true);
            beacon_Config_map1.sfMap1.Refresh();
            beacon_Config_map1.sfMap1.FitToExtent(beacon_Config_map1.sfMap1[beacon_Config_map1.SelectedFloor * 3].GetActualExtent());
            macAddressTextBox.Text = mapBeacons[beacon_Config_map1.SelectedFloor][beaconCombo.selectedIndex].beacon_bluetooth_address;
            beaconLastIndex = beaconCombo.selectedIndex;
        }

        private void saveButton_Click(object sender, EventArgs e) {
            mapBeacons[beacon_Config_map1.SelectedFloor][beaconLastIndex].beacon_bluetooth_address = macAddressTextBox.Text;
            /*for (int i =0; i<mapBeacons.Length;i++) {
                for (int j = 0; j < mapBeacons[i].Count; j++) {
                    dbContext.Beacons.AddOrUpdate(mapBeacons[i][j]);
                }
            }*/
            dbContext.SaveChanges();
            this.Close();
        }

        public void UpdateItemInDataBase(Beacon i) {
            var entity = dbContext.Beacons.Find(i.beacon_id);
            if (entity == null) {
                return;
            }

            dbContext.Entry(entity).CurrentValues.SetValues(i);
        }
    }
}
