namespace DemoClean8.Domain.Entities;
public class Product : BaseAuditableEntity
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = string.Empty;
    public double Price { get; set; } =  0.0;
}
