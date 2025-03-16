using Alcuino_MVC_Expense.Context;
using Alcuino_MVC_Expense.Models;
using Alcuino_MVC_Expense.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Alcuino_MVC_Expense.Controllers
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
            var expenses = _context.NaExpenses.Include(q=> q.User).ToList();

            ViewBag.Expenses = expenses;

            var vm = new IndexVM
            {
                NaExpenseList = expenses,
            };

            return View(vm);
        }

        public IActionResult CreateExpense()
        {
            return View();
        }

        public IActionResult CreateExpenseForm(NaExpense expense)
        {
            _context.NaExpenses.Add(expense);
            _context.SaveChanges();

            return RedirectToAction("Index");
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
