//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CourseInstanceDetail
    {
        public CourseInstanceDetail()
        {
            this.Student_Enrollment = new HashSet<Student_Enrollment>();
        }
    
        public int CourseInstanceID { get; set; }
        public Nullable<int> TrackManualID { get; set; }
        public Nullable<int> GroupID { get; set; }
        public Nullable<int> finished { get; set; }
    
        public virtual ICollection<Student_Enrollment> Student_Enrollment { get; set; }
    }
}
