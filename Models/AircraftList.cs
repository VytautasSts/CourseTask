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
    public struct AircraftList
    {
        public int ID { get; set; }
        public int ModelId { get; set; }
        public int CompanyId { get; set; }
        public string SerialNumber { get; set; }

        public AircraftList(int id, int model, int company, string serial)
        {
            ID = id;
            ModelId = model;
            CompanyId = company;
            SerialNumber = serial;
        }
    }
}
