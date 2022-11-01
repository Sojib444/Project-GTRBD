using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Api_Infrastructure.Entities;

namespace Web_Api_Infrastructure.Service
{
    public interface IRegionService
    {
        Region Add(Region region);
        IEnumerable<Region> GetAll();
        Region GetById( Guid Id);
        Region Delete(Guid Id);
        Region Update(Guid Id, Region region);
    }
}
