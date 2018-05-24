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
    public partial class Beacon_Config_map : UserControl {
        public int SelectedFloor = 0;

        private class Myclass {
            public int from = -1, to = -1;
        }

        public Beacon_Config_map() {
            InitializeComponent();
        }

        public void initializeMap() {
            sfMap1.BackColor = Color.FromArgb(240, 240, 240);
            sfMap1.ZoomLevelChanged += SfMap1_ZoomLevelChanged;
            LoadMaps();
            sfMap1.FitToExtent(sfMap1[SelectedFloor * 3].GetActualExtent());
            sfMap1.Paint += SfMap1_Paint;
            var dbContext = new DatabaseEntities1(); //class derived from DbContext
            var contacts = (from c in dbContext.Devices select c).ToList(); //read data
        }

        public void drawDeviceOnMap(Record myrecord) {
            myrecord.Device.ToLocation = new PointF((float)myrecord.record_location_x, (float)myrecord.record_location_y);
            myrecord.Device.FromLocation = myrecord.Location;
            myrecord.Device.connected = true;
            myrecord.Device.lerpVariable = 0;
            if (myrecord.Device.floor != myrecord.Beacon.beacon_floor) {
                myrecord.Device.lerpVariable = 1;
                myrecord.Device.Location = myrecord.Device.ToLocation;
                myrecord.Device.FromLocation = myrecord.Device.Location;
            }
            myrecord.Device.floor = myrecord.Beacon.beacon_floor;

            sfMap1.Refresh();
        }

        public void initializeHistoryFunctions() {
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
                LoadCoverage(directories[i] + "/Coverage.shp", "Coverage " + i, setFLoorVisible);
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

        

        private void SfMap1_Paint(object sender, PaintEventArgs e) {
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

        private void zoomOut_Click(object sender, EventArgs e) {
            sfMap1.Refresh();
            sfMap1.FitToExtent(sfMap1[SelectedFloor * 3].GetActualExtent());
        }

    }
}
