using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class PasswordReset
{
    public string Phone { get; set; } = null!;

    public string Token { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }
}
