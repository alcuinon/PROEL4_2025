using System;
using System.Collections.Generic;

namespace Alcuino_MVC.Models;

public partial class NaStudent
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public decimal Grade { get; set; }
}
