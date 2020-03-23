using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dance_combo_generator_2.DataStore
{
    public enum MoveFamily
    {
        Basic,
        Lollie,
        OutAndIn,
        TossOut,
        PopTurn,
        AdLib,
        Progressive,
        Style,
        PrefabCombo,
        Connection,
        Redirect,
        Turn,
        FancyMove,
        Pivot,
        Swivel,
        Stop,
        FreeSpin
    }

    public enum MoveType
    {
        Move,
        Modifier,
        Accent
    }

    public class Move
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MoveFamily? MoveFamily { get; set; }
        public MoveType? MoveType { get; set; }
        public int? NumberOfBeats { get; set; }
        public int? DifficultyLevel { get; set; }
    }
}