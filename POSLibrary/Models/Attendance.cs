using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Attendance
{
    public ulong Id { get; set; }

    public ulong DriverId { get; set; }

    public DateOnly? AttendanceDate { get; set; }

    public string? AttendanceAddress { get; set; }

    public double AttendanceLong { get; set; }

    public double AttendanceLat { get; set; }

    public bool AttendanceStatus { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? Reason { get; set; }
}
