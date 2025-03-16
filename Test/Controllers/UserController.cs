using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test.Context;
using Test.Models;

namespace Test.Controllers
{
    public class UserController : Controller
    {
        private readonly MyDBContext _context;

        public UserController(MyDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //_context.Users.Add(new User
            //{
            //    Firstname = "Test",
            //    Lastname = "Test",
            //    Email = "Test@gmail.com",
            //});

            //var newUser = new User
            //{
            //    Firstname = "Test",
            //    Lastname = "Test",
            //    Email = "Test@gmail.com",
            //};

            //_context.Users.Add(newUser);
            //_context.SaveChanges();


            //var newUsers = new List<User> 
            //{ 
            //    new User
            //    {
            //        Firstname = "Test1",
            //        Lastname = "Test1",
            //        Email = "Test1@gmail.com"
            //    },
            //    new User
            //    {
            //        Firstname = "Test2",
            //        Lastname = "Test2",
            //        Email = "Test2@gmail.com"
            //    }
            //};

            //_context.Users.AddRange(newUsers);
            //_context.SaveChanges();


            var user = _context.Users.FirstOrDefault(u=> u.Id == 1003);
            //if exist then proceed
            if(user is not null)
            {
                user.Email = "Test3@gmail.com"; //new value
                _context.Users.Update(user);
                //execute your changes to database
                _context.SaveChanges();
            }

            var user1 = _context.Users.FirstOrDefault(user => user.Id == 1003);
            if (user1 is not null)
            {
                _context.Remove(user1);
                //execute your changes to database
                _context.SaveChanges();
            }


            //if not found then test is null and test is a nullable datatype
            var test = _context.Users.FirstOrDefault(user => user.Id == 1);
            //if not found then this code is error
            var test2 = _context.Users.First(user => user.Id == 1);
            //if not found then test is null and test3 is a nullable datatype
            var test3 = _context.Users.SingleOrDefault(user => user.Id == 1);
            //if not found then this code is error
            var test4 = _context.Users.Single(user => user.Id == 1);

            return View(test);
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
