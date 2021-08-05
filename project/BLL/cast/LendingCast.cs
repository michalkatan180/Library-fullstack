using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;

namespace BLL.cast
{
    public class LendingCast
    {
        public static LendingDTO GetLendingDTO(Lendings len)
        {
            LendingDTO lendingDTO = new LendingDTO();
            lendingDTO.bookId = len.BookId.Value; 
            lendingDTO.bookTitle = len.Book.Title;
            lendingDTO.borrowerFirstName = len.Borrower.FirstName;
            lendingDTO.borrowerId = len.BorrowerId.Value;
            lendingDTO.borrowerLastName = len.Borrower.LastName;
            lendingDTO.id = len.Id;
            lendingDTO.lendingDate = len.LendingDate;
            lendingDTO.returnDate = len.ReturnDate;
            return lendingDTO;
        }
   
        public static Lendings GetLending(LendingDTO lendingDto)
        {
            Lendings c = new Lendings();
            c.Book.Id = lendingDto.bookId;
            c.Book.Title = lendingDto.bookTitle;
            c.Borrower.Email = lendingDto.borrowerFirstName;
            c.Borrower.Id = lendingDto.borrowerId;
            c.Borrower.LastName = lendingDto.borrowerLastName;
            c.Id = lendingDto.id;
            c.LendingDate = lendingDto.lendingDate;
            c.ReturnDate = lendingDto.returnDate;
            return c;
        }
    
    }
}
