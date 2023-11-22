using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Advertisement
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? UserId { get; set; }

    public string? ImgPath { get; set; }

    public string? Link { get; set; }

    public bool? Status { get; set; }

    public bool? IsDeleted { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public int? Layout { get; set; }
}
