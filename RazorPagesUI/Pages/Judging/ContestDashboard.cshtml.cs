using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesUI.Database;
using RazorPagesUI.Model.ViewModel;

namespace RazorPagesUI.Pages.Judging
{
    public class ContestDashboardModel : PageModel
    {
        public ContestantVM ContestantVM { get; set; } = new ContestantVM();

        public void OnGet()
        {
            ContestantVM.Contestants = MyDatabase.Contestants;
            ContestantVM.ContestantScores = MyDatabase.ContestantScores;
        }
    }
}
