using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesUI.Model;

namespace RazorPagesUI.Pages.Admin
{
    public class AddUserModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                return RedirectToPage("/Index", new { User.Name });
            }

            return Page();
        }
    }
}
