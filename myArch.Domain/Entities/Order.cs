using System;
using System.Collections.Generic;

namespace myArch.Infrastructure.Entities;

public partial class Order
{
    public int? Id { get; set; }

    public string? OrderName { get; set; }

    public decimal? Price { get; set; }

    public DateOnly? OrderDate { get; set; }

    public bool? IsActive { get; set; }
}
