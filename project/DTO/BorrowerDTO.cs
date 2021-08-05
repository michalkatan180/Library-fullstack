using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class BorrowerDTO
    {


        /*id: number, tz: string, ageCategory: number,
        firstName: string, lastName: string, phoneNumber: string, email: string*/

        public int id { get; set; }
        public string tz { get; set; }
        public int ageCategory { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
    }
}
