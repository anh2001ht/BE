using System;
using System.Collections.Generic;

namespace ECommerce.Persistence;

public partial class ProductVariant
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public string SKU { get; set; } = null!;

    public decimal? Price { get; set; }

    public decimal? ComparePrice { get; set; }

    public int? StockQuantity { get; set; }

    public decimal? Weight { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Product Product { get; set; } = null!;
}
