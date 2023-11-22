using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class NotificationSeen
{
    public int Id { get; set; }

    public int? SeenBy { get; set; }

    public int? TableId { get; set; }

    public string? TableName { get; set; }

    public DateTime? SeenDate { get; set; }

    public bool? Status { get; set; }

    public string? SeenType { get; set; }

    public string? Data { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? RequestStatus { get; set; }
}
