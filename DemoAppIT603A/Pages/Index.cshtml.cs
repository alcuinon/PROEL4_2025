using Alcuino.FakeDataGenerator;
using DemoAppIT603A.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoAppIT603A.Pages;

//MVC
//Model(Raw Model) <---> Controller(Luto Model) <---> View
//MVVM
//Model (logic), <---> View


public class IndexModel : PageModel
{
    //[BindProperty] //post method
    [BindProperty(SupportsGet = true)] //for post and get method
    public string Title { get; set; }

    //ATTRIBUTES 
    //ADDITIONAL POWER
    [BindProperty(SupportsGet = true)] 
    public int? NewsId { get; set; }
    public News News { get; set; }

    // before ma visit si View
    public void OnGet() //On Render
    {
        FakeDataGenerator.Config = new Config
        {
            Seed = 123,
            Locale = "ko",
            MoneySymbol = "P"
        };

        List<News> NewsList = new List<News>().GenerateFakeData(100).ToList();
        List<User> users = new List<User>();



        News = NewsList.FirstOrDefault(news=> news.Id == NewsId) ?? new News();
    }

    //maoy mo catch sa
    //Form Submission
    public void OnPost() 
    {
        
    }
}
