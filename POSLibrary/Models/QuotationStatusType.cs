using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class QuotationStatusType
{
    public int Id { get; set; }

    public string NameEn { get; set; } = null!;

    public string? NameKh { get; set; }

    public sbyte Status { get; set; }

    public sbyte IsDeleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? Color { get; set; }

    public int? Sequence { get; set; }
}
