using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseTask.Models;

namespace CourseTask.Repositories
{
    public class CountryRopository
    {
        private List<CountryList> countryList = new List<CountryList>
        {
            new CountryList(1,"FI","Finland"),
            new CountryList(2,"DE","Germany"),
            new CountryList(3,"JP", "Japan"),
            new CountryList(4,"LU","Luxembourg"),
            new CountryList(5,"IT","Italy"),
            new CountryList(6,"ES","Spain"),
            new CountryList(7,"GB","United Kingdom")
        };
        public List<CountryList> Retrieve()
        {
            return countryList;
        }
        public List<CountryList> AircraftRetrieve(int id)
        {
            var filtered = new List<CountryList>();
            foreach (var plane in countryList)
            {
                if (plane.ID == id) filtered.Add(plane);
            }
            return filtered;
        }
    }
}
