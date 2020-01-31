using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LocalBusinessAPI.Models;

namespace LocalBusinessAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allRestaurants = Restaurant.GetRestaurants(EnvironmentVariables.ApiKey);
            return View(allRestaurants);
        }
    }
}
