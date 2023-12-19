using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class DriverDetail
{
    public int Id { get; set; }

    public int UsersId { get; set; }

    public string? VehicleType { get; set; }

    public string? VehicleModel { get; set; }

    public string? LicenseNumber { get; set; }

    public DateTime? LicenseIssued { get; set; }

    public DateTime? LicenseExpire { get; set; }

    public DateTime? CreatedAt { get; set; }

    public bool? Status { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Gender { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? AddressCode { get; set; }

    public string? AddressFull { get; set; }

    public string? IdCard { get; set; }

    public DateTime? JoinDate { get; set; }

    public string? NameEn { get; set; }

    public string? NameKh { get; set; }

    public int? ShopId { get; set; }
}
