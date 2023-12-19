using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class SellOrderDetailProduct
{
    public int Id { get; set; }

    public int SizeProductsId { get; set; }

    public bool? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int SellOrderDetailId { get; set; }
}
