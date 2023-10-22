using Microsoft.AspNetCore.Mvc;

namespace Sample_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;

        private Book[] Books = new Book[] {
                new Book { Name = "The Lord of The ring",Writer = "J. R. R. Tolkien", PublicationDate = new DateTime(1995,7, 29) },
                new Book { Name = "IT",Writer = "Stephen King", PublicationDate = new DateTime(1986,9, 15) },
                new Book { Name = "Twilight",Writer = "Stephenie Meyer", PublicationDate = new DateTime(2005,9, 27) },
            };

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public IEnumerable<Book> Get()
        {
            return Books;
        }

        /// <summary>
        /// Get Book by Name - Array
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        [HttpGet("{name}")]
        public Book GetByName(string name)
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name.Equals(name)) return Books[i];
            }

            return new Book();
        }

        /// <summary>
        /// Get Book by Name - List with EF
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        [HttpGet("list/{name}")]
        public Book? GetByNameL(string name)
        {
            if (name is null)
                throw new ArgumentNullException(nameof(name));

            return Books.ToList().FirstOrDefault(x => x.Name.Equals(name));
        }

        /// <summary>
        /// Insert a Comic item
        /// </summary>
        /// <param name="name"></param>
        /// <param name="writer"></param>
        /// <param name="datePublication">Correct Format dd-mm-YYYY</param>
        /// <param name="type"></param>
        /// <returns></returns>
        [HttpPost("comic")]
        public Comic SetComic(string name, string writer, string datePublication, string type)
        {
            if (type.ToLower().Equals(Comic.Types.Americano.ToString().ToLower())) type = Comic.Types.Americano.ToString();
            else if (type.ToLower().Equals(Comic.Types.Manga.ToString().ToLower())) type = Comic.Types.Manga.ToString();
            else if (type.ToLower().Equals(Comic.Types.Europeo.ToString().ToLower())) type = Comic.Types.Europeo.ToString();
            else type = Comic.Types.Unidentified.ToString();

            return new Comic { Name = name, Type = type, Writer = writer, PublicationDate = DateTime.Parse(datePublication) };
        }
    }
}