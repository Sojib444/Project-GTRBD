using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Api_Infrastructure.GenericRepository
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        void Add(T item);
        T Get(Guid id);

        T Delete(Guid id);
        T Update(Guid id,T item);
        
    }
}
