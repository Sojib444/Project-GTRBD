using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Api_Infrastructure.Entities;
using Web_Api_Infrastructure.GenericRepository;
using Web_Api_Infrastructure.ORM;
using Web_App.ORM;

namespace Web_Api_Infrastructure.Repository
{
    public class Regionrepository:Repository<Region>,IRegionRepository
    {
        public Regionrepository(IApplicationDbContext _applicationDbContext):base((DbContext)_applicationDbContext)
        {

        }
    }
}
