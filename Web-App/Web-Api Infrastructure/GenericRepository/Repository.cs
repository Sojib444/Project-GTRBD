using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Api_Infrastructure.GenericRepository
{
    public class Repository<T> : IRepository<T> where T:class
    {
        public void Add(T item)
        {
            throw new NotImplementedException();
        }
    }
}
