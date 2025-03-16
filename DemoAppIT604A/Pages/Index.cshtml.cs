using DemoAppIT604A.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoAppIT604A.Pages
{
    public class IndexModel : PageModel
    {
        public string UserName { get; set; } = null!;
        //[BindProperty] //POST
        [BindProperty(SupportsGet = true)]
        public string Message { get; set; }


        [BindProperty(SupportsGet = true)]
        public int StudentId { get; set; } = 0;

        public List<Student> StudentList { get; set; } = new List<Student>()
        {
            new Student
            {
                Id = 1,
                Name = "Gabiana"
            },
            new Student
            {
                Id = 2,
                Name = "Trazo"
            },
            new Student
            {
                Id = 3,
                Name = "Uy"
            }
        };
        
        public void OnGet() // On Render    
        {
            //Select Student

            if(StudentId == 0)
            {
                UserName = "Juan Dela Cruz 2";
            }
            else
            {
                UserName = StudentList
                    .First(student => student.Id == StudentId)
                    .Name;
            }


            if (!string.IsNullOrEmpty(Message)) //kung naa
            {
                StudentList = StudentList
                    .Where(student => student.Name.ToLower().Contains(Message.ToLower()))
                    .ToList();
            }
        }
    }
}
