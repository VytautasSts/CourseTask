using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using CourseTask.Models;

namespace CourseTask.Models
{
    public struct CountryList
    {
        public int ID { get; set; }
        public string CompanyCountryCode { get; set; }
        public string CompanyCountryName { get; set; }
        public bool EuCountry { get; set; }

        public CountryList(int id, string countryCode, string countryName)
        {
            ID = id;
            CompanyCountryCode = countryCode;
            CompanyCountryName = countryName;
            if (CountryDataBase.europe.Contains(countryName)) EuCountry= true;
            else EuCountry = false;
        }
    }
}
