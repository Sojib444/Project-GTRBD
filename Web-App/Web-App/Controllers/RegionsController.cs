using Autofac;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Web_Api_Infrastructure.Entities;
using Web_Api_Infrastructure.Service;
using Web_App.Model.Domain;
using Web_App.Model.DTO;

namespace Web_App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionService _regionService;
        public ILifetimeScope _scope;
        private IMapper _mapper;
        public RegionsController(IRegionService regionService,ILifetimeScope scope,IMapper mapper)
        {
            _regionService = regionService;
            _scope = scope;
            _regionService=_scope.Resolve<IRegionService>();
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllRegion()
        {
            var region = _regionService.GetAll();

            var dtoRegion=_mapper.Map<List<RegionDTO>>(region);

            return Ok(dtoRegion);
        }


        [HttpGet]
        [Route("{id:guid}")]
        [ActionName("Get")]
        public IActionResult Get(Guid id)
        {
            var res = _regionService.GetById(id);
            if (res==null)
            {
                return NotFound();
            }
            else 
              return Ok(res);
        }

        
        [HttpPost]
        public IActionResult AddRegion(AddRegionRequest region)
        {

            var pRegion = new Web_Api_Infrastructure.Entities.Region()
            {
                Area = region.Area,
                Lat = region.Lat,
                Code = region.Code,
                Long = region.Long,
                Name = region.Name,
                Population = region.Population,

            };
           // var req=_mapper.Map<Region>(region);
           // var req1=_mapper.Map<Web_Api_Infrastructure.Entities.Region>(region);
            var res= _regionService.Add(pRegion);

            //var result=_mapper.Map<Region>(res);
            return CreatedAtAction(nameof(Get),new {id=res.Id},res);
            
        }


        [HttpDelete]
        [Route("id:guid")]
        public IActionResult Delete(Guid Id)
        {
           var result= _regionService.Delete(Id);
           var dtoRegion = _mapper.Map<RegionDTO>(result);

           return Ok(dtoRegion);
        }


        [HttpPut]
        [Route("id:guid")]
        public IActionResult Update(Guid Id , AddRegionRequest region)
        {
            var pRegion = new Web_Api_Infrastructure.Entities.Region()
            {
                Area = region.Area,
                Lat = region.Lat,
                Code = region.Code,
                Long = region.Long,
                Name = region.Name,
                Population = region.Population,

            };

           var result= _regionService.Update(Id, pRegion);

            return Ok(result);
        }
    }
}
