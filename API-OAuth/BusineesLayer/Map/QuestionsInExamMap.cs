using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace BusineesLayer.Map
{
    public partial class QuestionsInExamMap
    {
        public int Ques_Id { get; set; }
        public int Exam_Id { get; set; }
        public Nullable<int> Degree { get; set; }

        public virtual Exam Exam { get; set; }
        public virtual Question Question { get; set; }
    }
}
