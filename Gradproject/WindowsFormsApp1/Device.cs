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
    
    public partial class Device
    {
        public Device()
        {
            this.Records = new HashSet<Record>();
            this.Boundaries = new HashSet<Boundary>();
        }
    
        public int device_id { get; set; }
        public string device_name { get; set; }
        public string device_bluetooth_address { get; set; }
        public byte[] device_icon { get; set; }
        public Nullable<int> group_id { get; set; }
        public string device_info { get; set; }
        public byte[] device_picture { get; set; }
        public bool device_override_group_icon { get; set; }
    
        public virtual ICollection<Record> Records { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<Boundary> Boundaries { get; set; }
    }
}
