using Business.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _bookService.GetAll();
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("Add")]
        public IActionResult Add(Book book)
        {
            var result = _bookService.Add(book);
            if (result.State)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Update")]
        public IActionResult Update(Book book)
        {
            var result = _bookService.Update(book);
            if (result.State)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("Delete")]
        public IActionResult Delete(Book book)
        {
            var result = _bookService.Delete(book);
            if (result.State)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
