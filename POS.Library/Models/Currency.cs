using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Currency
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? NameKh { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreateDate { get; set; }

    public int CreateBy { get; set; }

    public int? Code { get; set; }

    public virtual ICollection<StockProductMove> StockProductMoves { get; set; } = new List<StockProductMove>();
}
