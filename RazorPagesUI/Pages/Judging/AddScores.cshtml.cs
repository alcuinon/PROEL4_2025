using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesUI.Database;
using RazorPagesUI.Model;

namespace RazorPagesUI.Pages.Judging
{
    public class AddScoresModel : PageModel
    {
        public List<Contestant> Contestants { get; set; }

        [BindProperty]
        public List<ContestantScore> Scores { get; set; } = new List<ContestantScore>();

        public void OnGet()
        {
            Contestants = MyDatabase.Contestants;

            foreach (var contestant in Contestants)
            {
                Scores.Add(new ContestantScore());
            }
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("/Junding/ContestDashboard");
        }
    }
}
