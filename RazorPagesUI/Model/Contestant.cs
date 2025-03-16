using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RazorPagesUI.Model
{
    public class Contestant
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
