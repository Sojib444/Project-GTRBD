using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Api_Infrastructure.Entities;
using Web_Api_Infrastructure.UniofWork;

namespace Web_Api_Infrastructure.Service
{
    public class RegionService:IRegionService
    {
        private readonly IApplicationUnitofWork _work;
        public RegionService(IApplicationUnitofWork work)
        {
            _work = work;
        }

        public void Add(Region region)
        {
            _work._region.Add(region);
            _work.Saves();
            _work.Dispose();
        }

        public IEnumerable<Region> GetAll()
        {
           return _work._region.GetAll();
            
        }
       
    }
}
