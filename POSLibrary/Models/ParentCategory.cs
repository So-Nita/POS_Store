using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class ParentCategory
{
    public int Id { get; set; }

    public int MenuId { get; set; }

    public string? Name { get; set; }

    public string? Image { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public sbyte? IsDeleted { get; set; }

    public sbyte? Status { get; set; }

    public string? RouteHandle { get; set; }
}
