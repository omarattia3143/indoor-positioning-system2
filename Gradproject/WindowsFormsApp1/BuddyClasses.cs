using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1 {
    public partial class Device {
        public PointF Location = new PointF(0f, 0f);
        public PointF FromLocation = new PointF(0f, 0f);
        public PointF ToLocation = new PointF(0f, 0f);
        public int floor = -1;
        public float lerpVariable = 0;
        public bool connected = false;
        // for simulation purposes
        public int lastBeacon = 0;
        public int ticksB4ChangingBeacon = 0;
    }
    public static class Aclass {
        public static DateTime TrimMilliseconds(this DateTime dt) {
            return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, 0);
        }
        
    }

    public partial class Record {
        public PointF Location = new PointF(0f, 0f);
        public PointF FromLocation = new PointF(0f, 0f);
        public PointF ToLocation = new PointF(0f, 0f);
        public float lerpVariable = 0;
    }
}
