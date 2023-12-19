using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class ModuleAccess
{
    public int Id { get; set; }

    public int MaModuleId { get; set; }

    public int? MaGroupId { get; set; }

    public sbyte? Status { get; set; }

    public int? MaUserId { get; set; }

    public sbyte? IsDeleted { get; set; }

    public int CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public int ModuleCheck { get; set; }
}
