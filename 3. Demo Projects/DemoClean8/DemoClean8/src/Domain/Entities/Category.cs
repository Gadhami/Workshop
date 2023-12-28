namespace DemoClean8.Domain.Entities;
public class Category : BaseAuditableEntity
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public IList<Product> Products { get; private set; } = new List<Product>();
}
