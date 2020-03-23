using dance_combo_generator_2.DataStore;
using dance_combo_generator_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dance_combo_generator_2.Controllers
{
    public class RandomController : Controller
    {
        private readonly ILogger<RandomController> _logger;

        public RandomController(ILogger<RandomController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var dataStore = new CsvDataStore();
            var moves = dataStore.GetAllMoves();
            var model = new RandomModel { Moves = moves };
            
            return View(model);
        }

        //public IActionResult Index(RandomModel model)
        //{
        //    return View(model);
        //}

        [HttpPost]
        public IActionResult Submit(RandomModel model)
        {
        //    var dataStore = new CsvDataStore();
        //    var moves = dataStore.GenerateCombo();
        //    model = new RandomModel { Moves = moves };

            return RedirectToAction("Index", model);
        }
    }
}
