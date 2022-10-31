using Autofac;
using Microsoft.AspNetCore.Mvc;
using Web_Api_Infrastructure.Service;
using Web_App.Model.Domain;

namespace Web_App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionService _regionService;
        public ILifetimeScope _scope;
        public RegionsController(IRegionService regionService,ILifetimeScope scope)
        {
            _regionService = regionService;
            _scope = scope;
            _regionService=_scope.Resolve<IRegionService>();
        }
        [HttpGet]
        public IActionResult GetAllRegion()
        {

            return Ok(_regionService.GetAll());
        }
    }
}
