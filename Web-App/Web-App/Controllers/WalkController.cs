using Autofac;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Web_Api_Infrastructure.Service;
using Web_App.Model.DTO;

namespace Web_App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WalkController:Controller
    {
        private readonly IWalkService _walkService;
        public ILifetimeScope _scope;
        private IMapper _mapper;
        public WalkController(IWalkService walkService, ILifetimeScope scope, IMapper mapper)
        {
            _walkService = walkService;
            _scope = scope;
            _walkService = _scope.Resolve<IWalkService>();
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllWalk()
        {
            var region = _walkService.GetAll();

            var dtoRegion = _mapper.Map<List<WalkDTO>>(region);

            return Ok(dtoRegion);
        }

    }
}
