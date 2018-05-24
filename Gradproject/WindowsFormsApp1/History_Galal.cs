using SharpCompress.Archives;
using SharpCompress.Archives.Rar;
using SharpCompress.Readers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

/*
 2 arrays
 time array from 2 pm to 3 pm
 record array 
     
     
     */

namespace WindowsFormsApp1 {
    public partial class History_Galal : UserControl {
        public static int SelectedFloor = 0;
        private Timer LerpTimer, SimulatorTimer, EverySecondTimer;
        private List<Record> allRecords;
        private Myclass[] mapping;
        private bool simulationSwitch = false;
        private int simulationSecond = 0;
        private DateTime startTime;
        private int speed = 1;
        private float lerpSpeed = 0;
        public static List<Device> BluetoothDevices;

        private class Myclass {
            public int from = -1, to = -1;
        }

        public History_Galal() {
            InitializeComponent();
            //timeSlider.
            //timeSlider.
        }

        public void inisializeMap() {
            sfMap1.BackColor = Color.FromArgb(240, 240, 240);
            sfMap1.ZoomLevelChanged += SfMap1_ZoomLevelChanged;
            LoadMaps();
            sfMap1.FitToExtent(sfMap1[SelectedFloor * 3].GetActualExtent());
            sfMap1.Paint += SfMap1_Paint;
            sfMap1.MouseClick += SfMap1_MouseClick;
            var dbContext = new DatabaseEntities1(); //class derived from DbContext
            var contacts = (from c in dbContext.Devices select c).ToList(); //read data
            timeSlider.ValueChanged += TimeSlider_ValueChanged;
        }

