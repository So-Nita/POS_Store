using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Country
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public sbyte? Status { get; set; }

    public sbyte? IsDeleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
