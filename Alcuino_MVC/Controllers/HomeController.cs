using Alcuino_MVC.Context;
using Alcuino_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Alcuino_MVC.Controllers
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
            //add 1 user
            //_context.NaUsers.Add(new NaUser
            //{
            //    Email = "alcuinon@gmail.com",
            //    Username = "alcuinon",
            //    Password = "password"
            //});


            //add 2 users
            //_context.NaUsers.AddRange(
            //    new NaUser
            //    {
            //        Email = "alcuinon2@gmail.com",
            //        Username = "alcuinon2",
            //        Password = "password2"
            //    },
            //    new NaUser
            //    {
            //        Email = "alcuinon3@gmail.com",
            //        Username = "alcuinon3",
            //        Password = "password3"
            //    }
            //    );

            //update 1 user

            //var user = _context.NaUsers.FirstOrDefault(user => user.Id == 1);

            //if (user != null) 
            //{
            //    user.Email = "test@gmail.com";
            //    _context.NaUsers.Update(user);
            //}

            //remove 1 user

            var user = _context.NaUsers.FirstOrDefault(user => user.Id == 1);

            if (user != null) {
                _context.Remove(user);
            }

            _context.SaveChanges();

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
