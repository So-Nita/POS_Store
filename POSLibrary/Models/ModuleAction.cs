using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class ModuleAction
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public sbyte? Status { get; set; }

    public sbyte? IsDeleted { get; set; }

    public int? CreateBy { get; set; }

    public string? Type { get; set; }

    public int? Sequence { get; set; }
}
