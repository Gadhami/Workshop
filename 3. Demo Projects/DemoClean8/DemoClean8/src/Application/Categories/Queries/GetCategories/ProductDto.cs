using DemoClean8.Domain.Entities;

namespace DemoClean8.Application.Categories.Queries.GetCategories;
public class ProductDto
{
    public int Id { get; init; }

    public int CategoryId { get; init; }

    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;

    public bool Done { get; init; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Product, ProductDto>();
                //.ForMember(d => d.Priority,
                //opt => opt.MapFrom(s => (int)s.Priority));
        }
    }
}
