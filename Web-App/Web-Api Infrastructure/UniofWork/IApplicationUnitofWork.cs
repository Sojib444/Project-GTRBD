using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Api_Infrastructure.Repository;

namespace Web_Api_Infrastructure.UniofWork
{
    public interface IApplicationUnitofWork:IUnitofWork
    {
        IRegionRepository _region { get; set; }
        IWalkdifficultyRepository _walkdificulty { get; set; }
        IWalkRepository _walk { get; set; }
    }
}
