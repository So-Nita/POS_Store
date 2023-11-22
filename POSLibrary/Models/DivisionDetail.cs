using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class DivisionDetail
{
    public int Id { get; set; }

    public int? DivisionId { get; set; }

    public DateTime CreateDate { get; set; }

    public int CreateBy { get; set; }

    public bool? Status { get; set; }

    public bool? IsDeleted { get; set; }
}
