using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
namespace BLL.cast
{
    public class BorrowerCast
    {
        public static BorrowerDTO GetBorrowerDTO(DAL.Borrower borrower)
        {
            BorrowerDTO borrowerDTO = new BorrowerDTO();
            borrowerDTO.ageCategory = borrower.IdCategory.Value; ;
            borrowerDTO.email = borrower.Email;
            borrowerDTO.firstName = borrower.FirstName;
            borrowerDTO.id = borrower.Id;
            borrowerDTO.lastName = borrower.LastName;
            borrowerDTO.phoneNumber = borrower.LastName;
            borrowerDTO.tz = borrower.Tz;
            return borrowerDTO;
        }
     
        public static DAL.Borrower GetBorrower(BorrowerDTO borrowerDTO)
        {
            DAL.Borrower borrower = new DAL.Borrower();
            borrower.IdCategory = borrowerDTO.ageCategory;
            borrower.Email = borrowerDTO.email;
            borrower.Id = borrowerDTO.id;
            borrower.FirstName = borrowerDTO.firstName;
            borrower.LastName = borrowerDTO.lastName;
            borrower.PhoneNumber = borrowerDTO.phoneNumber;
            borrower.Tz = borrowerDTO.tz;
            return borrower;
        }
       
    }
}
