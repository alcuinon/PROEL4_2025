using System;
using System.Collections.Generic;

namespace Alcuino_MVC_Lending.Models;

public partial class Person
{
    public int Id { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public int Age { get; set; }

    public string? Address { get; set; }

    public string Email { get; set; } = null!;

    public virtual ICollection<Lending> Lendings { get; set; } = new List<Lending>();
}
