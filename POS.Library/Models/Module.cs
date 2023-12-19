using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Module
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? ParentId { get; set; }

    public bool? Status { get; set; }

    public string? Link { get; set; }

    public string? Icon { get; set; }

    public int? Sequence { get; set; }

    public sbyte? IsShow { get; set; }

    public string Code { get; set; } = null!;

    public int Icode { get; set; }

    public sbyte? IsDeleted { get; set; }

    public int CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string Type { get; set; } = null!;
}
