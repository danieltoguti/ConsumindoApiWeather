using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using API_AEVO.Models;
using API_AEVO.API;
using API_AEVO.Data;

namespace API_AEVO.Controllers
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

        public IActionResult Current()
        {
            return View();
        }

        public IActionResult Autocomplete()
        {
            return View();
        }

        public IActionResult Forescat()
        {
            return View();
        }

       

      



    }
}
