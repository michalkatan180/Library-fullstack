using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Book
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Author { get; set; }//לא חייב לשים
        public int PageCount { get; set; }//חייב לשים
        public int? CategoryID { get; set; }//חייב לשים
        public virtual Category Category { get; set; }
        public virtual List<Lendings> Lendings { get; set; }

    }
}
