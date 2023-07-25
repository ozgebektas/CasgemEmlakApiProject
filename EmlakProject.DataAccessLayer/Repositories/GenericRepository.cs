using EmlakProject.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            throw new NotImplementedException();
        }

        public T GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetList()
        {
            throw new NotImplementedException();
        }

        public void Insert(T t)
        {
            throw new NotImplementedException();
        }

        public void Update(T t)
        {
            throw new NotImplementedException();
        }
    }
    {
    }
}
