using AutoMapper;
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

        public Region Add(Region region)
        {
            region.Id = Guid.NewGuid();
            _work._region.Add(region);
            _work.Saves();
            _work.Dispose();
            return region;
        }

        public IEnumerable<Region> GetAll()
        {
           return _work._region.GetAll();
            
        }

        public Region GetById(Guid id)
        {
            return _work._region.Get(id);
        }

        public Region Delete(Guid Id)
        {
            var result=_work._region.Delete(Id);
            _work.Saves();
            _work.Dispose();
            return result;
        }
        public Region Update(Guid id,Region region)
        {
            var result= _work._region.Update(id, region);
            result.Name = region.Name;
            result.Area = region.Area;
            result.Walks = region.Walks;
            result.Lat = region.Lat;
            result.Population = region.Population;
            result.Code = region.Code;
            _work.Saves();
            _work.Dispose();

            return result;

        }

    }
}
