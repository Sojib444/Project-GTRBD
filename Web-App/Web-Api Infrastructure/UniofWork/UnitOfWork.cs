using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Api_Infrastructure.ORM;

namespace Web_Api_Infrastructure.UniofWork
{
    public class UnitOfWork : IUnitofWork
    {
        private readonly DbContext dbContext;
        public UnitOfWork(DbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public void Dispose()
        {
            dbContext.Dispose();
        }

        public void Saves()
        {
            dbContext.SaveChanges();
        }
    }
}
