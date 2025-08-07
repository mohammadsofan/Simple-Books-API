using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleBooksApi.Models;

namespace SimpleBooksApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IList<Book> _books = new List<Book>(){
            new Book()
            {
                Id = 1,
                Title = "Book1",
                Description = "Book1",
                Author= "Author1",
                Price = 20
            },
            new Book()
            {
                Id = 2,
                Title = "Book2",
                Description = "Book2",
                Author= "Author2",
                Price = 20
            },
            new Book()
            {
                Id = 3,
                Title = "Book3",
                Description = "Book3",
                Author= "Author3",
                Price = 20
            },
            new Book()
            {
                Id = 4,
                Title = "Book4",
                Description = "Book4",
                Author= "Author4",
                Price = 20
            },
            new Book()
            {
                Id = 5,
                Title = "Book5",
                Description = "Book5",
                Author= "Author5",
                Price = 20
            },
        };
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(new {Books =  _books});
        }
    }
}
