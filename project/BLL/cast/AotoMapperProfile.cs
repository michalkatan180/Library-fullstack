using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using DTO;
using DAL;
namespace BLL.cast
{
    //דף זה במקום הכאסט
    public class AotoMapperProfile : Profile
    {
        public AotoMapperProfile()
        {
            //   יעד destination
            //כיצד להמיר את השדות שאין להם אותו שם
            CreateMap<BookDTO, DAL.Book>().
                ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.author)).
                ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id)).
                ForMember(dest => dest.CategoryID, opt => opt.MapFrom(src => src.ageCategory)).
                ForMember(dest => dest.PageCount, opt => opt.MapFrom(src => src.pageCount)).
                ForMember(dest => dest.Summary, opt => opt.MapFrom(src => src.summary)).
                ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.title));
            CreateMap<DAL.Book, BookDTO>() .
                ForMember(dest => dest.author, opt => opt.MapFrom(src => src.Author)).
                ForMember(dest => dest.id, opt => opt.MapFrom(src => src.Id)).
                ForMember(dest => dest.ageCategory, opt => opt.MapFrom(src => src.CategoryID)).
                ForMember(dest => dest.pageCount, opt => opt.MapFrom(src => src.PageCount)).
                ForMember(dest => dest.summary, opt => opt.MapFrom(src => src.Summary)).
                ForMember(dest => dest.title, opt => opt.MapFrom(src => src.Title));

            CreateMap<BorrowerDTO, DAL.Borrower>().
                ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.email)).
                ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.firstName)).
                ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id)).
                ForMember(dest => dest.IdCategory, opt => opt.MapFrom(src => src.ageCategory)).
                ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.lastName)).
                ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.phoneNumber)).
                ForMember(dest => dest.Tz, opt => opt.MapFrom(src => src.tz));
            CreateMap<DAL.Borrower, BorrowerDTO>().
                ForMember(dest => dest.ageCategory, opt => opt.MapFrom(src => src.IdCategory)).
                ForMember(dest => dest.email, opt => opt.MapFrom(src => src.Email)).
                ForMember(dest => dest.firstName, opt => opt.MapFrom(src => src.FirstName)).
                ForMember(dest => dest.id, opt => opt.MapFrom(src => src.Id)).
                ForMember(dest => dest.lastName, opt => opt.MapFrom(src => src.LastName)).
                ForMember(dest => dest.phoneNumber, opt => opt.MapFrom(src => src.PhoneNumber)).
                ForMember(dest => dest.tz, opt => opt.MapFrom(src => src.Tz));

            CreateMap<CategoryDTO, DAL.Category>().
                ForMember(dest => dest.Color, opt => opt.MapFrom(src => src.color)).
                ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.description)).
                ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id)).
                ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.name));
            CreateMap<DAL.Category, CategoryDTO>().
                 ForMember(dest => dest.color, opt => opt.MapFrom(src => src.Color)).
                 ForMember(dest => dest.description, opt => opt.MapFrom(src => src.Description)).
                  ForMember(dest => dest.id, opt => opt.MapFrom(src => src.Id)).
                   ForMember(dest => dest.name, opt => opt.MapFrom(src => src.Name));

            CreateMap<LendingDTO, DAL.Lendings>().
                ForPath(dest => dest.BookId, opt => opt.MapFrom(src => src.bookId)).
                ForPath(dest => dest.BorrowerId, opt => opt.MapFrom(src => src.borrowerId)).
                ForPath(dest => dest.Id, opt => opt.MapFrom(src => src.id)).
                ForPath(dest => dest.LendingDate, opt => opt.MapFrom(src => src.lendingDate)).
                ForPath(dest => dest.ReturnDate, opt => opt.MapFrom(src => src.returnDate));

            CreateMap<DAL.Lendings, LendingDTO>().
                ForPath(dest => dest.bookId, opt => opt.MapFrom(src => src.BookId)).
                ForPath(dest => dest.bookTitle, opt => opt.MapFrom(src => src.Book.Title)).
                ForPath(dest => dest.borrowerFirstName, opt => opt.MapFrom(src => src.Borrower.FirstName)).
                ForPath(dest => dest.borrowerId, opt => opt.MapFrom(src => src.BorrowerId)).
                ForPath(dest => dest.borrowerLastName, opt => opt.MapFrom(src => src.Borrower.LastName)).
                ForPath(dest => dest.id, opt => opt.MapFrom(src => src.Id)).
                ForPath(dest => dest.lendingDate, opt => opt.MapFrom(src => src.LendingDate)).
                ForPath(dest => dest.returnDate, opt => opt.MapFrom(src => src.BookId));
        }
    }
}

