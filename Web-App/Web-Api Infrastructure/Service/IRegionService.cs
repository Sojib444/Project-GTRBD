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
        public void Add(Region region);
        public IEnumerable<Region> GetAll();
    }
}
