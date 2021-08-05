using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
namespace BLL.cast
{
    public class BookCast
    {
        public static BookDTO GetBookDTO(DAL.Book book)
        {
            BookDTO bookDTO = new BookDTO();
            bookDTO.ageCategory = book.CategoryID.Value;
            //bookDTO.ageCategory = book.Category.Id;
            bookDTO.author = book.Author;
            bookDTO.id = book.Id;
            bookDTO.pageCount = book.PageCount;
            bookDTO.summary = book.Summary;
            bookDTO.title = book.Title;

            return bookDTO;
        }
        public static DAL.Book GetBook(BookDTO bookDto)
        {
            DAL.Book book = new DAL.Book();
            //book.Category.Id = bookDto.ageCategory;
            book.CategoryID = bookDto.ageCategory;
            book.Author = bookDto.author;
            book.Id = bookDto.id;
            book.PageCount = bookDto.pageCount;
            book.Summary = bookDto.summary;
            book.Title = bookDto.title;

            return book;
        }

    

    }
}
