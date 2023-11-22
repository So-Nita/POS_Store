using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Payment
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public int? SaleId { get; set; }

    public int? CustomerId { get; set; }

    public string? TransactionId { get; set; }

    public string PaidBy { get; set; } = null!;

    public string? ChequeNo { get; set; }

    public string? CcNo { get; set; }

    public string? CcHolder { get; set; }

    public string? CcMonth { get; set; }

    public string? CcYear { get; set; }

    public string? CcType { get; set; }

    public decimal Amount { get; set; }

    public string? Currency { get; set; }

    public int CreatedBy { get; set; }

    public string? Attachment { get; set; }

    public string? Note { get; set; }

    public decimal? PosPaid { get; set; }

    public decimal? PosBalance { get; set; }

    public string? GcNo { get; set; }

    public string? Reference { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int StoreId { get; set; }
}
