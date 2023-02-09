using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseTask.Models;

namespace CourseTask.Repositories
{
    public class AircraftModelRepository
    {
        private List<AircraftModelList> aircraftModelList = new List<AircraftModelList>
        {
            new AircraftModelList(1,"JU-52","Junkers Ju 52"),
            new AircraftModelList(2,"S-76","Sikorsky S-76"),
            new AircraftModelList(3,"A320","Airbus A320"),
            new AircraftModelList(4,"747","Boeing 747-446D"),
            new AircraftModelList(5,"DC-10-40D","Douglas DC-10-40D"),
            new AircraftModelList(6,"Fokker-50","Fokker 50")
        };
        
        public List<AircraftModelList> Retrieve()
        {
            return aircraftModelList;
        }
        public List<AircraftModelList> AircraftRetrieve(int id)
        {
            var filtered = new List<AircraftModelList>();
            foreach (var plane in aircraftModelList)
            {
                if (plane.ID == id) filtered.Add(plane);
            }
            return filtered;
        }
    }
}
