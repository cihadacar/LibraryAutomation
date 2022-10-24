using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictsController : ControllerBase
    {
        IDistrictService _districtService;
        public DistrictsController(IDistrictService districtService)
        {
            _districtService = districtService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _districtService.GetAll();
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Add")]
        public IActionResult Add(District district)
        {
            var result = _districtService.Add(district);
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Update")]
        public IActionResult Update(District district)
        {
            var result = _districtService.Update(district);
            if (result.State)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("Delete")]
        public IActionResult Delete(District district)
        {
            var result = _districtService.Delete(district);
            if (result.State)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
