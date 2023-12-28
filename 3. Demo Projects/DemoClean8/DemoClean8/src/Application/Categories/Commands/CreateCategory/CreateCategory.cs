using DemoClean8.Application.Common.Interfaces;
using DemoClean8.Domain.Entities;

namespace DemoClean8.Application.Categories.Commands.CreateCategory;
public record CreateCategoryCommand : IRequest<int>
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
}

public class CreateCategoryHandler : IRequestHandler<CreateCategoryCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateCategoryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var entity = new Category()
        {
            Name = request.Name,
            Description = request.Description,
        };

        _context.Categories.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}
