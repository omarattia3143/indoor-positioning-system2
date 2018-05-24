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
    public partial class Boundary_Config : Form {
        List<Beacon>[] mapBeacons;
        DatabaseEntities1 dbContext = new DatabaseEntities1(); //class derived from DbContext
        public List<Device> mydevices;
        Boundary myBoundary;
        int floorcount = 0;

        public Boundary_Config() {
            InitializeComponent();
            beacon_Config_map1.initializeMap();
            beacon_Config_map1.initializeHistoryFunctions();
            //beacon_Config_map1.sfMap1[2].RenderSettings.IsSelectable = true;
            beacon_Config_map1.sfMap1.SelectedRecordsChanged += SfMap1_SelectedRecordsChanged;
            beacon_Config_map1.sfMap1.MouseClick += SfMap1_MouseClick;
            int tempFloors = 0;
            for (int i = 0; i < beacon_Config_map1.sfMap1.ShapeFileCount; i += 3) {
                tempFloors++;
                floorDropList.AddItem("Floor " + tempFloors);
            }
            floorDropList.selectedIndex = 0;
            //var value = MyList.First(item => item.name == "foo").value;
            mapBeacons = new List<Beacon>[tempFloors];
            floorcount = tempFloors;
            for (int i = 0; i < tempFloors; i++) {
                beacon_Config_map1.sfMap1[(3 * i) + 2].RenderSettings.SelectOutlineColor = Color.Red;
                beacon_Config_map1.sfMap1[(3 * i) + 2].RenderSettings.IsSelectable = true;
                mapBeacons[i] = (from c in dbContext.Beacons where c.beacon_floor == i select c).ToList();
            }
            mydevices = (from c in dbContext.Devices select c).ToList();
            devicesListBox.DisplayMember = "device_name";
            foreach (Device myd in mydevices) {
                devicesListBox.Items.Add(myd);
            }
            initializeBoundary();
            //int z = 0;
        }

        public void initializeBoundary() {
            myBoundary = new Boundary();
        }

        public int getRecordNumberByAttribute(EGIS.ShapeFileLib.ShapeFile sf, int attribute, String value) {
            for (int i = 0; i < sf.RecordCount; i++) {
                if (sf.GetAttributeFieldValues(i)[attribute].Trim().Equals(value)) {
                    return i;
                }
            }
            return -1;
        }

        public void initializeBoundary(int mybndry) {
            myBoundary = (from c in dbContext.Boundaries where c.boundary_id == mybndry select c).ToList()[0];
            boundaryName.Text = myBoundary.boundary_name;
            fromTime.Value = myBoundary.boundary_from.GetValueOrDefault();
            toTime.Value = myBoundary.boundary_to.GetValueOrDefault();
            foreach (Device mydevice in myBoundary.Devices) {
                var myindex = mydevices.FindIndex(item => item.device_id == mydevice.device_id);
                devicesListBox.SetItemChecked(myindex, true);
            }
            foreach (Beacon mybeacon in myBoundary.Beacons) {
                //beacon_Config_map1.sfMap1[(3 * mybeacon.beacon_floor) + 2].GetAttributeFieldValues
                //var myindex = mydevices.FindIndex(item => item.device_id == mydevice.device_id);
                beacon_Config_map1.sfMap1[(3 * mybeacon.beacon_floor) + 2].
                    SelectRecord(
                    getRecordNumberByAttribute(beacon_Config_map1.sfMap1[(3 * mybeacon.beacon_floor) + 2],0,mybeacon.beacon_idonmap)
                    , true);
            }
        }

        public void initializeBoundary(Boundary mybndry) {
            myBoundary = (from c in dbContext.Boundaries where c.boundary_id == mybndry.boundary_id select c).ToList()[0];
            boundaryName.Text = myBoundary.boundary_name;
            fromTime.Value = myBoundary.boundary_from.GetValueOrDefault();
            toTime.Value = myBoundary.boundary_to.GetValueOrDefault();
            foreach (Device mydevice in myBoundary.Devices) {
                var myindex = mydevices.FindIndex(item => item.device_id == mydevice.device_id);
                devicesListBox.SetItemChecked(myindex, true);
            }
            foreach (Beacon mybeacon in myBoundary.Beacons) {
                //beacon_Config_map1.sfMap1[(3 * mybeacon.beacon_floor) + 2].GetAttributeFieldValues
                //var myindex = mydevices.FindIndex(item => item.device_id == mydevice.device_id);
                beacon_Config_map1.sfMap1[(3 * mybeacon.beacon_floor) + 2].
                    SelectRecord(
                    getRecordNumberByAttribute(beacon_Config_map1.sfMap1[(3 * mybeacon.beacon_floor) + 2], 0, mybeacon.beacon_idonmap)
                    , true);
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
                /*beacon_Config_map1.sfMap1[(3 * beacon_Config_map1.SelectedFloor) + 2].ClearSelectedRecords();
                beacon_Config_map1.sfMap1[(3 * beacon_Config_map1.SelectedFloor) + 2].SelectRecord(0, true);*/
                // beacon Combo
                beacon_Config_map1.sfMap1.FitToExtent(beacon_Config_map1.sfMap1[tempint].GetActualExtent());
            }
        }

        private void zoomOut_Click(object sender, EventArgs e) {
            beacon_Config_map1.sfMap1.Refresh();
            beacon_Config_map1.sfMap1.FitToExtent(beacon_Config_map1.sfMap1[beacon_Config_map1.SelectedFloor * 3].GetActualExtent());
        }
        

        private void saveButton_Click(object sender, EventArgs e) {
            /*for (int i =0; i<mapBeacons.Length;i++) {
                for (int j = 0; j < mapBeacons[i].Count; j++) {
                    dbContext.Beacons.AddOrUpdate(mapBeacons[i][j]);
                }
            }*/
            myBoundary.boundary_name = boundaryName.Text;
            myBoundary.boundary_from = fromTime.Value;
            myBoundary.boundary_to = toTime.Value;
            myBoundary.boundary_enabled = enableCheckbox.Checked;
            /*if (myBoundary.boundary_id != 0) {
                var temp_b_d = (from c in dbContext.Boundaries where c.boundary_id == myBoundary.boundary_id select c).FirstOrDefault();
                dbContext.Boundaries.Remove(temp_b_d);
                dbContext.SaveChanges();
            }*/
            List<Device> myselectedDevices = devicesListBox.CheckedItems.Cast<Device>().ToList();
            myBoundary.Devices.Clear();
            foreach (Device x in myselectedDevices) {
                myBoundary.Devices.Add(x);
            }
            myBoundary.Beacons.Clear();
            for (int i = 0; i < floorcount; i++) {
                List<int> records = beacon_Config_map1.sfMap1[(3 * i) + 2].SelectedRecordIndices.ToList();
                List<string> recordIndexOnMap = new List<string>();
                for (int j=0; j<records.Count; j++) {
                    recordIndexOnMap.Add(beacon_Config_map1.sfMap1[(3 * i) + 2].GetAttributeFieldValues(records[j])[0].Trim());
                }
                List<Beacon> selectedbeacons = (from c in dbContext.Beacons where c.beacon_floor == i && recordIndexOnMap.Contains(c.beacon_idonmap) select c).ToList();
                for (int j = 0; j < records.Count; j++) {
                    myBoundary.Beacons.Add(selectedbeacons[j]);
                }
            }
            if (myBoundary.boundary_id == 0) {
                dbContext.Boundaries.Add(myBoundary);
            }
            dbContext.SaveChanges();
            this.Close();
        }

        /*public void UpdateItemInDataBase(Beacon i) {
            var entity = dbContext.Beacons.Find(i.beacon_id);
            if (entity == null) {
                return;
            }

            dbContext.Entry(entity).CurrentValues.SetValues(i);
        }*/
    }
}
