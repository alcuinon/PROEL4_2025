using System;
using System.Collections.Generic;

namespace Alcuino_MVC_Expense.Models;

public partial class NaUser
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<NaExpense> NaExpenses { get; set; } = new List<NaExpense>();
}
