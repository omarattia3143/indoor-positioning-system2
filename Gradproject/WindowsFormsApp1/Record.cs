//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Record
    {
        public int record_id { get; set; }
        public Nullable<int> rssi { get; set; }
        public Nullable<int> device_id { get; set; }
        public Nullable<int> beacon_id { get; set; }
        public Nullable<System.DateTime> record_time { get; set; }
        public Nullable<double> record_location_x { get; set; }
        public Nullable<double> record_location_y { get; set; }
    
        public virtual Beacon Beacon { get; set; }
        public virtual Device Device { get; set; }
    }
}
