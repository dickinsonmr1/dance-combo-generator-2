using System.Collections.Generic;
using System.Linq;
using dance_combo_generator_2.DataStore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace dance_combo_generator_2.Models
{
    public class RandomModel
    {
        [BindProperty] public int NumberOfMoves { get; set; } = 0;
        [BindProperty] public int MaxDifficultyLevel { get; set; } = 0;
        public List<SelectListItem> NumberOfMovesSelectListItems => Enumerable.Range(4, 12)
            .Select(n => new SelectListItem
            {
                Value = n.ToString(),
                Text = n.ToString()
            }).ToList();

        public List<SelectListItem> MaxDifficultySelectListItems => Enumerable.Range(1, 5)
            .Select(n => new SelectListItem
            {
                Value = n.ToString(),
                Text = n.ToString()
            }).ToList();

        public List<Move> Moves { get; set; }
    }
}