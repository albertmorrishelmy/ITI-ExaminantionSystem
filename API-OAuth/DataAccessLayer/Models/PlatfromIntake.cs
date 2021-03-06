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
    
    public partial class PlatfromIntake
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlatfromIntake()
        {
            this.DepartmentsExams = new HashSet<DepartmentsExam>();
            this.Exams = new HashSet<Exam>();
            this.StudentBasicDatas = new HashSet<StudentBasicData>();
            this.TrackManagers = new HashSet<TrackManager>();
            this.TrackManuals = new HashSet<TrackManual>();
            this.TrackSupervisors = new HashSet<TrackSupervisor>();
        }
    
        public int PlatformIntakeID { get; set; }
        public Nullable<int> BranchID { get; set; }
        public Nullable<int> SubTrackID { get; set; }
        public Nullable<int> ProgramIntakeID { get; set; }
        public Nullable<int> OwnedBy { get; set; }
        public string GraduateProfile { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual Platform Platform { get; set; }
        public virtual ICollection<DepartmentsExam> DepartmentsExams { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ProgramIntake ProgramIntake { get; set; }
        public virtual subTrack subTrack { get; set; }
        public virtual ICollection<StudentBasicData> StudentBasicDatas { get; set; }
        public virtual ICollection<TrackManager> TrackManagers { get; set; }
        public virtual ICollection<TrackManual> TrackManuals { get; set; }
        public virtual ICollection<TrackSupervisor> TrackSupervisors { get; set; }
    }
}
