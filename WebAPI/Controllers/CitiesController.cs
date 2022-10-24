using Business.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        ICityService _cityService;
        public CitiesController(ICityService cityService)
        {
            _cityService = cityService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _cityService.GetAll();
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Add")]
        public IActionResult Add(City city)
        {
            var result = _cityService.Add(city);
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Update")]
        public IActionResult Update(City city)
        {
            var result = _cityService.Update(city);
            if (result.State)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("Delete")]
        public IActionResult Delete(City city)
        {
            var result = _cityService.Delete(city);
            if (result.State)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
    
