using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
           _subscribeService = subscribeService;
        }

        [HttpGet]
        public IActionResult ListStaff()
        {
            var value = _subscribeService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddStaff(Subscribe subscribe)
        {
            _subscribeService.TInsert(subscribe);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteStaff(int id)
        {
            var valueDel = _subscribeService.TGetById(id);
            _subscribeService.TDelete(valueDel);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStaff(Subscribe subscribe)
        {
            _subscribeService.TUpdate(subscribe);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetStaffById(int id)
        {

            return Ok(_subscribeService.TGetById(id));
        }

    }
}
