using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class CodePrefixOwner
{
    public int Id { get; set; }

    public int? CodePrefixId { get; set; }

    public int? ShopBranchDetailId { get; set; }

    public string? Format { get; set; }

    public int? MinValue { get; set; }

    public int? CurrentValue { get; set; }

    public int CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public bool? Status { get; set; }

    public int? ParentId { get; set; }

    public string? ChildFormat { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? Id1 { get; set; }
}
