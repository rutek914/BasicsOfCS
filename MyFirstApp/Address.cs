using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Address
    {
		private string _street;

		public string Street
		{
            get => _street;
			set { _street = value; }
		}
        public int HouseNumber { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }

    }
}