using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Measurement
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? NameAbbr { get; set; }

    public string? CreateBy { get; set; }

    public string? NameKh { get; set; }

    public string? Description { get; set; }

    public sbyte? Status { get; set; }

    public sbyte? IsDeleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? Types { get; set; }
}
