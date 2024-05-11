using Microsoft.AspNetCore.Mvc;
using Rick_And_Morty.Models;
using System.Diagnostics;
using Newtonsoft.Json;
using Rick_And_Morty.Services;


namespace Rick_And_Morty.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            List<Character> characters = await ApiService.GetCharactersAsync();
            ViewBag.Characters = characters;

            List<Episode> episodes = await ApiService.GetEpisodesAsync();
            ViewBag.Episodes = episodes;


            if (characters == null || episodes == null)
            {
                ViewBag.error = true;
                ViewBag.errorMessage = "Error occured, please try again later";
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




        
    }
}
