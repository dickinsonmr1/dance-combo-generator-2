using System.Collections.Generic;
using System.Linq;
using dance_combo_generator_2.DataStore;
using dance_combo_generator_2.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dance_combo_generator_2.Controllers
{
    [Route("api/[controller]")]
    public class GenerateController : Controller
    {
        // https://www.infoq.com/articles/Angular-Core-3/
        // https://dev.to/dileno/build-an-angular-8-app-with-rest-api-and-asp-net-core-2-2-part-2-46ap
        // https://docs.microsoft.com/en-us/aspnet/core/client-side/spa/angular?view=aspnetcore-3.1&tabs=visual-studio
        // https://localhost:44357/api/generate?numMoves=8&difficulty=3
        [HttpGet]
        public ActionResult Get(int numMoves, int difficulty)
        {
            //return "value";

            var dataStore = new CsvDataStore();
            var moves = dataStore.GenerateCombo(numMoves, difficulty);
            //model = new RandomModel { Moves = moves };

            return Ok(moves.ToList());
        }
    }
}
