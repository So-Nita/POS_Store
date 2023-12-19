using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class ConditionAndPrivacy
{
    public int Id { get; set; }

    public string? TitleEn { get; set; }

    public string? TitleKh { get; set; }

    public string? DescriptionEn { get; set; }

    public string? DescriptionKh { get; set; }

    public string Type { get; set; } = null!;

    public DateTime? CreateDate { get; set; }

    public bool? Status { get; set; }

    public bool? IsDeleted { get; set; }
}
