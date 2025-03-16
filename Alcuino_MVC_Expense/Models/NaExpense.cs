using System;
using System.Collections.Generic;

namespace Alcuino_MVC_Expense.Models;

public partial class NaExpense
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Expense { get; set; }

    public int UserId { get; set; }

    public virtual NaUser User { get; set; } = null!;
}
