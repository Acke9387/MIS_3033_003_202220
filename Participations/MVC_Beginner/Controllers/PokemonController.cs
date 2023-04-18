using Microsoft.AspNetCore.Mvc;
using MVC_Beginner.Models;
using Newtonsoft.Json;

namespace MVC_Beginner.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Index()
        {
            PokemonAPI api;
            using (var client = new HttpClient())
            {
                string url = "https://pokeapi.co/api/v2/pokemon?offset=0&limit=1300";
                string json = client.GetStringAsync(url).Result;

                 api = JsonConvert.DeserializeObject<PokemonAPI>(json);  

            }

            return View(api.results);
        }

        public IActionResult Info(string id)
        {
            PokemonDetails api;
            using (var client = new HttpClient())
            {
                string url = $"https://pokeapi.co/api/v2/pokemon/{id}";
                string json = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<PokemonDetails>(json);

            }

            return View(api);
        }
    }
}
