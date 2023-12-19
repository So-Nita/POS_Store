using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class GroupUser
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public sbyte? Status { get; set; }

    public sbyte? IsDeleted { get; set; }

    public int CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? GroupType { get; set; }

    public int? Sequence { get; set; }
}
