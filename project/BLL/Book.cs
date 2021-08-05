using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using DAL;
using DTO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BLL
{
    public class Book
    {
        private readonly Library library;
        private readonly IMapper mapper;
        public Book(Library library, IMapper mapper)
        {
            this.library = library;
            this.mapper = mapper;
        }

        //מקבלת קוד ומחזירה ספר לפי קוד
        public async Task<BookDTO> GetBookDTOById(int id)
        {
            DAL.Book b = await library.Books.FindAsync(id);
            return mapper.Map<BookDTO>(b);
        }


        //מקבלת גיל ומחזירה אוסף ספרים מתאימים
        public List<BookDTO> GetBooksByAge(int age)
        {
            //List<DAL.Book> books = library.Books.Where(x => x.Category.Id == age).ToList();
            List<DAL.Book> books = library.Books.Where(x => x.CategoryID.Value == age).ToList();
            List<BookDTO> booksDto = new List<BookDTO>();
            books.ForEach(b => booksDto.Add(mapper.Map<BookDTO>(b)));
            return booksDto;
        }

        //מקבלת מחרוזת ומחזירה אוסף ספרים מתאימים
        public List<BookDTO> GetBooksOnTitle(string title)
        {
            List<DAL.Book> books = library.Books.Where(x => x.Title.Contains(title)).ToList();
            List<BookDTO> booksDto = new List<BookDTO>();
            books.ForEach(b => booksDto.Add(mapper.Map<BookDTO>(b)));
            return booksDto;
        }



        //מחזירה רשימת הספרים
        public List<BookDTO> GetBooksList()
        {
            List<BookDTO> booksDto = new List<BookDTO>();
            library.Books.ToList().ForEach(b => booksDto.Add(mapper.Map<BookDTO>(b)));
            return booksDto;
        }

        //מחזירה מ-די-טי-או לדאל
        public DAL.Book GetBook(BookDTO bookDTO)
        {
            return mapper.Map<DAL.Book>(bookDTO);
        }
        public async Task<BookDTO> DeleteBook(int id)
        {
            DAL.Book x = await library.Books.FindAsync(id);
            library.Books.Remove(x);
            await library.SaveChangesAsync();
            return mapper.Map<BookDTO>(x);
        }
        public BookDTO PutBook(BookDTO toEdit)
        {
            DAL.Book x = mapper.Map<DAL.Book>(toEdit);
            library.Entry(x).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            library.SaveChanges();
            return toEdit;
           }

    }
}
