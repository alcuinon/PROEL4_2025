using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesUI.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		[BindProperty(SupportsGet = true)] //for post / get
		public int Id { get; set; }

		[BindProperty(SupportsGet = true)]
		public string Name { get; set; } = "404";

        public void OnGet() //on render
		{

		}

		public void OnPost() //host data, capture information
		{

		}
	}
}
