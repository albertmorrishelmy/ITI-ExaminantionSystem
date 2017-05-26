using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace BusineesLayer.Managers
{
    public class EmployeeManager : DataFactory<DataBaseCTX, Employee>
    {
        public List<Employee> GetEmployees()
        {
            var xx = new EmployeeManager().GetAll();
            var y = xx.ToList();
            return y;
        }


    }
}
