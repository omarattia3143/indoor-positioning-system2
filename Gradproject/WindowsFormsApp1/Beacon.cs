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
    
    public partial class Beacon
    {
        public Beacon()
        {
            this.Records = new HashSet<Record>();
            this.Boundaries = new HashSet<Boundary>();
        }
    
        public int beacon_id { get; set; }
        public string beacon_idonmap { get; set; }
        public int beacon_floor { get; set; }
        public string beacon_bluetooth_address { get; set; }
    
        public virtual ICollection<Record> Records { get; set; }
        public virtual ICollection<Boundary> Boundaries { get; set; }
    }
}
