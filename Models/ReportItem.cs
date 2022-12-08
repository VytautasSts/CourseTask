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
    public struct ReportItem
    {
        public int ID { get; set; }
        public string AircraftTailNumber { get; set; }
        public string ModelNumber { get; set; }
        public string ModelDescription { get; set; }
        public string OwnerCompanyName { get; set; }
        public string CompanyCountryCode { get; set; }
        public string CompanyCountryName { get; set; }

        public ReportItem(int id, string number, string model, string description,string company, string code, string country)
        {
            ID = id;
            AircraftTailNumber = number;
            ModelNumber = model;
            ModelDescription = description;
            OwnerCompanyName= company;
            CompanyCountryCode = code;
            CompanyCountryName = country;
        }
    }
}
