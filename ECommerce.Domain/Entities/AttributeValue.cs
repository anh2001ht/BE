using System;
using System.Collections.Generic;

namespace ECommerce.Persistence;

public partial class AttributeValue
{
    public int Id { get; set; }

    public int AttributeId { get; set; }

    public string Value { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual ProductAttribute Attribute { get; set; } = null!;
}
