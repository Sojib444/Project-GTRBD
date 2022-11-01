using AutoMapper;
using Web_Api_Infrastructure.Entities;
using Web_App.Model.DTO;

namespace Web_App.Profiles
{
    public class RegionProfile:Profile
    {
        public RegionProfile()
        {
            CreateMap(typeof(Region), typeof(RegionDTO)).ReverseMap();
        }
    }
}
