//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nearby_Services
    {
        public int Nearby_Services_ID { get; set; }
        public Nullable<int> Nearby_Services_Category_ID { get; set; }
        public string Nearby_Services_Name { get; set; }
        public long Nearby_Services_Contact { get; set; }
        public string Nearby_Services_Address { get; set; }
        public float Nearby_Services_Distance { get; set; }
        public string Nearby_Services_Details { get; set; }
    
        public virtual Nearby_Services_Category Nearby_Services_Category { get; set; }
    }
}
