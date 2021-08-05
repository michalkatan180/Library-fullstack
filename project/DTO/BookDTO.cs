using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class BookDTO
    {
        /*id: number, title: string,
        author: string, summary: string, ageCategory: number, pageCount: number*/

        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string summary { get; set; }
        public int ageCategory { get; set; }
        public int pageCount { get; set; }


    }
}
