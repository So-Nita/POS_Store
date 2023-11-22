using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class CodePrefix
{
    public int Id { get; set; }

    public string? Prefix { get; set; }

    public string? NameEn { get; set; }

    public string? NameKh { get; set; }

    public int CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public bool? Status { get; set; }

    public bool? IsDeleted { get; set; }
}
