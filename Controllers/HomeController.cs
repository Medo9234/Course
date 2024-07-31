using Demo1.ActionFilters;
using Demo1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo1.Controllers
{
    [MyExceptionHandeller]
    public class HomeController : Controller
    {
       

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
      
        public IActionResult Index()
        {
            //int x = int.Parse("xyz");
            return View();
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