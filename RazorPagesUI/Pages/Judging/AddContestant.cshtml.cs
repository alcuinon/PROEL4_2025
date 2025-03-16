using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesUI.Database;
using RazorPagesUI.Model;

namespace RazorPagesUI.Pages.Judging
{
    public class AddContestantModel : PageModel
    {
        [BindProperty]
        public Contestant Contestant { get; set; } = new Contestant();

        public void OnGet()
        {
            Contestant.Id = Guid.NewGuid().ToString();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            MyDatabase.Contestants.Add(Contestant);

            return RedirectToPage("/Judging/ContestDashboard");
        }
    }
}
