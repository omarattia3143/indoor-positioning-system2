using SharpCompress.Archives;
using SharpCompress.Archives.Rar;
using SharpCompress.Readers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class mapForm : Form {
        public static double MaxZoomLevel = 10000;
        public static double MinZoomLevel = 0.01;
        public static int IconSize = 16;
        public static double xTrial = 356, yTrial = -308;
        public static int SelectedFloor = 0;
        public static List<Device> BluetoothDevices;
        string Rooms = "C:\\Users\\Omar\\Desktop\\Semester 9\\Grad I\\egis_dt_4_5_7\\try shape\\QGIS\\Indoor Shape Files\\Rooms.shp";
        string Beacons = "C:\\Users\\Omar\\Desktop\\Semester 9\\Grad I\\egis_dt_4_5_7\\try shape\\QGIS\\Indoor Shape Files\\Beacons.shp";
        string Coverage = "C:\\Users\\Omar\\Desktop\\Semester 9\\Grad I\\egis_dt_4_5_7\\try shape\\QGIS\\Indoor Shape Files\\Coverage.shp";
        //string Coverage = "C:\\Users\\Omar\\Desktop\\Semester 9\\Grad I\\egis_dt_4_5_7\\try shape\\QGIS\\cliped\\AllCoverage.shp";
        public static string Bluetooth = "C:/Users/Omar/Desktop/Semester 9/Grad I/egis_dt_4_5_7/old shape files/try shape/QGIS/bticon.png";
        public static int moveCloserToTheOriginBy = 10;
        List<PointF> myPoints;

        public mapForm() {
            InitializeComponent();
            myPoints = new List<PointF>();
            sfMap1.BackColor = Color.White;
            sfMap1.ZoomLevelChanged += SfMap1_ZoomLevelChanged;
            LoadMaps();
            sfMap1.FitToExtent(sfMap1[SelectedFloor * 3].GetActualExtent());
            sfMap1.Paint += SfMap1_Paint;
            sfMap1.MouseClick += SfMap1_MouseClick;
            var dbContext = new DatabaseEntities1(); //class derived from DbContext
           
            var contacts = (from c in dbContext.Devices select c).ToList(); //read data
            BluetoothDevices = contacts;
            //contacts.FirstOrDefault().FirstName = "Alex"; //edit 
            //Device temp = contacts[2];
            //Console.WriteLine(contacts[2].device_name);
            foreach (Device student in contacts) {
                Console.WriteLine("{0}, {1}", student.device_name, student.device_id);
            }
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
            foreach (Device mydevice in BluetoothDevices) {
                if (mydevice.connected && mydevice.floor == SelectedFloor) {
                    Point pt = sfMap1.GisPointToPixelCoord(mydevice.Location);
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    e.Graphics.DrawImage(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "ResizedIcons/Resizedpoliceofficer.png"), pt);
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
                Image img = Image.FromFile(Bluetooth);
                Bitmap temp = ResizeImage(img, IconSize, IconSize);
                temp.Save(iconpath, ImageFormat.Png);
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

        public PointF getClosestPoint(PointF Location, EGIS.ShapeFileLib.ShapeFile sf, int index) {
            double tempAx = sf.GetShapeData(index)[0][0].X;
            double tempAy = sf.GetShapeData(index)[0][0].Y;
            double tempBx = Location.X;
            double tempBy = Location.Y;
            double shortestDistance = Math.Sqrt((tempAx- tempBx)*(tempAx - tempBx) + (tempAy - tempBy)*(tempAy - tempBy));
            int closestPointIndex = 0;
            for (int i =0; i <  sf.GetShapeData(index)[0].Length; i++) {
                PointF mypoint = sf.GetShapeData(index)[0][i];
                tempAx = mypoint.X;
                tempAy = mypoint.Y;
                double dist = Math.Sqrt((tempAx - tempBx) * (tempAx - tempBx) + (tempAy - tempBy) * (tempAy - tempBy));
                if(dist < shortestDistance) {
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
            } else {
                logoAnimator.Hide(logo);
                sideMenu.Visible = false;
                sideMenu.Width = 54;
                panelAnimator.ShowSync(sideMenu);
            }
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

        private void customize_view_Click(object sender, EventArgs e) {
            adminTools.SendToBack();
            sfMap1.BringToFront();
        }

        private void customize_view_Click_1(object sender, EventArgs e)
        {
            
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
            BluetoothDevices[0].floor = 0;
            BluetoothDevices[0].connected = true;
            BluetoothDevices[0].Location = sfMap1[0].GetShapeBounds(1).Location;
            BluetoothDevices[1].floor = 0;
            BluetoothDevices[1].connected = true;
            BluetoothDevices[1].Location = sfMap1[0].GetShapeBounds(2).Location;
            BluetoothDevices[2].floor = 1;
            BluetoothDevices[2].connected = true;
            BluetoothDevices[2].Location = sfMap1[3].GetShapeBounds(1).Location;
            sfMap1.Refresh();
            sfMap1.FitToExtent(sfMap1[SelectedFloor * 3].GetActualExtent());
        }

        private void bunifuFlatButton1_Click_3(object sender, EventArgs e)
        {
            History ss = new History();
            Form fc = Application.OpenForms["History"];
            if (fc != null)
                fc.Close();
            ss.Show();
        }

        

    }
}
