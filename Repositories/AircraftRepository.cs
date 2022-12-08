using CourseTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CourseTask.Repositories
{
    public class AircraftRepository
    {
        private List<AircraftList> aircraftList = new List<AircraftList>
        {
            new AircraftList(1,1,1,"OH-ALL"),
            new AircraftList(2,2,1,"OH-HCI"),
            new AircraftList(3,3,2,"D-AXLA"),
            new AircraftList(4,4,3,"JA8904"),
            new AircraftList(5,5,3,"JA8546"),
            new AircraftList(6,6,4,"LX-LGB"),
            new AircraftList(7,1,5,"I-TIGI"),
            new AircraftList(8,2,6,"EC-DDU"),
            new AircraftList(9,3,7,"G-VWOW"),
            new AircraftList(10,4,7,"G-VDW")
        };
        public List<AircraftList> Retrieve()
        {
            return aircraftList;
        }
        public List<AircraftList> AircraftRetrieve(int id)
        {
            var filtered = new List<AircraftList>();
            foreach (var plane in aircraftList)
            {
                if (plane.ID == id) filtered.Add(plane);
            }
            return filtered;
        }
        
    }
}
