using Alcuino_MVC.Context;
using Alcuino_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Alcuino_MVC.Controllers
{

    //1. What's the use of Controller?
    public class StudentController : Controller
    {

        //2 Explain the Line 14
        private readonly ILogger<StudentController> _logger;
        private readonly MyDBContext _context;

        //3.1 What is this "public StudentController()" called?
        //3.2 How important is this?
        //3.3 Where can we get the instance of the injected services/class/middleware?
        public StudentController(ILogger<StudentController> logger, MyDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        //4 How can we access/test this method?
        public IActionResult Index()
        {

            //5.1 Explain this Line 30-35
            _context.NaStudents.Add(new NaStudent
            {
                Name = "Nino Alcuino",
                Grade = 78.5m,
                Age = 27
            });

            //5.2 Why do we need this one?
            _context.SaveChanges();

            //6.1 What's the other alternative way aside from FirstOrDefault() to get 1 record?
            var student = _context.NaStudents.FirstOrDefault(student => student.Id == 1001);

            //6.2 What is the reason why we need to check the student is not null?
            if(student != null)
            {
                student.Grade = 86.5m;
                _context.NaStudents.Update(student);

                _context.SaveChanges();
            }

            //7.1 Why do we need to use ToList() everytime we get the records?
            //7.2 What happens if we dont use ToList()?
            //7.3 Why getting a record dont need to use _context.SaveChanges() ?
            var students1 = _context.NaStudents.ToList();

            //8 Explain the Line 58-61
            return View(new StudentIndexVM
            {
                Students = students1
            });
        }
    }
}
