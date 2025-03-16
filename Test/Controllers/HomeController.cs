using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Test.Context;
using Test.Models;

namespace Test.Controllers
{
    //Home
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDBContext _context;

        public HomeController(ILogger<HomeController> logger, MyDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult SomeMethod()
        {
            var users = _context.Users.ToList();

            return View();
        }




        //Home/Index
        public IActionResult Index()
        {
            return View();
        }

        //Home/Privacy
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
