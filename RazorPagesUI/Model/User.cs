using System.ComponentModel.DataAnnotations;

namespace RazorPagesUI.Model
{
    public class User
    {
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 5)]
        public string Name { get; set; }
        [EmailAddress]
        [StringLength(50, MinimumLength = 15)]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
