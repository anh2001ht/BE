using System;
using System.Collections.Generic;

namespace ECommerce.Persistence;

public partial class Coupon
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Type { get; set; } = null!;

    public decimal Value { get; set; }

    public decimal? MinimumAmount { get; set; }

    public decimal? MaximumDiscount { get; set; }

    public int? UsageLimit { get; set; }

    public int? UsedCount { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidUntil { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
