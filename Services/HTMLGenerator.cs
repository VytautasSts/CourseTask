using CourseTask.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace CourseTask.Services
{
    public class HTMLGenerator
    {
        public string GenerateHTMLWithColor(List<ReportItem> ataskaita)
        {

            List<string> lines = new List<string>(){
                "<!DOCTYPE html>",
                "<head>",
                "<title>Report</title>",
                "<style>",
                "<table {",
                "width:100%}",
                "table, th, td {",
                "border: 1px solid black;",
                "border - collapse: collapse;}",
                ".lightblue{",
                "background-color: rgb(0,162,232);}",
                ".lightred{",
                "background-color: rgb(255,113,113);}",
                "</style>",
                "</head>",
                "<body>",
                "<table>",
                "<tr>",
                "<th>Aircraft ID</th>",
                "<th>Aircraft Tail Number</th>",
                "<th>Model Number</th>",
                "<th>Model Description</th>",
                "<th>Owner Company Name</th>",
                "<th>Owner Country Code</th>",
                "<th>Owner Country Name</th>",
                "</tr>",
            };

            foreach (var entry in ataskaita)
            {
                lines.Add("<tr>");
                foreach (var prop in entry.GetType().GetProperties())
                {
                    if (CountryDataBase.europeanUnion.Contains(entry.CompanyCountryName))
                    {
                        lines.Add("<td class='lightblue'>" + prop.GetValue(entry, null).ToString() + "</td>");
                    }
                    else
                    {
                        lines.Add("<td class='lightred'>" + prop.GetValue(entry, null).ToString() + "</td>");
                    }
                }
                lines.Add("</tr>");
            }

            lines.Add("</body>");
            lines.Add("</html>");

            File.WriteAllLines(@"C:\Users\vytas\source\repos\CodeAcademy\CourseTask\report.html", lines);
            return string.Join("\n", lines);
        }
    }
}
