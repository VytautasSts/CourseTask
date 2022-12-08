using CourseTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseTask.Repositories
{
    public class CompanyRepository
    {
        private List<CompanyList> companyList = new List<CompanyList>
        {
            new CompanyList(1,"FinnAir",1),
            new CompanyList(2,"German Airways",2),
            new CompanyList(3,"Japan Airlines",3),
            new CompanyList(4,"Luxair",4),
            new CompanyList(5,"ITA Airways",5),
            new CompanyList(6,"Vueling Airlines",6),
            new CompanyList(7,"British Airways",7)
        };
        public List<CompanyList> Retrieve()
        {
            return companyList;
        }
        public List<CompanyList> AircraftRetrieve(int id)
        {
            var filtered = new List<CompanyList>();
            foreach (var plane in companyList)
            {
                if (plane.ID == id) filtered.Add(plane);
            }
            return filtered;
        }
    }
}
