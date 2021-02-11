using Assignment4_Restaurants.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4_Restaurants.Controllers
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
            return View();
        }

        [HttpGet("List")]
        public IActionResult Restaurants()
        {
            // create list object
            List<string> restaurantList = new List<string>();

            // format the data into a string
            foreach (Restaurants r in Models.Restaurants.GetList())
            {
                //Display message if FavDish is null
                string? favDish = r.FavDish ?? "It's all tasty";

                int? rank = r.Rank;
                restaurantList.Add($"#{r.Rank}: {r.Name}<br>Address: {r.Address}<br>Fav Dish: {favDish}<br>Phone: {r.Phone}<br>Website: {r.Website}");
            }

            return View(restaurantList);
        }

        [HttpGet]
        public IActionResult NewRestaurants()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewRestaurants(NewRestaurants appResponse)
        {
            //Validate no errors in the model
            if (ModelState.IsValid)
            {
                AllRestaurants.AddApplication(appResponse);
                return View("Confirmation", appResponse);
            }
            else
            {
                return View("NewRestaurants");
            }
        }

        public IActionResult Confirmation()
        {
            return View();
        }

        public IActionResult MySuggestions()
        {
            return View(AllRestaurants.FullRestList);
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
