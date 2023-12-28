namespace DemoClean8.Application.Categories.Queries.GetCategories;
public class CategoriesVm
{
    //public IReadOnlyCollection<LookupDto> PriorityLevels { get; init; } = Array.Empty<LookupDto>();

    public IReadOnlyCollection<CategoryDto> Categories { get; init; } = Array.Empty<CategoryDto>();
}
