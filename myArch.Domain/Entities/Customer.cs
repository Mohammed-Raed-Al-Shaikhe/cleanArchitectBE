using System;
using System.Collections.Generic;

namespace myArch.Infrastructure.Entities;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? FullName { get; set; }

    public string? PhoneNumber { get; set; }

    public DateOnly? OrderDate { get; set; }

    public bool? IsPremium { get; set; }
}
