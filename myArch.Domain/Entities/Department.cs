using System;
using System.Collections.Generic;

namespace myArch.Infrastructure.Entities;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public string? DepartmentEmail { get; set; }
}
