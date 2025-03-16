using System;
using System.Collections.Generic;

namespace Test.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public int? Age { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<News> News { get; set; } = new List<News>();
}
