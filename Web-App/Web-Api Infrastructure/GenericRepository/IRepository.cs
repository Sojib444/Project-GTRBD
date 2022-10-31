using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Api_Infrastructure.GenericRepository
{
    public interface IRepository<T>
    {
        public IEnumerable<T> GetAll();
        public void Add(T item);
    }
}
