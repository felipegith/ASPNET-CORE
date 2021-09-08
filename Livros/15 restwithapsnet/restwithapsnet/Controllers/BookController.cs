using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using restwithapsnet.Business;
using restwithapsnet.Hypermedia.Filters;
using restwithapsnet.Model;
using System.Collections.Generic;

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
        [ProducesResponseType((200), Type = typeof(List<BookVO>))]
        [ProducesResponseType((204))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_bookBusiness.FindAll());
        }

        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(BookVO))]
        [ProducesResponseType((204))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        [TypeFilter(typeof(HyperMediaFilter))]
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
        [ProducesResponseType((200), Type = typeof(BookVO))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody] BookVO book)
        {


            if (book == null)
            {
                return BadRequest();
            }

            return Ok(_bookBusiness.Create(book));
        }

        [HttpPut]
        [ProducesResponseType((200), Type = typeof(BookVO))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] BookVO book)
        {


            if (book == null)
            {
                return BadRequest();
            }

            return Ok(_bookBusiness.Update(book));
        }

        [HttpDelete("{id}")]
        [ProducesResponseType((204))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        public IActionResult Delete(long id)
        {

            _bookBusiness.Delete(id);
            return NoContent();

        }
    }
}
