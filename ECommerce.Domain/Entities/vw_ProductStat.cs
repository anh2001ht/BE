using System;
using System.Collections.Generic;

namespace ECommerce.Persistence;

public partial class vw_ProductStat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string SKU { get; set; } = null!;

    public decimal Price { get; set; }

    public int? StockQuantity { get; set; }

    public string? CategoryName { get; set; }

    public string? BrandName { get; set; }

    public double AverageRating { get; set; }

    public int? ReviewCount { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsFeatured { get; set; }
}
