using Bogus;
using CsvHelper;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationUC23.Helpers;
using ValidationUC23.Models;

namespace ValidationUC23
{
    public class Actions
    {
        public static void SaveToFile<T>(string path, IEnumerable<T> list)
        {
            System.IO.File.WriteAllText(path, list.ToCsv());
        }
        public static void WriteToFile<T>(string filePath, IEnumerable<T> objectToWrite)
        {
            using (var writer = new StreamWriter(filePath))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(objectToWrite.ToCsv());
                }
            }
        }


    }
}
