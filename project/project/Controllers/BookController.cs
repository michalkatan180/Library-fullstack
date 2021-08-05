using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using DTO;
using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Cors;

namespace project.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BLL.Book b;
        private readonly Library library;

        public BookController(BLL.Book b, Library l)
        {
            this.b = b;
            library = l;
        }

        [HttpGet]
        [EnableCors("myPolicy")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
        public ActionResult<IEnumerable<BookDTO>> GetBooksList()
        {
            return Ok(b.GetBooksList());
        }

        [HttpGet("{id}")]
        [EnableCors("myPolicy")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDTO))]
        public async Task<IActionResult> GetBook(int id)
        {
            BookDTO x = await b.GetBookDTOById(id);
            if (x == null) return NotFound();
            return Ok(x);
        }


      [HttpGet("byAge/{age:int}")]
      public  List<BookDTO> GetBooksByAge(int age)
        {
            return  b.GetBooksByAge(age);
        }

        [HttpGet("byTitle/{title}")]
        [EnableCors("myPolicy")]
        public List<BookDTO> GetBooksContainsName(string title)
        {
            return b.GetBooksOnTitle(title);
        }

        //[EnableCors("myPolicy")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]

        public IActionResult PostBook(DTO.BookDTO toAdd)
        {
            var bb = b.GetBook(toAdd);
            library.Books.Add(bb);
            library.SaveChanges();
            return Ok(toAdd);
        }

        [HttpDelete("{id}")]
        [EnableCors("myPolicy")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteBook(int id)
        {
            BookDTO x = b.DeleteBook(id).Result;
            if (x == null) return NotFound();
            return Ok(x);
        }

        [HttpPut("{id}")]
        [EnableCors("myPolicy")]
        public ActionResult PutBook(int id, BookDTO toEdit)
        {
            if (b == null) return NotFound();
            if (id != toEdit.id) return Conflict();
                  BookDTO x=  b.PutBook( toEdit);
            if (x == null) return NotFound();
            return Ok(x);
        }

    }
}
