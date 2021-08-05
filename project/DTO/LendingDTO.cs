using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public  class LendingDTO
    {
        /*id: number,borrowerId:number, borrowerFirstName: string, 
         * borrowerLastName: string, bookId: number,
         * bookTitle: string, lendingDate: Date, returnDate: Date*/

        public int id { get; set; }
        public int borrowerId { get; set; }
        public string borrowerFirstName { get; set; }
        public string borrowerLastName { get; set; }
        public int bookId { get; set; }
        public string bookTitle { get; set; }
        public DateTime lendingDate { get; set; }
        public DateTime returnDate { get; set; }

    }
}
