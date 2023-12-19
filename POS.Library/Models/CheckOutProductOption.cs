﻿using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class CheckOutProductOption
{
    public int Id { get; set; }

    public long? CheckOutDetailId { get; set; }

    public long? SizeProductId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public sbyte? Status { get; set; }

    public sbyte? IsDeleted { get; set; }
}
