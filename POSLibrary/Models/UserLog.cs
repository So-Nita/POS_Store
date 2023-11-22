using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class UserLog
{
    public ulong Id { get; set; }

    public int AdminUserId { get; set; }

    public string Username { get; set; } = null!;

    public int UserId { get; set; }

    public string UserType { get; set; } = null!;

    public string Action { get; set; } = null!;

    public string Detail { get; set; } = null!;

    public DateTime LastActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
