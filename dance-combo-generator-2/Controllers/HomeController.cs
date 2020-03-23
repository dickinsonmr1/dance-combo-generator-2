using System.Diagnostics;
using dance_combo_generator_2.DataStore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dance_combo_generator_2.Models;

namespace dance_combo_generator_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var dataStore = new CsvDataStore();
            var moves = dataStore.GetAllMoves();
            return View(new HomeModel { Moves = moves });
        }

        [HttpPost]
        public IActionResult Submit()
        {
            return Error();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}