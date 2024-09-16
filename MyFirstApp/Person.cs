using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Person
    {
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public DateTime Birthday { get; set; }
        public int Phonenummber { get; set; }
        public string EmailAdress { get; set; }
        public Address Adress { get; set; }

        public int CalculateCurrentAge()
        {
            var today = DateTime.Today;
            var age = today.Year - Birthday.Year;
            return age;
        }

    }
}
