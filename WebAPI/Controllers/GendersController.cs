using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GendersController : ControllerBase
    {
        IGenderService _genderService;
        public GendersController(IGenderService genderService)
        {
            _genderService = genderService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _genderService.GetAll();
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Add")]
        public IActionResult Add(Gender gender)
        {
            var result = _genderService.Add(gender);
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Update")]
        public IActionResult Update(Gender gender)
        {
            var result = _genderService.Update(gender);
            if (result.State)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("Delete")]
        public IActionResult Delete(Gender gender)
        {
            var result = _genderService.Delete(gender);
            if (result.State)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
