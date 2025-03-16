using Alcuino_MVC_Lending.Context;
using Alcuino_MVC_Lending.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Alcuino_MVC_Lending.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDBContext _context;

        public HomeController(ILogger<HomeController> logger, MyDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var lendings = _context.Lendings.Include(q=> q.Person).ToList();

            var vm = new IndexVM
            {
                Lendings = lendings
            };
            return View(vm);
        }

        public IActionResult UpdateLendingPage(int id)
        {
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
