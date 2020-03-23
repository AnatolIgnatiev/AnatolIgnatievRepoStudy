using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registry
/*Клас StudentAddress повинен містити такі дані: країна, місто, адреса.*/
{
    public class StudentAddress
    {
        public string country;
        public string city;
        public string address;
        public override string ToString()
        {
            return $"Country: {country}, City: {city}, Address: {address}";
        }
    }
}
