using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    interface IOperations<T> where T : class 
    {
        T Get(int id);
        List<T> GetAll();
        List<T> FindBy(Expression<Func<T, bool>> Condition);
        T Add(T Object);
        List<T> AddRange(List<T> LisObj); 


    }
}
