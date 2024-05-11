using Microsoft.AspNetCore.Mvc;
using Rick_And_Morty.Models;
using Rick_And_Morty.Services;

namespace Rick_And_Morty.Controllers
{
    public class EpisodesController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Episode> episodes = await ApiService.GetEpisodesAsync();
            ViewBag.Episodes = episodes;
            if( episodes != null)
            {
                ViewBag.error = true;
                ViewBag.errorMessage = "Error occured, please try again later";
            }
            return View();
        }
    }
}
