using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Lendings
    {
        public int Id { get; set; }
        public int? BookId { get; set; }
        public int? BorrowerId { get; set; }
        public DateTime LendingDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public virtual Book Book { get; set; }
        public virtual Borrower Borrower { get; set; }
    }
}
