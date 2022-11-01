using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Api_Infrastructure.Entities;

namespace Web_Api_Infrastructure.Service
{
    public interface IWalkService
    {
        Walk Add(Walk region);
        IEnumerable<Walk> GetAll();
        Walk GetById(Guid Id);
        Walk Delete(Guid Id);
        Walk Update(Guid Id, Walk region);
    }
}
