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
    public struct CompanyList
    {
        public int ID { get; set; }
        public string OwnerCompanyName { get; set; }
        public int OwnerCountryId { get; set; }

        public CompanyList(int id, string companyName, int countryId)
        {
            ID = id;
            OwnerCompanyName = companyName;
            OwnerCountryId = countryId;
        }
    }
}
