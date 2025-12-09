using System;
using System.Collections.Generic;

namespace myArch.Infrastructure.Entities;

public partial class Table1
{
    public decimal Id { get; set; }

    public string Name { get; set; } = null!;

    public string Age { get; set; } = null!;

    public string? Address { get; set; }
}
