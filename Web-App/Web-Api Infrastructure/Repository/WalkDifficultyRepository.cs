using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Api_Infrastructure.Entities;
using Web_Api_Infrastructure.GenericRepository;
using Web_Api_Infrastructure.ORM;

namespace Web_Api_Infrastructure.Repository
{
    public class WalkDifficultyRepository:Repository<WalkDifficulty>,IWalkdifficultyRepository
    {
        public WalkDifficultyRepository(IApplicationDbContext _applicationDbContext) : base((DbContext)_applicationDbContext)
        {

        }
    }
}
