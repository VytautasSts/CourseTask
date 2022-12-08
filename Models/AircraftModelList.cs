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
    public struct AircraftModelList
    {
        public int ID { get; set; }
        public string ModelNumber { get; set; }
        public string ModelDescription { get; set; }
        public AircraftModelList(int id, string model, string description)
        {
            ID = id;
            ModelNumber = model;
            ModelDescription = description;
        }
    }
}
