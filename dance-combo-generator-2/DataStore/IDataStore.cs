using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dance_combo_generator_2.DataStore
{
    public interface IDataStore
    {
        List<Move> GetAllMoves();
    }
}