using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using restwithapsnet.Business;
using restwithapsnet.Model;


namespace restwithapsnet.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly ILogger<BookController> _logger;
        private IBookBusiness _bookBusiness;
        public BookController(ILogger<BookController> logger, IBookBusiness bookBusiness)
        {
            _logger = logger;
            _bookBusiness = bookBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bookBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _bookBusiness.FindById(id);

            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post([FromBody] BookVO book)
        {


            if (book == null)
            {
                return BadRequest();
            }

            return Ok(_bookBusiness.Create(book));
        }

        [HttpPut]
        public IActionResult Put([FromBody] BookVO book)
        {


            if (book == null)
            {
                return BadRequest();
            }

            return Ok(_bookBusiness.Update(book));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {

            _bookBusiness.Delete(id);
            return NoContent();

        }
    }
}
