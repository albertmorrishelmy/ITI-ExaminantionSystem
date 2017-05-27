using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace BusineesLayer.Map
{
    class NewDateExamForPermittedStudentMap
    {
        public int Std_Id { get; set; }
        public int New_Exam_Id { get; set; }
        public Nullable<System.DateTime> New_Date { get; set; }
        
        public virtual Exam Exam { get; set; }
    }
}
