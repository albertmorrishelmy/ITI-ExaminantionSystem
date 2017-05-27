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
    
    public partial class Employee
    {
        public Employee()
        {
            this.EmployeeNotifications = new HashSet<EmployeeNotification>();
            this.Exams = new HashSet<Exam>();
            this.ExternalInstructorAuthorizations = new HashSet<ExternalInstructorAuthorization>();
            this.InstructorNotifications = new HashSet<InstructorNotification>();
            this.InstructorsConnectionIds = new HashSet<InstructorsConnectionId>();
            this.Platforms = new HashSet<Platform>();
            this.Questions = new HashSet<Question>();
            this.SupervisiorNotifications = new HashSet<SupervisiorNotification>();
            this.SupervisiorsConnectionIds = new HashSet<SupervisiorsConnectionId>();
            this.TrackManagers = new HashSet<TrackManager>();
            this.TrackSupervisors = new HashSet<TrackSupervisor>();
        }
    
        public int EmployeeID { get; set; }
        public string InstructorName { get; set; }
        public int BranchID { get; set; }
        public string IPassword { get; set; }
        public string UserName2 { get; set; }
        public Nullable<int> PlatformID { get; set; }
        public Nullable<int> RoleID { get; set; }
        public Nullable<int> TypeID { get; set; }
        public string ArabicName { get; set; }
        public Nullable<int> CertificateID { get; set; }
        public string FirstNameEn { get; set; }
        public string SecondNameEn { get; set; }
        public string barcode { get; set; }
        public string imagepath { get; set; }
        public Nullable<int> org_branchid { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<int> PositionID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<System.DateTime> HiringDate { get; set; }
        public string ThirdNameEn { get; set; }
        public string FourthNameEn { get; set; }
        public string FirstNameAr { get; set; }
        public string SecondNameAr { get; set; }
        public string ThirdNameAr { get; set; }
        public string FourthNameAr { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }
        public string ExtenistonNo { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public Nullable<int> MaritalStatus { get; set; }
        public Nullable<int> MilitaryStatus { get; set; }
        public Nullable<int> UniversityID { get; set; }
        public Nullable<int> FacultyID { get; set; }
        public Nullable<int> IntakeID { get; set; }
        public Nullable<int> Flag { get; set; }
        public Nullable<int> GraduationYear { get; set; }
        public string Grade { get; set; }
        public Nullable<int> AttendanceFlag { get; set; }
        public string PositionName { get; set; }
        public Nullable<int> EmpStatus { get; set; }
        public System.Guid msrepl_tran_version { get; set; }
        public string IDCard { get; set; }
        public string AttachmentID { get; set; }
        public string AttachmentCV { get; set; }
        public Nullable<int> ATMStatus { get; set; }
        public string ATMNo { get; set; }
        public Nullable<int> SpecialRate { get; set; }
        public string RateNotes { get; set; }
        public Nullable<System.DateTime> ATMExpiryDate { get; set; }
        public Nullable<int> Religionid { get; set; }
        public Nullable<int> empno { get; set; }
        public Nullable<int> cat { get; set; }
    
        public virtual Platform Platform { get; set; }
        public virtual ICollection<EmployeeNotification> EmployeeNotifications { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<ExternalInstructorAuthorization> ExternalInstructorAuthorizations { get; set; }
        public virtual ICollection<InstructorNotification> InstructorNotifications { get; set; }
        public virtual ICollection<InstructorsConnectionId> InstructorsConnectionIds { get; set; }
        public virtual ICollection<Platform> Platforms { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<SupervisiorNotification> SupervisiorNotifications { get; set; }
        public virtual ICollection<SupervisiorsConnectionId> SupervisiorsConnectionIds { get; set; }
        public virtual ICollection<TrackManager> TrackManagers { get; set; }
        public virtual ICollection<TrackSupervisor> TrackSupervisors { get; set; }
    }
}
