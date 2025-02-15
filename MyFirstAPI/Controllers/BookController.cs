using Microsoft.AspNetCore.Mvc;
using MyFirstAPI.Communication.Requests;
using MyFirstAPI.Communication.Responses;
using MyFirstAPI.Entities;

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredBookJson), StatusCodes.Status201Created)]
        public IActionResult Create([FromBody] RequestCreateBookJson request)
        {
            var response = new ResponseRegisteredBookJson
            {
                ID = Guid.NewGuid(),
                Title = request.Title
            };
            return Created();
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
        public IActionResult GetBooks()
        {
            var books = new List<Book>()
            {
                new Book {
                    ID = Guid.NewGuid(),
                    Title = "Jogos Vorazes",
                    Author = "Suzanne Collins",
                    Genre = GenreEnum.Scifi.ToString(),
                    Price = 40.25,
                    Quantity = 23
                },
                new Book {
                    ID = Guid.NewGuid(),
                    Title = "O Homem Mais Rico da Babilônia",
                    Author = "George S. Clason",
                    Genre = GenreEnum.Business.ToString(),
                    Price = 22.42,
                    Quantity = 51
                },
                new Book {
                    ID = Guid.NewGuid(),
                    Title = "Amor, teoricamente",
                    Author = "Ali Hazelwood",
                    Genre = GenreEnum.Romance.ToString(),
                    Price = 44.97,
                    Quantity = 19
                },
                new Book {
                    ID = Guid.NewGuid(),
                    Title = "Nunca Minta",
                    Author = "Freida McFadden",
                    Genre = GenreEnum.Thriller.ToString(),
                    Price = 53.90,
                    Quantity = 9
                }
            };

            return Ok(books);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult UpdateBook([FromRoute] int id, [FromBody] RequestUpdateBookJson request)
        {
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeleteBook([FromRoute] int id)
        {
            return NoContent();
        }
    }
}
