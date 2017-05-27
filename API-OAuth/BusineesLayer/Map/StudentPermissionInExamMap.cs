using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace BusineesLayer.Map
{
    class StudentPermissionInExamMap
    {
        public int Std_Id { get; set; }
        public int Exam_Id { get; set; }
        public Nullable<System.DateTime> Permission_Date { get; set; }

        public virtual StudentBasicData StudentBasicData { get; set; }
        public virtual Exam Exam { get; set; }
    }
}
