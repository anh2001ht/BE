using System;
using System.Collections.Generic;

namespace ECommerce.Persistence;

public partial class Order
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string OrderNumber { get; set; } = null!;

    public string? Status { get; set; }

    public string? PaymentStatus { get; set; }

    public decimal Subtotal { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? ShippingAmount { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal TotalAmount { get; set; }

    public string ShippingAddressLine1 { get; set; } = null!;

    public string? ShippingAddressLine2 { get; set; }

    public string ShippingCity { get; set; } = null!;

    public string? ShippingState { get; set; }

    public string? ShippingPostalCode { get; set; }

    public string ShippingCountry { get; set; } = null!;

    public string? ShippingPhone { get; set; }

    public string BillingAddressLine1 { get; set; } = null!;

    public string? BillingAddressLine2 { get; set; }

    public string BillingCity { get; set; } = null!;

    public string? BillingState { get; set; }

    public string? BillingPostalCode { get; set; }

    public string BillingCountry { get; set; } = null!;

    public string? BillingPhone { get; set; }

    public string? Notes { get; set; }

    public DateTime? ShippedAt { get; set; }

    public DateTime? DeliveredAt { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<ProductReview> ProductReviews { get; set; } = new List<ProductReview>();

    public virtual User? User { get; set; }
}