        private void initializeDevices() {
            for (int i = 0; i < BluetoothDevices.Count; i++) {
                CustomizedToolTip myToolTip1 = new CustomizedToolTip();
                myToolTip1.AutoSize = false;
                myToolTip1.BorderColor = Color.Aqua;
                PictureBox mykid = new PictureBox();
                if (BluetoothDevices[i].device_override_group_icon) {
                    if (BluetoothDevices[i].device_icon == null) {
                        mykid.Image = Resources.noman;
                    } else {
                        mykid.Image = ResizeImage(ConvertToImage(BluetoothDevices[i].device_icon), mapForm.IconSize, mapForm.IconSize);
                    }
                } else {
                    if (BluetoothDevices[i].Group == null) {
                        mykid.Image = Resources.noman;
                    } else {
                        if (BluetoothDevices[i].Group.group_icon == null) {
                            mykid.Image = Resources.noman;
                        } else {
                            mykid.Image = ResizeImage(ConvertToImage(BluetoothDevices[i].Group.group_icon), mapForm.IconSize, mapForm.IconSize);
                        }
                    }
                }
                mykid.SizeMode = PictureBoxSizeMode.AutoSize;
                mykid.BackColor = Color.Transparent;
                mykid.Name = i + "";
                mykid.Click += Device_Click;
                String mygrop = "No Group";
                if (BluetoothDevices[i].Group != null)
                    mygrop = BluetoothDevices[i].Group.group_name;
                myToolTip1.SetToolTip(mykid, "Name: " + BluetoothDevices[i].device_name + "\nGroup: " + mygrop);
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
            Console.WriteLine("I Was Clicked " + button.Name);
        }

        private void TimeSlider_ValueChanged(object sender, EventArgs e)//user set the value himself
        {
            if(simulationSwitch)
                switchToPause();
            simulationSecond = timeSlider.Value;
            timeText.Text = startTime.AddSeconds(simulationSecond).ToString("dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
            //Here we are supposed to draw location on the map
            updateAllDevicesOnMap();
        }

        public void StartEverySecond(int myspeed) {
            EverySecondTimer = new Timer();
            EverySecondTimer.Tick += new EventHandler(EverySecond);
            EverySecondTimer.Interval = 1000 / myspeed; // in miliseconds
            EverySecondTimer.Start();
        }

        public void changeEverySecondSpeed(int myspeed) {
            EverySecondTimer.Stop();
            EverySecondTimer.Interval = 1000 / myspeed;
            if (simulationSwitch)
                EverySecondTimer.Start();
        }

        private void EverySecond(object sender, EventArgs e) {
            Random rnd = new Random();
            foreach (Device mydevice in BluetoothDevices) {
                if (mydevice.inActive > 0)
                    mydevice.inActive--;
                else
                    mydevice.connected = false;
            }
        }

        public void StartLerp(int myspeed) {
            LerpTimer = new Timer();
            LerpTimer.Tick += new EventHandler(Lerper);
            LerpTimer.Interval = 30/myspeed; // in miliseconds
            lerpSpeed = ((float)LerpTimer.Interval) / 1000f;
            //LerpTimer.Start();
        }

        public void changeLerpSpeed(int myspeed) {
            LerpTimer.Stop();
            LerpTimer.Interval = 30 / myspeed; // in miliseconds
            lerpSpeed = ((float)LerpTimer.Interval) / 1000f;
            if(simulationSwitch)
                LerpTimer.Start();
        }

        private void Lerper(object sender, EventArgs e) {
            if (simulationSwitch) {
                foreach (Device mydevice in BluetoothDevices) {
                    mydevice.lerpVariable += 0.05f;
                    if (mydevice.lerpVariable >= 0.98f)
                        mydevice.lerpVariable = 1;
                    mydevice.Location = lerp(mydevice.FromLocation, mydevice.ToLocation, mydevice.lerpVariable);
                }
                sfMap1.Refresh();
            }
        }

        private PointF lerp(PointF v0, PointF v1, float t) {
            PointF myoutput = new PointF(v0.X + t * (v1.X - v0.X), v0.Y + t * (v1.Y - v0.Y));
            return myoutput;
        }

        public void StartSimulator(int myspeed) {
            SimulatorTimer = new Timer();
            SimulatorTimer.Tick += new EventHandler(Simulator);
            SimulatorTimer.Interval = 1000/myspeed; // in miliseconds
            //SimulatorTimer.Start();
        }

        public void changeSimulatorSpeed(int myspeed) {
            SimulatorTimer.Stop();
            SimulatorTimer.Interval = 1000 / myspeed; // in miliseconds
            if(simulationSwitch)
                SimulatorTimer.Start();
        }

        private void Simulator(object sender, EventArgs e) {
            if (simulationSwitch) {
                if (timeSlider.Value < timeSlider.MaximumValue) {
                    timeSlider.Value = ++simulationSecond;
                    //totalTimeText.Text = "Value = " + timeSlider.Value;
                    timeText.Text = startTime.AddSeconds(simulationSecond).ToString("dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                    timeSlider.Invalidate();
                    updateAllDevicesOnMap();
                    /*if (mapping[simulationSecond] != null) {
                        //sfMap1.Refresh();
                    }*/
                } else {
                    switchToPause();
                }
            }
        }

        public void updateAllDevicesOnMap() {
            for (int i = 0; i<BluetoothDevices.Count;i++) {

                if (BluetoothDevices[i].History_Time.Contains(simulationSecond)) {
                    float myx = BluetoothDevices[i].History_Location[BluetoothDevices[i].History_Time.IndexOf(simulationSecond)].X;
                    float myy = BluetoothDevices[i].History_Location[BluetoothDevices[i].History_Time.IndexOf(simulationSecond)].Y;
                    BluetoothDevices[i].ToLocation = new PointF(myx, myy);
                    BluetoothDevices[i].FromLocation = BluetoothDevices[i].Location;
                    BluetoothDevices[i].connected = true;
                    BluetoothDevices[i].lerpVariable = 0;
                    Beacon myb = BluetoothDevices[i].History_Beacon[BluetoothDevices[i].History_Time.IndexOf(simulationSecond)];
                    if (BluetoothDevices[i].floor != myb.beacon_floor || !simulationSwitch) {
                        BluetoothDevices[i].lerpVariable = 1;
                        BluetoothDevices[i].Location = BluetoothDevices[i].ToLocation;
                        BluetoothDevices[i].FromLocation = BluetoothDevices[i].Location;
                        BluetoothDevices[i].floor = myb.beacon_floor;
                    }
                } else {
                    BluetoothDevices[i].connected = false;
                }

            }
            sfMap1.Refresh();

            
        }

        public void initializeHistoryFunctions(DateTime start, DateTime end, List<Record> myRecords, List<Device> myDevices) {
            //StartLerp();
            BluetoothDevices = myDevices;
            startTime = start;
            totalTimeText.Text = end.ToString("dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
            timeText.Text = start.ToString("dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
            speedText.Text = "Speed x" + speed;
            allRecords = myRecords;
            //int durationInSeconds = (int)(History.endDate - History.startDate).TotalSeconds;
            int durationInSeconds = (int)(end - start).TotalSeconds;
            List<int> myIndicies = new List<int>();
            foreach (Device myd in BluetoothDevices) {
                myIndicies.Add(myd.device_id);
            }
            foreach (Record myr in myRecords) {
                int deviceInteger = myIndicies.IndexOf(myr.Device.device_id);
                if(deviceInteger != -1) {
                    int myt = (int) (myr.record_time - start).TotalSeconds;
                    BluetoothDevices[deviceInteger].History_Time.Add(myt);
                    float x = (float) myr.record_location_x;
                    float y = (float) myr.record_location_y;
                    PointF myp = new PointF(x, y);
                    BluetoothDevices[deviceInteger].History_Location.Add(myp);
                    BluetoothDevices[deviceInteger].History_Beacon.Add(myr.Beacon);
                }
            }
            initializeDevices();
            /*mapping = new Myclass[durationInSeconds];
            int myindex = 0;
            for (int i=0; i<durationInSeconds;i++) {
                bool vergin = true;
                while (myindex < myRecords.Count && start == myRecords[myindex].record_time) {
                    if (vergin) {
                        mapping[i] = new Myclass();
                        mapping[i].from = myindex;
                        vergin = false;
                    }
                    mapping[i].to = myindex;
                    myindex++;
                }
                start = start.AddSeconds(1);
            }*/
            //timeText.Text = "Total sec = "+durationInSeconds;
            timeSlider.MaximumValue = durationInSeconds;
            StartSimulator(speed);
            StartLerp(speed);
            StartEverySecond(speed);
        }

        private void LoadMaps() {
            string MapsPath = AppDomain.CurrentDomain.BaseDirectory + "Maps";
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
            }
            directories = Directory.GetDirectories(MapsPath);
            bool setFLoorVisible = true;
            for (int i = 0; i < directories.Length; i++) {
                Console.WriteLine(directories[i]);
                LoadRooms(directories[i] + "/Rooms.shp", "Rooms " + i, setFLoorVisible);
                LoadCoverage(directories[i] + "/Coverage.shp", "Coverage " + i, false);
                LoadBeacons(directories[i] + "/Beacons.shp", "Beacons " + i, setFLoorVisible);
                setFLoorVisible = false;
                floorDropList.AddItem("Floor " + (i + 1));
            }
            floorDropList.selectedIndex = 0;
            floorDropList.onItemSelected += floorDropList_onItemSelected;

        }

        private void floorDropList_onItemSelected(object sender, EventArgs e) {
            //Console.WriteLine(""+ floorDroplist.selectedIndex);
            if (floorDropList.selectedIndex != SelectedFloor) {
                int tempint = SelectedFloor * 3;
                for (int i = 0; i < 3; i++) {
                    makeLayerInvisible(tempint + i);
                }
                SelectedFloor = floorDropList.selectedIndex;
                tempint = SelectedFloor * 3;
                for (int i = 0; i < 3; i++) {
                    //if (i == 1)
                    //    continue;
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

        private void SfMap1_MouseClick(object sender, MouseEventArgs e) {
            //throw new NotImplementedException();
            if (e.Button == System.Windows.Forms.MouseButtons.Left) {
                Console.WriteLine("X = " + sfMap1.MousePosToGisPoint(e.Location).X + ", Y = " + sfMap1.MousePosToGisPoint(e.Location).Y);
            }

        }

        private void SfMap1_Paint(object sender, PaintEventArgs e) {
            /*if (mapping[simulationSecond] != null)
                for (int i = mapping[simulationSecond].from; i <= mapping[simulationSecond].to; i++) {
                    if (allRecords[i].Device.floor == SelectedFloor) {
                        Point pt = sfMap1.GisPointToPixelCoord(allRecords[i].Device.Location);
                        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        e.Graphics.DrawImage(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "ResizedIcons/Resizedpoliceofficer.png"), pt);
                    }
            }*/
            for (int i = 0; i < BluetoothDevices.Count; i++) {
                Device mydevice = BluetoothDevices[i];
                if (mydevice.connected && mydevice.floor == SelectedFloor) {
                    sfMap1.Controls[i].Visible = true;
                    if (mydevice.History_Time.Contains(simulationSecond)) {
                        Point pt = sfMap1.GisPointToPixelCoord(mydevice.Location);
                        sfMap1.Controls[i].Location = sfMap1.GisPointToPixelCoord(mydevice.Location);
                    } else {
                        sfMap1.Controls[i].Visible = false;
                    }
                    /* We Can Check For Overlap here .....  LATER
                    for () {

                    }*/
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
            if (sfMap1.ZoomLevel < mapForm.MinZoomLevel) {
                sfMap1.ZoomLevel = mapForm.MinZoomLevel;
            }
            if (sfMap1.ZoomLevel > mapForm.MaxZoomLevel) {
                sfMap1.ZoomLevel = mapForm.MaxZoomLevel;
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
            EGIS.ShapeFileLib.ShapeFile sf = this.sfMap1[this.sfMap1.ShapeFileCount - 1];
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
            string iconpath = AppDomain.CurrentDomain.BaseDirectory + "ResizedIcons/Resizedbticon.png";
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


        }

        public PointF getClosestPoint(PointF Location, EGIS.ShapeFileLib.ShapeFile sf, int index) {
            double tempAx = sf.GetShapeData(index)[0][0].X;
            double tempAy = sf.GetShapeData(index)[0][0].Y;
            double tempBx = Location.X;
            double tempBy = Location.Y;
            double shortestDistance = Math.Sqrt((tempAx - tempBx) * (tempAx - tempBx) + (tempAy - tempBy) * (tempAy - tempBy));
            int closestPointIndex = 0;
            for (int i = 0; i < sf.GetShapeData(index)[0].Length; i++) {
                PointF mypoint = sf.GetShapeData(index)[0][i];
                tempAx = mypoint.X;
                tempAy = mypoint.Y;
                double dist = Math.Sqrt((tempAx - tempBx) * (tempAx - tempBx) + (tempAy - tempBy) * (tempAy - tempBy));
                if (dist < shortestDistance) {
                    shortestDistance = dist;
                    closestPointIndex = i;
                }
            }
            PointF closestPoint = sf.GetShapeData(index)[0][closestPointIndex];
            double centerPointY = sf.GetShapeBoundsD(index).Bottom - (sf.GetShapeBoundsD(index).Height / 2);
            double centerPointX = sf.GetShapeBoundsD(index).Right - (sf.GetShapeBoundsD(index).Width / 2);
            Console.WriteLine("Buttom " + sf.GetShapeBoundsD(index).Bottom + " : Top " + sf.GetShapeBoundsD(index).Top
                + " : Right " + sf.GetShapeBoundsD(index).Right + " : Left " + sf.GetShapeBoundsD(index).Left);
            Console.WriteLine("Width: " + sf.GetShapeBoundsD(index).Width + " | Height: " + sf.GetShapeBoundsD(index).Height);
            Console.WriteLine("Center X: " + centerPointX + " | Center Y: " + centerPointY);
            Console.WriteLine("X: " + closestPoint.X + " | Y: " + closestPoint.Y);
            if (centerPointX - closestPoint.X < 0) {
                closestPoint.X -= mapForm.moveCloserToTheOriginBy;
            } else if (centerPointX - closestPoint.X > 0) {
                closestPoint.X += mapForm.moveCloserToTheOriginBy;
            }
            if (centerPointY - closestPoint.Y < 0) {
                closestPoint.Y -= mapForm.moveCloserToTheOriginBy;
            } else if (centerPointY - closestPoint.Y > 0) {
                closestPoint.Y += mapForm.moveCloserToTheOriginBy;
            }
            Console.WriteLine("X: " + closestPoint.X + " | Y: " + closestPoint.Y);
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
                closestPoint.X -= mapForm.moveCloserToTheOriginBy;
            } else if (centerPointX - closestPoint.X > 0) {
                closestPoint.X += mapForm.moveCloserToTheOriginBy;
            }
            if (centerPointY - closestPoint.Y < 0) {
                closestPoint.Y -= mapForm.moveCloserToTheOriginBy;
            } else if (centerPointY - closestPoint.Y > 0) {
                closestPoint.Y += mapForm.moveCloserToTheOriginBy;
            }
            Console.WriteLine("X: " + closestPoint.X + " | Y: " + closestPoint.Y);
            return closestPoint;
        }

        public int getRecordNumberByAttribute(EGIS.ShapeFileLib.ShapeFile sf, int attribute, String value) {
            for (int i = 0; i < sf.RecordCount; i++) {
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

        private void PlayButton_Click(object sender, EventArgs e) {
            if (simulationSwitch) {
                switchToPause();
            } else {
                switchToPlay();
            }
        }

        private void switchToPause() {
            SimulatorTimer.Stop();
            simulationSwitch = false;
            LerpTimer.Stop();
            PlayButton.Image = WindowsFormsApp1.Properties.Resources.Play_blue_icons_0008_Layer_9;
        }

        private void switchToPlay() {
            simulationSwitch = true;
            SimulatorTimer.Start();
            LerpTimer.Start();
            PlayButton.Image = WindowsFormsApp1.Properties.Resources.Play_blue_icons_0000_Layer_1;
        }

        private void SlowerButton_Click(object sender, EventArgs e) {
            if (speed > 1) {
                speed--;
                speedText.Text = "Speed x" + speed;
                changeSimulatorSpeed(speed);
                changeLerpSpeed(speed);
                changeEverySecondSpeed(speed);
            }
        }

        private void FasterButton_Click(object sender, EventArgs e) {
            if (speed < 4) {
                speed++;
                speedText.Text = "Speed x" + speed;
                changeSimulatorSpeed(speed);
                changeLerpSpeed(speed);
                changeEverySecondSpeed(speed);
            }
        }

        private void zoomOut_Click(object sender, EventArgs e) {
            sfMap1.Refresh();
            sfMap1.FitToExtent(sfMap1[SelectedFloor * 3].GetActualExtent());
        }
        
    }
}
