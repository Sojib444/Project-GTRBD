using AutoMapper;
using Web_Api_Infrastructure.Entities;
using Web_App.Model.DTO;

namespace Web_App.Profiles
{
    public class WalkProfile:Profile
    {
        public WalkProfile()
        {
            CreateMap(typeof(Walk), typeof(WalkDTO)).ReverseMap();
        }
    }
}
