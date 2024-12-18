using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult ListStaff()
        {
            var value = _serviceService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddStaff(Service service)
        {
            _serviceService.TInsert(service);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteStaff(int id)
        {
            var valueDel = _serviceService.TGetById(id);
            _serviceService.TDelete(valueDel);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStaff(Service service)
        {
            _serviceService.TUpdate(service);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetStaffById(int id)
        {

            return Ok(_serviceService.TGetById(id));
        }
    }
}
