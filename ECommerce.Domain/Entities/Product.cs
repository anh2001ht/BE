using System;
using System.Collections.Generic;

namespace ECommerce.Persistence;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Slug { get; set; } = null!;

    public string? Description { get; set; }

    public string? ShortDescription { get; set; }

    public string SKU { get; set; } = null!;

    public int? BrandId { get; set; }

    public int CategoryId { get; set; }

    public decimal Price { get; set; }

    public decimal? ComparePrice { get; set; }

    public decimal? CostPrice { get; set; }

    public bool? TrackInventory { get; set; }

    public int? StockQuantity { get; set; }

    public int? LowStockThreshold { get; set; }

    public decimal? Weight { get; set; }

    public string? Dimensions { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsFeatured { get; set; }

    public string? MetaTitle { get; set; }

    public string? MetaDescription { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();

    public virtual ICollection<ProductReview> ProductReviews { get; set; } = new List<ProductReview>();

    public virtual ICollection<ProductVariant> ProductVariants { get; set; } = new List<ProductVariant>();

    public virtual ICollection<Wishlist> Wishlists { get; set; } = new List<Wishlist>();
}
