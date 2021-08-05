using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Borrower
    {
        public int Id { get; set; }
        public string Tz { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int? IdCategory { get; set; }
       public virtual Category  Category { get; set; }
        public virtual List<Lendings>  Lendings { get; set; }

    }
}
