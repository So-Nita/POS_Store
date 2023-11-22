using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Menu
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public sbyte? Status { get; set; }

    public sbyte? IsDeleted { get; set; }

    public string Image { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? RouteHandle { get; set; }

    public int? DivisionId { get; set; }

    public int? MenuCode { get; set; }
}
