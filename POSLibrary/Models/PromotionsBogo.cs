using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class PromotionsBogo
{
    public int Id { get; set; }

    public int? BuyValue { get; set; }

    public int? GetValue { get; set; }

    public sbyte? Status { get; set; }

    public sbyte? IsDeleted { get; set; }

    public int PromotionsId { get; set; }
}
