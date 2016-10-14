using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amba.System.Extensions.Csv
{
    public static class CsvExtensions
    {
        public static string GetCsvHeader(this object obj)
        {
            var csvLine = new StringBuilder();
            foreach (var property in obj.GetType().GetProperties())
            {
                var value = property.Name;
                csvLine.Append(value);
                csvLine.Append(";");
            }
            return csvLine.ToString().Trim(';');
        }

        public static string ToCsv(this object obj)
        {
            var csvLine = new StringBuilder();
            foreach (var property in obj.GetType().GetProperties())
            {
                var value = property.GetValue(obj, null);
                if (value == null)
                    value = "";
                csvLine.Append(value);
                csvLine.Append(";");
            }
            return csvLine.ToString().Trim(';');
        }
    }
}
