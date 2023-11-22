using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class MaGazetteer
{
    public string? Id { get; set; }

    public string? Code { get; set; }

    public string? NameLatin { get; set; }

    public string? Reference { get; set; }

    public string? OfficialNote { get; set; }

    public string? Note { get; set; }

    public string? Type { get; set; }

    public string? Latlg { get; set; }

    public string? FullAddress { get; set; }

    public string? Status { get; set; }

    public string? NameKh { get; set; }

    public string? IsDeleted { get; set; }

    public string? CreateBy { get; set; }

    public string? CreateDate { get; set; }
}
