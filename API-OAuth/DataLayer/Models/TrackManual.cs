//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrackManual
    {
        public int TrackManualID { get; set; }
        public Nullable<int> CourseManualID { get; set; }
        public Nullable<int> PlatformIntakeID { get; set; }
        public Nullable<bool> IsElective { get; set; }
        public Nullable<int> ElecetiveGroupID { get; set; }
    
        public virtual CourseManual CourseManual { get; set; }
        public virtual PlatfromIntake PlatfromIntake { get; set; }
    }
}
