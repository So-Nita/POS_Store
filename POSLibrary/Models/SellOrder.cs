using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class SellOrder
{
    public ulong Id { get; set; }

    public long? CustomerAddressId { get; set; }

    public int? CustomerId { get; set; }

    public long? ShopId { get; set; }

    public string? DeliveryStatus { get; set; }

    public decimal? DeliveryPrice { get; set; }

    public string? PaymentStatus { get; set; }

    public string? PromoteCode { get; set; }

    public string? Status { get; set; }

    public string? Other { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public double? TotalPrice { get; set; }

    public string? CustomerLat { get; set; }

    public string? CustomerLng { get; set; }

    public string? Address { get; set; }

    public decimal? ProductsPrice { get; set; }

    public string? ShopLatlong { get; set; }

    public int? UsersId { get; set; }

    public string? CustomerName { get; set; }

    public decimal? GrandTotal { get; set; }

    public int? SellOrderDetailId { get; set; }

    public sbyte? IsDeleted { get; set; }

    public decimal? TotalItem { get; set; }

    public string? OrderStatus { get; set; }

    public string? Message { get; set; }

    public string? SaleType { get; set; }

    public int? MinutePending { get; set; }

    public long? PaymentMethodId { get; set; }

    public string? DeliveryInstruction { get; set; }

    public double? Tax { get; set; }

    public int? SellerBy { get; set; }

    public int? QuoteId { get; set; }

    public double? Received { get; set; }

    public double? Changed { get; set; }

    public string? PaymentOnline { get; set; }
}
