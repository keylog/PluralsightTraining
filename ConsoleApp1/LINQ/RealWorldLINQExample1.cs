using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1.LINQ
{
    class RealWorldLINQExample1
    {
        public void ParseLoggingCSVFile()
        {
            // Example from Pluralsight More Effective LINQ lecture 4
            var myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var diagsFolder = Path.Combine(myDocs, "FileFullOfCrap", "test");
            var fileType = "*.csv";

            Directory.EnumerateFiles(diagsFolder, fileType)
                .SelectMany(file => File.ReadAllLines(file)
                    .Skip(1)
                    .Select(line => line.Split(','))
                    .Where(parts => parts.Length > 8))
                .Where(parts => Regex.IsMatch(parts[8], "Checking license for"))
                .Select(parts => new
                {
                    Date = DateTime.Parse(parts[0]),
                    License = Regex.Match(parts[8], @"\d+").Value,
                    FirstTime = Regex.Match(parts[9], @"True|False").Value,
                })
                .Where(x => x.License.Length >= 6);
        }
    }
}
