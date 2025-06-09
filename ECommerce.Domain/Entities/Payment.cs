using System;
using System.Collections.Generic;

namespace ECommerce.Persistence;

public partial class Payment
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int PaymentMethodId { get; set; }

    public string? TransactionId { get; set; }

    public decimal Amount { get; set; }

    public string? Status { get; set; }

    public string? GatewayResponse { get; set; }

    public DateTime? ProcessedAt { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual PaymentMethod PaymentMethod { get; set; } = null!;
}
