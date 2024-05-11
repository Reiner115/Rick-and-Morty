using Microsoft.AspNetCore.Mvc;
using Rick_And_Morty.Models;
using Rick_And_Morty.Services;

namespace Rick_And_Morty.Controllers
{
    public class CharactersController : Controller
    {
        public async Task<IActionResult> IndexAsync()
        {
            List<Character> characters = await ApiService.GetCharactersAsync();
            if (characters == null)
            {
                ViewBag.error = true;
                ViewBag.errorMessage = "Error occured, please try again later";
            }
            ViewBag.Characters = characters;
            return View();
        }
    }
}
