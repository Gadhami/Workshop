using DemoClean8.Application.Common.Interfaces;
using DemoClean8.Application.Common.Models;
using DemoClean8.Application.Common.Security;
using DemoClean8.Domain.Enums;

namespace DemoClean8.Application.Categories.Queries.GetCategories;
//[Authorize]
public record GetCategoriesQuery : IRequest<CategoriesVm>;

public class GetCategoriesHandler : IRequestHandler<GetCategoriesQuery, CategoriesVm>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetCategoriesHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<CategoriesVm> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
    {
        return new CategoriesVm
        {
            Categories = await _context.Categories
                                .AsNoTracking()
                                .ProjectTo<CategoryDto>(_mapper.ConfigurationProvider)
                                .OrderBy(category => category.Name)
                                .ToListAsync(cancellationToken)
        };
    }
}
