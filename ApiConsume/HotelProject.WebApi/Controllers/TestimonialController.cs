using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public IActionResult ListStaff()
        {
            var value = _testimonialService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddStaff(Testimonial testimonial)
        {
            _testimonialService.TInsert(testimonial);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteStaff(int id)
        {
            var valueDel = _testimonialService.TGetById(id);
            _testimonialService.TDelete(valueDel);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStaff(Testimonial testimonial)
        {
            _testimonialService.TUpdate(testimonial);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetStaffById(int id)
        {

            return Ok(_testimonialService.TGetById(id));
        }
    }
}
