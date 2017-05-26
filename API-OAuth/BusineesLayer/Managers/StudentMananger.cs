using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace BusineesLayer.Managers
{
    public class StudentMananger : DataFactory<DataBaseCTX , StudentBasicData>
    {
        public List<StudentBasicData> GetStudents()
        {
            var xx = new StudentMananger().GetAll().ToList();
            return xx;
        }

        
    }
}
