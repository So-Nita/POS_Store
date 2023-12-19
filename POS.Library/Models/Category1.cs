using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Category1
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Image { get; set; }

    public int MenuId { get; set; }

    public int? ParentId { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? IsDeleted { get; set; }

    public int? Status { get; set; }
}
