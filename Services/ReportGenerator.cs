using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using CodeAcademy;
using CourseTask.Models;
using CourseTask.Repositories;

namespace CourseTask.Services
{
    internal class ReportGenerator
    {
        AircraftRepository Aircrafts { get; set; }
        AircraftModelRepository Models { get; set; }
        CountryRopository Countries { get; set; }
        CompanyRepository Companies { get; set; }

        public ReportGenerator(AircraftRepository aircrafts, AircraftModelRepository models, CountryRopository countries, CompanyRepository companies)
        {
            Aircrafts = aircrafts;
            Models = models;
            Countries = countries;
            Companies = companies;

        }
        public List<ReportItem> GenerateReportAircraftInEurope()
        {
            var airplanes = Aircrafts.Retrieve();
            var countries = Countries.Retrieve();
            var models = Models.Retrieve();
            var companies = Companies.Retrieve();
            List<int> europeanAircrafts = new List<int>();
            foreach (var plane in airplanes)
            {
                var companyId = plane.CompanyId;
                var currentCompany = Companies.AircraftRetrieve(companyId);
                var currentCountry = Countries.AircraftRetrieve(currentCompany[0].OwnerCountryId);
                if (currentCountry[0].EuCountry) europeanAircrafts.Add(plane.ID);
                else continue;
            }
            List<ReportItem> ataskaita = new List<ReportItem>();
            var currentID = 0;
            for (int i = 0; i < europeanAircrafts.Count(); i++)
            {
                currentID = europeanAircrafts[i];
                var currentAircraft = Aircrafts.AircraftRetrieve(currentID);
                var currentModel = Models.AircraftRetrieve(currentAircraft[0].ModelId);
                var currentCompany = Companies.AircraftRetrieve(currentAircraft[0].CompanyId);
                var currentCountry = Countries.AircraftRetrieve(currentCompany[0].OwnerCountryId);
                ReportItem lektuvas = new ReportItem
                {
                    ID = currentAircraft[0].ID,
                    AircraftTailNumber = currentAircraft[0].SerialNumber,
                    ModelNumber = currentModel[0].ModelNumber,
                    ModelDescription = currentModel[0].ModelDescription,
                    OwnerCompanyName = currentCompany[0].OwnerCompanyName,
                    CompanyCountryCode = currentCountry[0].CompanyCountryCode,
                    CompanyCountryName = currentCountry[0].CompanyCountryName
                };
                ataskaita.Add(lektuvas);
            }
            return ataskaita;
        }
        public List<ReportItem> GenerateReportAircraftNotInEurope()
        {
            var airplanes = Aircrafts.Retrieve();
            var countries = Countries.Retrieve();
            var models = Models.Retrieve();
            var companies = Companies.Retrieve();
            List<int> notEuropeanAircrafts = new List<int>();
            foreach (var plane in airplanes)
            {
                var companyId = plane.CompanyId;
                var currentCompany = Companies.AircraftRetrieve(companyId);
                var currentCountry = Countries.AircraftRetrieve(currentCompany[0].OwnerCountryId);
                if (currentCountry[0].EuCountry) continue;
                else notEuropeanAircrafts.Add(plane.ID);
            }
            List<ReportItem> ataskaita = new List<ReportItem>();
            var currentID = 0;
            for (int i = 0; i < notEuropeanAircrafts.Count(); i++)
            {
                currentID = notEuropeanAircrafts[i];
                var currentAircraft = Aircrafts.AircraftRetrieve(currentID);
                var currentModel = Models.AircraftRetrieve(currentAircraft[0].ModelId);
                var currentCompany = Companies.AircraftRetrieve(currentAircraft[0].CompanyId);
                var currentCountry = Countries.AircraftRetrieve(currentCompany[0].OwnerCountryId);
                ReportItem lektuvas = new ReportItem
                {
                    ID = currentAircraft[0].ID,
                    AircraftTailNumber = currentAircraft[0].SerialNumber,
                    ModelNumber = currentModel[0].ModelNumber,
                    ModelDescription = currentModel[0].ModelDescription,
                    OwnerCompanyName = currentCompany[0].OwnerCompanyName,
                    CompanyCountryCode = currentCountry[0].CompanyCountryCode,
                    CompanyCountryName = currentCountry[0].CompanyCountryName
                };
                ataskaita.Add(lektuvas);
            }
            return ataskaita;
        }
    }
}
