using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using System.Data.Entity;


namespace BusineesLayer
{
    class DataFactory<C, T> : IOperations<T>
        where T : class
        where C : ApplicationContext, new() // It must be a class (reference type) and must have a public parameter-less default constructor.
    {

        private C _Data = new C();

        public C _pdata
        {
            get { return _Data; }
            set { _Data = value; }
        }

        public T Add(T Entity)
        {
            T ReturnObj = null;
            _Data.Set<T>().Add(Entity);
            if (_Data.SaveChanges() > 0)
            {
                ReturnObj = Entity;
            }
            return ReturnObj; 
        }

        public bool AddRange(List<T> Entities)
        {
            bool Flag = false;
            _Data.Set<T>().AddRange(Entities);
            if (_Data.SaveChanges() > 0)
            {
                Flag = true;
            }
            return Flag;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T EntityToDelete)
        {
            throw new NotImplementedException();
        }

        public T FindBy(Expression<Func<bool, T>> Condition)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindListBy(Expression<Func<bool, T>> Condition)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(T EntityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
