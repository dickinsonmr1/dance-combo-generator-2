using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;

namespace dance_combo_generator_2.DataStore
{
    public class CsvDataStore : IDataStore
    {
        //private List<Move> allMoves;
        public List<Move> GetAllMoves()
        {
            using (var reader = new StreamReader("DataStore\\Balboa moves - Sheet1.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                // TODO: doesn't work yet
                return csv.GetRecords<Move>().ToList();
            }
        }
    }
}