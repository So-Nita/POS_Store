using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class PaymentMethod
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Image { get; set; }

    public string? Description { get; set; }

    public long Status { get; set; }

    public long IsDeleted { get; set; }
}
