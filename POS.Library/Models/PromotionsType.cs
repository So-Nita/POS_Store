using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class PromotionsType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public string? IsDeleted { get; set; }
}
