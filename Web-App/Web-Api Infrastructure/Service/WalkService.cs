using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Api_Infrastructure.Entities;
using Web_Api_Infrastructure.UniofWork;

namespace Web_Api_Infrastructure.Service
{
    public class WalkService : IWalkService
    {
        private readonly IApplicationUnitofWork _work;
        public WalkService(IApplicationUnitofWork work)
        {
            _work = work;
        }
        public Walk Add(Walk region)
        {
            throw new NotImplementedException();
        }

        public Walk Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Walk> GetAll()
        {
            return _work._walk.GetAll();
        }

        public Walk GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Walk Update(Guid Id, Walk region)
        {
            throw new NotImplementedException();
        }
    }
}
