using DemoClean8.Domain.Entities;

namespace DemoClean8.Application.Categories.Queries.GetCategories;
public class CategoryDto
{
    public CategoryDto()
    {
        Products = Array.Empty<ProductDto>();
    }

    public int Id { get; init; }

    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;

    public IReadOnlyCollection<ProductDto> Products { get; init; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Category, CategoryDto>();
        }
    }
}
