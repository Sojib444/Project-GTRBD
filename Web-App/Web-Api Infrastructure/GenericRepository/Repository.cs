using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Api_Infrastructure.ORM;
using Web_App.ORM;

namespace Web_Api_Infrastructure.GenericRepository
{
    public  abstract class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext applicationDbContext;
        private readonly DbSet<T> _set;
        
        public Repository(DbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
            _set = _applicationDbContext.Set<T>();
        }
        public virtual void Add(T item)
        {
            _set.Add(item);
           
            
        }

        public T Delete(Guid id)
        {
            var result=_set.Find(id);
            if(result!=null)
            {
                applicationDbContext.Remove(result);
            }
            return result;
        }

        public T Get(Guid id)
        {
            return _set.Find(id);
        }

        public  virtual IEnumerable<T> GetAll()
        {
           return  _set.ToList();
        }

        public T Update(Guid id, T item)
        {
            var result=_set.Find(id);
            return result;
        }
    }
}
