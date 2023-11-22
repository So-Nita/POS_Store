using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class AuditTable
{
    public int Id { get; set; }

    public string? TableName { get; set; }

    public int? RowId { get; set; }

    public int CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public bool? Status { get; set; }

    public string? Tyle { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public bool? IsDeleted { get; set; }
}
