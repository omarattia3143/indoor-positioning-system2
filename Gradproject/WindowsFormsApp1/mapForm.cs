using SharpCompress.Archives;
using SharpCompress.Archives.Rar;
using SharpCompress.Readers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1 {
    public partial class mapForm : Form {
        const int CONST_ID = 0, CONST_NAME = 1, CONST_BEACONID = 1, CONST_MINRSSI = 2, CONST_MAXRSSI = 3;
        public static double MaxZoomLevel = 10000;
        public static double MinZoomLevel = 0.01;
        public static int IconSize = 16;
        public static double xTrial = 356, yTrial = -308;
        public static int SelectedFloor = 0;
        public static List<Device> BluetoothDevices;
        public static List<Beacon> BluetoothBeacons;
        public static List<Boundary> AllBoundaries;
        public static List<Record> AllRecords;
        string Rooms = "C:\\Users\\Omar\\Desktop\\Semester 9\\Grad I\\egis_dt_4_5_7\\try shape\\QGIS\\Indoor Shape Files\\Rooms.shp";
        string Beacons = "C:\\Users\\Omar\\Desktop\\Semester 9\\Grad I\\egis_dt_4_5_7\\try shape\\QGIS\\Indoor Shape Files\\Beacons.shp";
        string Coverage = "C:\\Users\\Omar\\Desktop\\Semester 9\\Grad I\\egis_dt_4_5_7\\try shape\\QGIS\\Indoor Shape Files\\Coverage.shp";
        //string Coverage = "C:\\Users\\Omar\\Desktop\\Semester 9\\Grad I\\egis_dt_4_5_7\\try shape\\QGIS\\cliped\\AllCoverage.shp";
        public static string Bluetooth = "C:/Users/Omar/Desktop/Semester 9/Grad I/egis_dt_4_5_7/old shape files/try shape/QGIS/bticon.png";
        public static int moveCloserToTheOriginBy = 10;
        List<PointF> myPoints;
        private Timer SimulatorTimer, LerpTimer, EverySecondTimer, SaveRecordsTimer;
        private static DatabaseEntities1 mydbContext;
        public int deviceInActiveLimit = 5;
        public int SaveRecordsEvery = 500;
        public bool custmizedChanged = false;
        public bool boundaryChanged = false;
        //private float lerpVariable = 0;

        public mapForm() {
            InitializeComponent();
            mydbContext = new DatabaseEntities1(); //class derived from DbContext
            myPoints = new List<PointF>();
            sfMap1.BackColor = Color.White;
            sfMap1.ZoomLevelChanged += SfMap1_ZoomLevelChanged;
            LoadMaps();
            sfMap1.FitToExtent(sfMap1[SelectedFloor * 3].GetActualExtent());
            sfMap1.Paint += SfMap1_Paint;
            sfMap1.MouseClick += SfMap1_MouseClick;
            customizedView1.devicesList.ItemCheck += DevicesList_ItemCheck;
            //customizedView1.groupList.ItemCheck += DevicesList_ItemCheck;
            updateAll();
            AllRecords = new List<Record>();
            initializeDevices();
            initializeBoundary();
            //contacts.FirstOrDefault().FirstName = "Alex"; //edit 
            //Device temp = contacts[2];
            //Console.WriteLine(contacts[2].device_name);
            Random rnd = new Random();
            foreach (Device student in BluetoothDevices) {// part of the simulation
                Console.WriteLine("{0}, {1}", student.device_name, student.device_id);
                student.SimulationlastBeacon = rnd.Next(0, BluetoothBeacons.Count - 1);
            }
            StartSimulator();
            StartLerp();
            StartEverySecond();
            StartSaveRecords();
            /*PictureBox mykid = new PictureBox();
            mykid.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "ResizedIcons/Resizedbticon.png");
            //mykid.SizeMode = PictureBoxSizeMode.Zoom;
            //mykid.BorderStyle = BorderStyle.None;
            mykid.SizeMode = PictureBoxSizeMode.AutoSize;
            mykid.BackColor = Color.Transparent;
            Button button = new Button();
            button.Text = "Aywa ba2a ya wadee3";
            mykid.Location = new Point(160, 30 * 5 + 10);
            sfMap1.Controls.Add(mykid);
            Console.WriteLine(sfMap1.Controls.Count + " GELELELEL");*/

            //contacts[1].device_name = "Galal";
            //dbContext.SaveChanges();
            //contacts[1].SomeData = "Hello World!";
            //Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
            /*using (var db = new DatabaseEntities1()) {
                var result = db.Devices.SingleOrDefault(b => b.device_id == 5);
                if (result != null) {
                    result.device_name = "Some new value";
                    db.Entry(result).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }*/
            //NotificationText.Text += "lo;";
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, countNotification.Width, countNotification.Height);
            Pen myPen = new Pen(Color.Red, 2);
            //e.Graphics.DrawPath(myPen, path);
            countNotification.Text = "0";
            //countNotification.Visible = true;
            this.countNotification.Region = new Region(path);
            Console.WriteLine("Number is "+ HexToInt("C7"));
        }

        private int HexToInt(string _hexData) {
            String temp = _hexData.Substring(0,1);
            var i = Convert.ToInt16(temp,16);
            if(i > 7) {
                int x = Convert.ToInt16("FF" + _hexData, 16);
                return x;
            } else {
                return Convert.ToInt16(_hexData, 16);
            }
        }


        public void initializeBoundary() {
            using (var dbContext = new DatabaseEntities1()) {
                BindingSource bi = new BindingSource();
                bi.DataSource = (from c in dbContext.Boundaries select c).Select(o => new
                { ID = o.boundary_id, Name = o.boundary_name, From = o.boundary_from,
                    To = o.boundary_to, Enabled = o.boundary_enabled }).ToList();
                boundaryControl1.dataGridView1.DataSource = bi;
                boundaryControl1.dataGridView1.Refresh();
            }
            boundaryControl1.editButton.Click += boundary_EditButton_Click;
            boundaryControl1.newButton.Click += boundary_NewButton_Click;
        }

        private void boundary_NewButton_Click(object sender, EventArgs e) {
            boundaryChanged = true;
        }

        private void boundary_EditButton_Click(object sender, EventArgs e) {
            boundaryChanged = true;
        }
        
        public void fillCustomizedView() {
            customizedView1.devicesList.Items.Clear();
            customizedView1.groupList.Items.Clear();
            customizedView1.devicesList.DisplayMember = "device_name";
            for (int i = 0; i < BluetoothDevices.Count; i++) {
                customizedView1.devicesList.Items.Add(BluetoothDevices[i]);
                customizedView1.devicesList.SetItemChecked(i, true);
            }
            // Groups
            List<Group> myGroups;
            using (var dbContext = new DatabaseEntities1()) {
                myGroups = (from c in mydbContext.Groups select c).ToList(); //read data
            }
            customizedView1.AllGroups = myGroups;
            customizedView1.AllDevices = BluetoothDevices;
            customizedView1.groupList.DisplayMember = "group_name";
            for (int i = 0; i < myGroups.Count; i++) {
                customizedView1.groupList.Items.Add(myGroups[i]);
                customizedView1.groupList.SetItemChecked(i, true);
            }
        }

        private void DevicesList_ItemCheck(object sender, ItemCheckEventArgs e) {
            custmizedChanged = true;
        }

        public void StartEverySecond() {
            EverySecondTimer = new Timer();
            EverySecondTimer.Tick += new EventHandler(EverySecond);
            EverySecondTimer.Interval = 1000; // in miliseconds
            EverySecondTimer.Start();
        }

        private void EverySecond(object sender, EventArgs e) {
            foreach (Device mydevice in BluetoothDevices) {
                if (mydevice.inActive > 0)
                    mydevice.inActive--;
                else if(mydevice.lastBeaconId != -1) {
                    mydevice.connected = false;
                    createNotification(mydevice.device_name+" Was Disconnected!");
                }
            }
        }

        public void StartSaveRecords() {
            SaveRecordsTimer = new Timer();
            SaveRecordsTimer.Tick += new EventHandler(SaveRecords);
            SaveRecordsTimer.Interval = SaveRecordsEvery; // in miliseconds
            SaveRecordsTimer.Start();
        }

        private void SaveRecords(object sender, EventArgs e) {
            List<Record> temp = new List<Record>(AllRecords);
            AllRecords.Clear();
            using (var dbContext = new DatabaseEntities1()) {
                foreach (Record myrecord in temp) {
                    dbContext.Records.Add(myrecord);
                }
                dbContext.SaveChanges();
            }
        }

        public void StartSimulator () {
            SimulatorTimer = new Timer();
            SimulatorTimer.Tick += new EventHandler(Simulator);
            SimulatorTimer.Interval = 1000; // in miliseconds
            SimulatorTimer.Start();
        }

        public void StartLerp() {
            LerpTimer = new Timer();
            LerpTimer.Tick += new EventHandler(Lerper);
            LerpTimer.Interval = 30; // in miliseconds
            LerpTimer.Start();
        }

        private void Lerper(object sender, EventArgs e) {
            foreach (Device mydevice in BluetoothDevices) {
                mydevice.lerpVariable += 0.05f;
                if (mydevice.lerpVariable >= 0.98f)
                    mydevice.lerpVariable = 1;
                mydevice.Location = lerp(mydevice.FromLocation, mydevice.ToLocation,mydevice.lerpVariable);
            }
            sfMap1.Refresh();
        }

        private void Simulator(object sender, EventArgs e) {
            Random rnd = new Random();
            foreach (Device mydevice in BluetoothDevices) {
                drawDeviceOnMap(rnd.Next(-40,-10), mydevice, BluetoothBeacons[mydevice.SimulationlastBeacon]);
                mydevice.ticksB4ChangingBeacon++;
                if(mydevice.ticksB4ChangingBeacon == 20) {
                    mydevice.SimulationlastBeacon++;
                    mydevice.ticksB4ChangingBeacon = 0;
                    if (mydevice.SimulationlastBeacon >= BluetoothBeacons.Count)
                        mydevice.SimulationlastBeacon = 0;
                }
            }
        }

        private PointF lerp(PointF v0, PointF v1, float t) {
            PointF myoutput = new PointF(v0.X+t*(v1.X-v0.X), v0.Y + t * (v1.Y - v0.Y));
            return myoutput;
        }

        private void createNotification(String notif) {
            using (var dbContext = new DatabaseEntities1()) {
                dbContext.Notifications.Add(new Notification {
                    notification_text = notif,
                    notification_time = DateTime.Now
                });
                dbContext.SaveChanges();
            }
            Console.WriteLine(notif); // Important
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Notice";
            notifyIcon1.BalloonTipText = notif;

            notifyIcon1.ShowBalloonTip(5000);
            string temp = NotificationText.Text;
            NotificationText.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss",
                                CultureInfo.InvariantCulture) + "\r\n"+notif+ "\r\n\r\n" + temp;
            int x = Int32.Parse(countNotification.Text);
            countNotification.Text = (x + 1) + "";
            countNotification.Visible = true;
        }
        

        private void initializeDevices() {
            for (int i = 0; i < BluetoothDevices.Count; i++) {
                CustomizedToolTip myToolTip1 = new CustomizedToolTip();
                myToolTip1.AutoSize = false;
                myToolTip1.BorderColor = Color.Aqua;
                PictureBox mykid = new PictureBox();
                //mykid.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "ResizedIcons/Resizedpoliceofficer.png");
                if (BluetoothDevices[i].device_override_group_icon) {
                    if (BluetoothDevices[i].device_icon == null) {
                        mykid.Image = Resources.noman;
                    } else {
                        mykid.Image = ResizeImage(ConvertToImage(BluetoothDevices[i].device_icon), IconSize, IconSize);
                    }
                } else {
                    if (BluetoothDevices[i].Group == null) {
                        mykid.Image = Resources.noman;
                    } else {
                        if (BluetoothDevices[i].Group.group_icon == null) {
                            mykid.Image = Resources.noman;
                        } else {
                            mykid.Image = ResizeImage(ConvertToImage(BluetoothDevices[i].Group.group_icon), IconSize, IconSize);
                        }
                    }
                }
                mykid.SizeMode = PictureBoxSizeMode.AutoSize;
                mykid.BackColor = Color.Transparent;
                mykid.Name = i+"";
                mykid.Click += Device_Click;
                String mygrop = "No Group";
                if (BluetoothDevices[i].Group != null)
                    mygrop = BluetoothDevices[i].Group.group_name;
                myToolTip1.SetToolTip(mykid, "Name: "+ BluetoothDevices[i].device_name+"\nGroup: "+ mygrop);
                //mykid.Tag = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "ResizedIcons/3.jpg");
                if (BluetoothDevices[i].device_picture == null) {
                    mykid.Tag = Resources.nomanbig;
                } else {
                    mykid.Tag = ConvertToImage(BluetoothDevices[i].device_picture);
                }
                sfMap1.Controls.Add(mykid);
            }
        }

        public static Image ConvertToImage(System.Data.Linq.Binary iBinary) {
            var arrayBinary = iBinary.ToArray();
            Image rImage = null;

            using (MemoryStream ms = new MemoryStream(arrayBinary)) {
                rImage = Image.FromStream(ms);
            }
            return rImage;
        }

        private void Device_Click(object sender, EventArgs e) {
            PictureBox button = sender as PictureBox;
            //Console.WriteLine("I Was Clicked "+ button.Name);
            deviceInfo myForm = new deviceInfo();
            int x = Int32.Parse(button.Name);
            myForm.initialize(BluetoothDevices[x]);
            //this.Hide();
            myForm.ShowDialog();
            //this.Show();
        }

        private void LoadMaps() {
            string MapsPath = AppDomain.CurrentDomain.BaseDirectory+"Maps";
            System.IO.Directory.CreateDirectory(MapsPath);
            String [] directories = Directory.GetDirectories(MapsPath);
            if(directories.Length == 0) {
                //Console.WriteLine( selectfile());
                using (var archive = RarArchive.Open(selectfile())) {
                    foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory)) {
                        entry.WriteToDirectory(MapsPath, new ExtractionOptions() {
                            ExtractFullPath = true
                        });
                    }
                }
            }
            directories = Directory.GetDirectories(MapsPath);
            bool setFLoorVisible = true;
            for(int i = 0; i < directories.Length; i++) {
                Console.WriteLine(directories[i]);
                LoadRooms(directories[i]+ "/Rooms.shp", "Rooms "+i, setFLoorVisible);
                LoadCoverage(directories[i] + "/Coverage.shp", "Coverage " + i, false);
                LoadBeacons(directories[i] + "/Beacons.shp", "Beacons " + i, setFLoorVisible);
                setFLoorVisible = false;
                floorDroplist.AddItem("Floor "+ (i+1));
            }
            floorDroplist.selectedIndex = 0;
            floorDroplist.onItemSelected += FloorDroplist_onItemSelected;
            /*for (int i = 0; i < directories.Length; i++) { // This loop fills the beacons database. just for fun important
                for (int j = 0; j < sfMap1[2+(i*3)].RecordCount; j++) {
                    string idonmap = sfMap1[2 + (i * 3)].GetAttributeFieldValues(j)[CONST_ID].Trim();
                    using (var dbContext = new DatabaseEntities1()) {
                        var beacon = dbContext.Set<Beacon>();
                        beacon.Add(new Beacon {
                            beacon_floor = i,
                            beacon_idonmap = idonmap,
                            beacon_bluetooth_address = "11:11:11:"+j+""+i
                        });
                        dbContext.SaveChanges();
                    }
                }
            }*/

        }

        private void FloorDroplist_onItemSelected(object sender, EventArgs e) {
            //Console.WriteLine(""+ floorDroplist.selectedIndex);
            if (floorDroplist.selectedIndex != SelectedFloor) {
                int tempint = SelectedFloor * 3;
                for (int i =0; i<3; i++) {
                    makeLayerInvisible(tempint+i);
                }
                SelectedFloor = floorDroplist.selectedIndex;
                tempint = SelectedFloor * 3;
                for (int i = 0; i < 3; i++) {
                    if (i == 1)
                        continue;
                    makeLayerVisible(tempint + i);
                }
                sfMap1.FitToExtent(sfMap1[tempint].GetActualExtent());
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
                if(System.Windows.Forms.Application.MessageLoop) {
                    // WinForms app
                    System.Windows.Forms.Application.Exit();
                }else{
                    // Console app
                    System.Environment.Exit(1);
                }
            }
            return "";
        }

        private void SfMap1_MouseClick(object sender, MouseEventArgs e) {
            //throw new NotImplementedException();
            if (e.Button == System.Windows.Forms.MouseButtons.Left) {
                Console.WriteLine("X = " + sfMap1.MousePosToGisPoint(e.Location).X + ", Y = " + sfMap1.MousePosToGisPoint(e.Location).Y);
            }
            
        }

        private void SfMap1_Paint(object sender, PaintEventArgs e) {
            //throw new NotImplementedException
            //DrawMarker(e.Graphics, xTrial, yTrial); //sfMap1[2].GetShapeBoundsD(0).Right, sfMap1[2].GetShapeBoundsD(0).Y + (sfMap1[2].GetShapeBoundsD(0).Height/2));
            /*foreach (PointF aPoint in myPoints) {
                DrawMarker(e.Graphics, aPoint.X, aPoint.Y);
            }*/
            //Bitmap a = new Bitmap(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "ResizedIcons/Resizedpoliceofficer.png"));
            for (int i = 0; i < BluetoothDevices.Count; i++) {
                Device mydevice = BluetoothDevices[i];
                if (mydevice.connected && mydevice.floor == SelectedFloor && mydevice.showCustomized) {
                    sfMap1.Controls[i].Visible = true;
                    Point pt = sfMap1.GisPointToPixelCoord(mydevice.Location);
                    sfMap1.Controls[i].Location = sfMap1.GisPointToPixelCoord(mydevice.Location);
                    /* We Can Check For Overlap here .....  LATER
                    for () {

                    }*/
                    /*e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    e.Graphics.DrawImage(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "ResizedIcons/Resizedpoliceofficer.png"), pt);*/
                } else {
                    sfMap1.Controls[i].Visible = false;
                }
            }
        }

        private void DrawMarker(Graphics g, double locX, double locY) {
            //convert the gis location to pixel coordinates
            Point pt = sfMap1.GisPointToPixelCoord(locX, locY);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            //draw a marker centered at the gis location
            //alternative is to draw an image/icon
            int MarkerWidth = 10;
            g.DrawLine(Pens.Red, pt.X, pt.Y - MarkerWidth, pt.X, pt.Y + MarkerWidth);
            g.DrawLine(Pens.Red, pt.X - MarkerWidth, pt.Y, pt.X + MarkerWidth, pt.Y);
            pt.Offset(-MarkerWidth / 2, -MarkerWidth / 2);
            g.FillEllipse(Brushes.Yellow, pt.X, pt.Y, MarkerWidth, MarkerWidth);
            g.DrawEllipse(Pens.Red, pt.X, pt.Y, MarkerWidth, MarkerWidth);
            //g.drawre
            
        }

        private void SfMap1_ZoomLevelChanged(object sender, EventArgs e) {
            if (sfMap1.ZoomLevel < MinZoomLevel) {
                sfMap1.ZoomLevel = MinZoomLevel;
            }
            if (sfMap1.ZoomLevel > MaxZoomLevel) {
                sfMap1.ZoomLevel = MaxZoomLevel;
            }
            //throw new NotImplementedException();
        }

        private void LoadRooms(string mypath, string name, bool setVisible) {
            // clear any shapefiles the map is currently displaying
            //this.sfMap1.ClearShapeFiles();

            // open the shapefile passing in the path, display name of the shapefile and
            // the field name to be used when rendering the shapes (we use an empty string
            // as the field name (3rd parameter) can not be null)
            this.sfMap1.AddShapeFile(mypath, name, "");

            // read the shapefile dbf field names and set the shapefiles's RenderSettings
            // to use the first field to label the shapes.
            EGIS.ShapeFileLib.ShapeFile sf = this.sfMap1[this.sfMap1.ShapeFileCount-1];
            sf.RenderSettings.FieldName = sf.RenderSettings.DbfReader.GetFieldNames()[1];
            sf.RenderSettings.UseToolTip = false;
            sf.RenderSettings.IsSelectable = false;
            sf.RenderSettings.ToolTipFieldName = sf.RenderSettings.FieldName;
            //sf.RenderSettings.IsSelectable = true;
            sf.RenderSettings.Font = new Font("Times New Roman", 11);
            if (!setVisible) {
                sf.RenderSettings.MinZoomLevel = float.MaxValue;
            }
            // Console.WriteLine(string.Join(",", sf.GetAttributeFieldNames()));

            //select the first record
            //sf.SelectRecord(0, true);

        }

        private void LoadBeacons(string mypath, string name, bool setVisible) {
            this.sfMap1.AddShapeFile(mypath, name, "");
            EGIS.ShapeFileLib.ShapeFile sf = this.sfMap1[this.sfMap1.ShapeFileCount - 1];
            sf.RenderSettings.UseToolTip = false;
            sf.RenderSettings.IsSelectable = false;
            sf.RenderSettings.FillColor = Color.Green;

            System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "ResizedIcons");
            string iconpath = AppDomain.CurrentDomain.BaseDirectory+ "ResizedIcons/Resizedbticon.png";
            if (!File.Exists(iconpath)) {
                /*Image img = Image.FromFile(Bluetooth);
                Bitmap temp = ResizeImage(img, IconSize, IconSize);
                temp.Save(iconpath, ImageFormat.Png);*/
                Resources.Resizedbticon.Save(iconpath, ImageFormat.Png);
            }
            sf.RenderSettings.PointImageSymbol = iconpath;

            if (!setVisible) {
                sf.RenderSettings.MinZoomLevel = float.MaxValue;
            }
            //Console.WriteLine(string.Join(",", sf.GetAttributeFieldNames()));
            
            // This code should only be executed only on time at the begaining of adding the maps Important
            /*for(int i=0; i < this.sfMap1[this.sfMap1.ShapeFileCount - 1].RecordCount; i++) {

                try {
                    var beacons = mydbContext.Set<Beacon>();
                    Beacon abeacon = new Beacon {
                        beacon_floor = (this.sfMap1.ShapeFileCount / 4),
                        beacon_idonmap = this.sfMap1[this.sfMap1.ShapeFileCount - 1].GetAttributeFieldValues(i)[CONST_BEACONID].Trim()
                    };
                    beacons.Add(abeacon);
                    mydbContext.SaveChanges();
                } catch (DbEntityValidationException e) {
                    foreach (var eve in e.EntityValidationErrors) {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors) {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }
                Console.WriteLine("done dude!");
            }*/


        }

        private void LoadCoverage(string mypath, string name, bool setVisible) {
            this.sfMap1.AddShapeFile(mypath, name, "");
            EGIS.ShapeFileLib.ShapeFile sf = this.sfMap1[this.sfMap1.ShapeFileCount - 1];
            sf.RenderSettings.UseToolTip = false;
            sf.RenderSettings.IsSelectable = false;
            sf.RenderSettings.FillColor = Color.FromArgb(50, 0, 0, 255);
            sf.RenderSettings.OutlineColor = Color.Blue;
            if (!setVisible) {
                sf.RenderSettings.MinZoomLevel = float.MaxValue;
            }
            //Console.WriteLine(string.Join(",", sf.GetAttributeFieldNames()));
            /*Console.WriteLine("Buttom " + sf.GetShapeBoundsD(0).Bottom + " : Top " + sf.GetShapeBoundsD(0).Top
                + " : Right " + sf.GetShapeBoundsD(0).Right + " : Left " + sf.GetShapeBoundsD(0).Left);*/
            //int zxc = 2;
            /*for (zxc = 1; zxc<2;zxc++) {
                xTrial = sf.GetShapeBoundsD(zxc).Right;
                yTrial = sf.GetShapeBoundsD(zxc).Bottom - (sf.GetShapeBoundsD(zxc).Height / 2);
                Point a = new Point((int)xTrial, (int)yTrial);
                Point z = new Point((int)sf.GetShapeBoundsD(zxc).Right, (int)sf.GetShapeBoundsD(zxc).Top);
                Point x = new Point((int)sf.GetShapeBoundsD(zxc).Right, (int)sf.GetShapeBoundsD(zxc).Bottom);
                Point c = new Point((int)sf.GetShapeBoundsD(zxc).Left, (int)sf.GetShapeBoundsD(zxc).Bottom);
                Point v = new Point((int)sf.GetShapeBoundsD(zxc).Left, (int)sf.GetShapeBoundsD(zxc).Top);
                //myPoints.Add(a);
                myPoints.Add(z);
                myPoints.Add(x);
                myPoints.Add(c);
                myPoints.Add(v);
            }*/
            /*foreach (PointF mypoint in sf.GetShapeData(zxc)[0]) {
                Console.WriteLine("X = " + mypoint.X+", Y = "+ mypoint.Y);
                myPoints.Add(mypoint);
            }*/
            /*myPoints.Add(getClosestPoint(new PointF(0f,0f),sf,zxc));
             if (sf.GetAttributeFieldValues(0)[0].Trim().Equals("1")) {
                 Console.WriteLine("THEY ARE EQUAL");
             } else {
                 Console.WriteLine("THEY ARE not EQUAL");
             }
             Console.WriteLine(string.Join(" .|. ", sf.GetAttributeFieldNames()));
             Console.WriteLine(string.Join(" .|. ", sf.GetAttributeFieldValues(0)));*/
            //sf.GetShapeData(0).
            //sfMap1.mar
            //sf.RenderSettings.MinZoomLevel = float.MaxValue;


        }

        public PointF getClosestPoint(PointF Location, int floor, int SectorIndex) {// Coverage Area Index
            EGIS.ShapeFileLib.ShapeFile sf = sfMap1[(floor*3) + 1];
            double tempAx = sf.GetShapeData(SectorIndex)[0][0].X;
            double tempAy = sf.GetShapeData(SectorIndex)[0][0].Y;
            double tempBx = Location.X;
            double tempBy = Location.Y;
            double shortestDistance = Math.Sqrt((tempAx- tempBx)*(tempAx - tempBx) + (tempAy - tempBy)*(tempAy - tempBy));
            int closestPointIndex = 0;
            for (int i =0; i <  sf.GetShapeData(SectorIndex)[0].Length; i++) {
                PointF mypoint = sf.GetShapeData(SectorIndex)[0][i];
                tempAx = mypoint.X;
                tempAy = mypoint.Y;
                double dist = Math.Sqrt((tempAx - tempBx) * (tempAx - tempBx) + (tempAy - tempBy) * (tempAy - tempBy));
                if(dist < shortestDistance) {
                    shortestDistance = dist;
                    closestPointIndex = i;
                }
            }
            PointF closestPoint = sf.GetShapeData(SectorIndex)[0][closestPointIndex];
            double centerPointY = sf.GetShapeBoundsD(SectorIndex).Bottom - (sf.GetShapeBoundsD(SectorIndex).Height / 2);
            double centerPointX = sf.GetShapeBoundsD(SectorIndex).Right - (sf.GetShapeBoundsD(SectorIndex).Width / 2);
            /*Console.WriteLine("Buttom " + sf.GetShapeBoundsD(SectorIndex).Bottom + " : Top " + sf.GetShapeBoundsD(SectorIndex).Top
                + " : Right " + sf.GetShapeBoundsD(SectorIndex).Right + " : Left " + sf.GetShapeBoundsD(SectorIndex).Left);
            Console.WriteLine("Width: " + sf.GetShapeBoundsD(SectorIndex).Width + " | Height: " + sf.GetShapeBoundsD(SectorIndex).Height);
            Console.WriteLine("Center X: " + centerPointX + " | Center Y: " + centerPointY);
            Console.WriteLine("X: " + closestPoint.X + " | Y: " + closestPoint.Y);*/
            if (centerPointX - closestPoint.X < 0) {
                closestPoint.X -= moveCloserToTheOriginBy;
            } else if (centerPointX - closestPoint.X > 0) {
                closestPoint.X += moveCloserToTheOriginBy;
            }
            if (centerPointY - closestPoint.Y < 0) {
                closestPoint.Y -= moveCloserToTheOriginBy;
            } else if (centerPointY - closestPoint.Y > 0) {
                closestPoint.Y += moveCloserToTheOriginBy;
            }
            //Console.WriteLine("X: " + closestPoint.X + " | Y: " + closestPoint.Y);
            return closestPoint;
        }

        public PointF getRandomPoint(EGIS.ShapeFileLib.ShapeFile sf, int index) {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, sf.GetShapeData(index)[0].Length);
            PointF closestPoint = sf.GetShapeData(index)[0][randomIndex];
            double centerPointY = sf.GetShapeBoundsD(index).Bottom - (sf.GetShapeBoundsD(index).Height / 2);
            double centerPointX = sf.GetShapeBoundsD(index).Right - (sf.GetShapeBoundsD(index).Width / 2);
            Console.WriteLine("Buttom " + sf.GetShapeBoundsD(index).Bottom + " : Top " + sf.GetShapeBoundsD(index).Top
                + " : Right " + sf.GetShapeBoundsD(index).Right + " : Left " + sf.GetShapeBoundsD(index).Left);
            Console.WriteLine("Width: " + sf.GetShapeBoundsD(index).Width + " | Height: " + sf.GetShapeBoundsD(index).Height);
            Console.WriteLine("Center X: " + centerPointX + " | Center Y: " + centerPointY);
            Console.WriteLine("X: " + closestPoint.X + " | Y: " + closestPoint.Y);
            if (centerPointX - closestPoint.X < 0) {
                closestPoint.X -= moveCloserToTheOriginBy;
            } else if (centerPointX - closestPoint.X > 0) {
                closestPoint.X += moveCloserToTheOriginBy;
            }
            if (centerPointY - closestPoint.Y < 0) {
                closestPoint.Y -= moveCloserToTheOriginBy;
            } else if (centerPointY - closestPoint.Y > 0) {
                closestPoint.Y += moveCloserToTheOriginBy;
            }
            Console.WriteLine("X: " + closestPoint.X + " | Y: " + closestPoint.Y);
            return closestPoint;
        }
     
        /* List of attributes and their corresponding indices
         * Beacons    id = 0, Mac Adrs = 1
         * Coverage   id = 0, Mac Adrs = 1, MinRSSI = 2, MaxRSSI = 3
         * Room       id = 0, Name = 1
         */
        public int getRecordNumberByAttribute(EGIS.ShapeFileLib.ShapeFile sf, int attribute,String value) {
            for (int i =0; i<sf.RecordCount; i++) {
                if (sf.GetAttributeFieldValues(i)[attribute].Trim().Equals(value)) {
                    return i;
                }
            }
            return -1;
        }

        public List<int> getListRecordNumberByAttribute(EGIS.ShapeFileLib.ShapeFile sf, int attribute, String value) {
            List<int> myList = new List<int>();
            for (int i = 0; i < sf.RecordCount; i++) {
                if (sf.GetAttributeFieldValues(i)[attribute].Trim().Equals(value)) {
                    myList.Add(i);
                }
            }
            return myList;
        }

        public int getRSSISector(EGIS.ShapeFileLib.ShapeFile sf, String beaconIdOnMap, int RSSI) {
            List<int> myList = new List<int>();
            int minMinRSSI = 0, maxMaxRssi = 0, minSector = 0, maxSector = 0, flag = 0;
            for (int i = 0; i < sf.RecordCount; i++) {
                if (sf.GetAttributeFieldValues(i)[CONST_BEACONID].Trim().Equals(beaconIdOnMap.Trim())) {
                    int myMinRSSI = Int32.Parse(sf.GetAttributeFieldValues(i)[CONST_MINRSSI].Trim());
                    int myMaxRSSI = Int32.Parse(sf.GetAttributeFieldValues(i)[CONST_MAXRSSI].Trim());
                    if(flag == 0) {
                        flag = 1;
                        minSector = maxSector = i;
                        minMinRSSI = myMinRSSI;
                        maxMaxRssi = myMaxRSSI;
                    }
                    if (RSSI > myMaxRSSI && RSSI < myMinRSSI) {
                        return i;
                    }
                    if (myMinRSSI < minMinRSSI) {
                        minMinRSSI = myMinRSSI;
                        minSector = i;
                    }
                    if (myMaxRSSI > maxMaxRssi) {
                        maxMaxRssi = myMaxRSSI;
                        maxSector = i;
                    }
                }
            }
            if (flag == 0) {
                return -1;
            }else if (RSSI > minMinRSSI) {
                return minSector;
            } else {
                return maxSector;
            }
        }

        public void drawDeviceOnMap(int myRssi, Device mydevice, Beacon mybeacon) {// Important The passed device MUST be from the BluetoothDevices List
            try {
                int mysector = getRSSISector(sfMap1[1 + (mybeacon.beacon_floor * 3)], mybeacon.beacon_idonmap, myRssi);
                mydevice.ToLocation = getClosestPoint(mydevice.Location, mybeacon.beacon_floor, mysector);
                mydevice.FromLocation = mydevice.Location;
                if (mydevice.floor != -1 && !mydevice.connected)
                    createNotification(mydevice.device_name + " just connected!");

                // Boundary Check
                if (mydevice.lastBeaconId != -1) {
                    foreach (Boundary mybound in AllBoundaries) {
                        if (!mybound.boundary_enabled)
                            continue;
                        var deviceSetToBoundary = mybound.Devices.Any(item => item.device_id == mydevice.device_id);
                        if (deviceSetToBoundary) {
                            var wasItInsideBoundary = mybound.Beacons.Any(item => item.beacon_id == mydevice.lastBeaconId);
                            if (wasItInsideBoundary) {
                                var stillInsideBoundary = mybound.Beacons.Any(item => item.beacon_id == mybeacon.beacon_id);
                                if (!stillInsideBoundary) {
                                    createNotification(mydevice.device_name + " has Left " + mybound.boundary_name);
                                }
                            } else {
                                var enteredBoundary = mybound.Beacons.Any(item => item.beacon_id == mybeacon.beacon_id);
                                if (enteredBoundary) {
                                    createNotification(mydevice.device_name + " has Entered " + mybound.boundary_name);
                                }
                            }
                        }
                    }
                }
                // Boundary Check

                mydevice.lastBeaconId = mybeacon.beacon_id;
                mydevice.connected = true;
                mydevice.inActive = deviceInActiveLimit;
                mydevice.lerpVariable = 0;
                if (mydevice.floor != mybeacon.beacon_floor) {
                    mydevice.lerpVariable = 1;
                    mydevice.Location = mydevice.ToLocation;
                    mydevice.FromLocation = mydevice.Location;
                }
                mydevice.floor = mybeacon.beacon_floor;
                //save record
                AllRecords.Add(new Record {
                    record_time = DateTime.Now.TrimMilliseconds(),
                    rssi = myRssi,
                    device_id = mydevice.device_id,
                    beacon_id = mybeacon.beacon_id,
                    record_location_x = mydevice.ToLocation.X,
                    record_location_y = mydevice.ToLocation.Y
                });

                sfMap1.Refresh();
            } catch { }


        }

        public static Bitmap ResizeImage(Image image, int width, int height) {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage)) {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes()) {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public void makeLayerVisible(int layerIndex) {
            sfMap1[layerIndex].RenderSettings.MinZoomLevel = 0f;
            double temp = sfMap1.ZoomLevel;
            sfMap1.FitToExtent(sfMap1[SelectedFloor * 3].GetActualExtent());
            sfMap1.ZoomLevel = temp;
            
        }

        public void makeLayerInvisible(int layerIndex) {
            sfMap1[layerIndex].RenderSettings.MinZoomLevel = float.MaxValue;
            double temp = sfMap1.ZoomLevel;
            sfMap1.FitToExtent(sfMap1[SelectedFloor * 3].GetActualExtent());
            sfMap1.ZoomLevel = temp;
        }

        public bool isLayerVisible(int layerIndex) {
            if (sfMap1[layerIndex].RenderSettings.MinZoomLevel == float.MaxValue) {
                return false;
            } else {
                return true;
            }
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e) {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e) {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e) {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e) {
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void bunifuCustomLabel1_Click_1(object sender, EventArgs e) {

        }

        private void pictureBox3_Click(object sender, EventArgs e) {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void btnMenu_Click(object sender, EventArgs e) {
            if (sideMenu.Width == 54) {
                sideMenu.Visible = false;
                sideMenu.Width = 278;
                panelAnimator.ShowSync(sideMenu);
                logoAnimator.ShowSync(logo);
            } else if (NotificationPanel.Parent.Controls.GetChildIndex(NotificationPanel) == 0) {
                NotificationPanel.SendToBack();
            } else {
                logoAnimator.Hide(logo);
                sideMenu.Visible = false;
                sideMenu.Width = 54;
                panelAnimator.ShowSync(sideMenu);
            }
        }

        private void btnNotification_Click(object sender, EventArgs e) {
            /*if (sideMenu.Width == 54) {
                sideMenu.Visible = false;
                sideMenu.Width = 278;
                panelAnimator.ShowSync(sideMenu);
                logoAnimator.ShowSync(logo);
            } else {
                logoAnimator.Hide(logo);
                sideMenu.Visible = false;
                sideMenu.Width = 54;
                panelAnimator.ShowSync(sideMenu);
            }*/
            if (sideMenu.Width == 54) {
                sideMenu.Visible = false;
                sideMenu.Width = 278;
                panelAnimator.ShowSync(sideMenu);
                logoAnimator.ShowSync(logo);
            }
            NotificationPanel.BringToFront();
            countNotification.Text = "0";
            countNotification.Visible = false;
            /*notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Notify Icon Test Application";
            notifyIcon1.BalloonTipText = "You have just minimized the application." +
                                        Environment.NewLine +
                                        "Right-click on the icon for more options.";

            notifyIcon1.ShowBalloonTip(5000);*/
        }

        private void search_image_Click(object sender, EventArgs e) {
            if (sideMenu.Width == 54) {
                sideMenu.Visible = false;
                sideMenu.Width = 278;
                panelAnimator.ShowSync(sideMenu);
                logoAnimator.ShowSync(logo);
            }
        }

        private void c1ZoomPanel1_ZoomFactorChanged(object sender, EventArgs e)
        {
            
        }

        private void c1Zoom1_ZoomFactorChanged(object sender, EventArgs e) {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e) {
            if (sideMenu.Width == 54) {
                sideMenu.Visible = false;
                sideMenu.Width = 278;
                panelAnimator.ShowSync(sideMenu);
                logoAnimator.ShowSync(logo);
            }
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                // Search
                for (int i=0; i<BluetoothDevices.Count; i++) {
                    if (BluetoothDevices[i].showCustomized && BluetoothDevices[i].connected && BluetoothDevices[i].device_name.IndexOf(searchBox.Text, StringComparison.OrdinalIgnoreCase) >=0) {
                        floorDroplist.selectedIndex = BluetoothDevices[i].floor ;
                        Point mypoint = new Point((int)BluetoothDevices[i].Location.X,(int) BluetoothDevices[i].Location.Y);//sfMap1.GisPointToPixelCoord(BluetoothDevices[i].Location);
                        mypoint.X -= 300;
                        mypoint.Y -= 300;
                        Rectangle myr = new Rectangle(mypoint, new Size(600,600));
                        /*reta
                        sfMap1.FitToExtent();*/
                        sfMap1.FitToExtent(myr);
                        break;
                    }
                }
            }
        }

        private void map_Click(object sender, EventArgs e) {
            adminTools.SendToBack();
            sfMap1.BringToFront();
            if (custmizedChanged) {
                custmizedChanged = false;
                updateCustomized();
            }
            if (boundaryChanged) {
                boundaryChanged = false;
                updateBoundaries();
            }
        }

        public void updateAll() {
            mydbContext = new DatabaseEntities1();
            using (var dbContext = new DatabaseEntities1()) {
                BluetoothDevices = (from c in mydbContext.Devices select c).ToList(); //read data
                BluetoothBeacons = (from c in mydbContext.Beacons select c).ToList(); //read data
                AllBoundaries = (from c in mydbContext.Boundaries select c).ToList(); //read data
            }
            fillCustomizedView();
        }

        private void updateBoundaries() {
            mydbContext = new DatabaseEntities1();
            using (var dbContext = new DatabaseEntities1()) {
                AllBoundaries = (from c in mydbContext.Boundaries select c).ToList(); //read data
            }
        }

        private void updateBeacons() {// Important
            mydbContext = new DatabaseEntities1();
            using (var dbContext = new DatabaseEntities1()) {
                BluetoothBeacons = (from c in mydbContext.Beacons select c).ToList(); //read data
            }
        }

        private void updateDevices() {// Important
            mydbContext = new DatabaseEntities1();
            using (var dbContext = new DatabaseEntities1()) {
                BluetoothDevices = (from c in mydbContext.Devices select c).ToList(); //read data
            }
            fillCustomizedView();
        }

        private void updateCustomized() {
            for (int i = 0; i < BluetoothDevices.Count; i++) {
                BluetoothDevices[i].showCustomized = customizedView1.devicesList.GetItemChecked(i);
            }
        }
        
        private void setBoundaries_Click(object sender, EventArgs e) {
            boundaryControl1.BringToFront();
        }

        private void customize_view_Click_1(object sender, EventArgs e) {
            customizedView1.BringToFront();
        }

        private void adminTools_Click(object sender, EventArgs e) {
            loginForm1.BringToFront();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e) {
            if (WindowState.ToString() == "Normal") {
                this.WindowState = FormWindowState.Maximized;
            } else {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginForm1_Load(object sender, EventArgs e) {

        }

        private void RefreshButton_Click(object sender, EventArgs e) {
            /*if(!isLayerVisible(2))
                makeLayerVisible(2);
            myPoints.Add(getRandomPoint(sfMap1[2],2));*/
            /*BluetoothDevices[0].floor = 0;
            BluetoothDevices[0].connected = true; 
            //BluetoothDevices[0].Location = sfMap1[0].GetShapeBounds(1).Location;
            BluetoothDevices[0].Location = getRandomPoint(sfMap1[1],0);
            BluetoothDevices[1].floor = 0;
            BluetoothDevices[1].connected = true;
            BluetoothDevices[1].Location = getRandomPoint(sfMap1[1], 1);
            BluetoothDevices[2].floor = 1;
            BluetoothDevices[2].connected = true;
            BluetoothDevices[2].Location = getRandomPoint(sfMap1[4], 0);*/
            sfMap1.Refresh();
            RectangleF myr = sfMap1[SelectedFloor * 3].GetActualExtent();
            sfMap1.FitToExtent(myr);
           /* for (int i=0;i<86000;i=0) {

            }*/
        }

        private void History_Click(object sender, EventArgs e)
        {
            History ss = new History();
            Form fc = Application.OpenForms["History"];
            if (fc != null)
                fc.Close();
            ss.Show();
        }

        

    }
}
