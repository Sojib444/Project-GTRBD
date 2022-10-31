using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Api_Infrastructure.ORM;
using Web_Api_Infrastructure.Repository;

namespace Web_Api_Infrastructure.UniofWork;

public class ApplicationUnitofWork : UnitOfWork, IApplicationUnitofWork
{
    public ApplicationUnitofWork(IApplicationDbContext dbContext, IRegionRepository region,
                              IWalkdifficultyRepository walkdificulty, IWalkRepository walk)
                                     :base((DbContext)dbContext)
    {
        _region = region;
        _walkdificulty = walkdificulty;
        _walk = walk;
    }
    public IRegionRepository _region { get; set; }
    public IWalkdifficultyRepository _walkdificulty { get; set; }
    public IWalkRepository _walk { get; set; }

   
}
