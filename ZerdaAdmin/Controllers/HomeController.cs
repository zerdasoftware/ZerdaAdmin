using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ZerdaAdmin.Models;

namespace ZerdaAdmin.Controllers
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
        public IActionResult Buttons()
        {
            return View();
        }
        public IActionResult Cards()
        {
            return View();
        }
        public IActionResult Colors()
        {
            return View();
        }
        public IActionResult Borders()
        {
            return View();
        }
        public IActionResult Animations()
        {
            return View();
        }
        public IActionResult Other()
        {
            return View();
        }
        public IActionResult ErrorPage()
        {
            return View();
        }
        public IActionResult BlankPage()
        {
            return View();
        }
        public IActionResult Charts()
        {
            return View();
        }
        public IActionResult Tables()
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
