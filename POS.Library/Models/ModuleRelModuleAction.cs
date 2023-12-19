using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class ModuleRelModuleAction
{
    public int Id { get; set; }

    public int ModuleId { get; set; }

    public int ModuleActionId { get; set; }

    public DateTime? CreateDate { get; set; }

    public sbyte? Status { get; set; }

    public sbyte? IsDeleted { get; set; }

    public int? CreateBy { get; set; }
}
