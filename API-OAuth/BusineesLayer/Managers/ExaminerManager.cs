using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;


namespace BusineesLayer.Managers
{
    public class ExaminerManager : DataFactory<DataBaseCTX,Employee>
    {

        // Security = 80 , Security Student = 81
        public List<Employee> GetExaminers()
        {
            var Ex = new ExaminerManager().FindListBy(x=>x.TypeID == 80 || x.TypeID == 81 );
            var ExL = Ex.ToList();
            return ExL; 
        }
    }
}
