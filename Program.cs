using System;
using System.Diagnostics;
using System.Numerics;
using CourseTask.Repositories;
using CourseTask.Services;

namespace CodeAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            AircraftRepository aircraftRepository= new AircraftRepository();
            AircraftModelRepository aircraftModelRepository= new AircraftModelRepository();
            CountryRopository countryRepository= new CountryRopository();
            CompanyRepository companyRepository= new CompanyRepository();
            
            ReportGenerator report = new ReportGenerator(aircraftRepository,aircraftModelRepository,countryRepository,companyRepository);
            HTMLGenerator generator = new HTMLGenerator();
            var HTMLWithColor = generator.GenerateHTMLWithColor(report.GenerateReportAircraftInEurope());
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(HTMLWithColor);
        }
    }
}