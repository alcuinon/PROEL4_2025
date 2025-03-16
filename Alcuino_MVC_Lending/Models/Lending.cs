using System;
using System.Collections.Generic;

namespace Alcuino_MVC_Lending.Models;

public partial class Lending
{
    public int Id { get; set; }

    public string Purpose { get; set; } = null!;

    public int PersonId { get; set; }

    public decimal Amount { get; set; }

    public DateOnly DueDate { get; set; }

    public virtual Person Person { get; set; } = null!;
}
