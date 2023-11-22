using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class AdvertisementLayout
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool? Status { get; set; }

    public bool? IsDeleted { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public int? Hiegh { get; set; }

    public int? Width { get; set; }
}
