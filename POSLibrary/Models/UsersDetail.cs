using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class UsersDetail
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? IdCard { get; set; }

    public string? BirthDate { get; set; }

    public string? Lat { get; set; }

    public string? Lng { get; set; }

    public string? Gender { get; set; }

    public sbyte? Status { get; set; }

    public sbyte? IsDeleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? ShopId { get; set; }
}
