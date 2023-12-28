using DemoClean8.Application.Common.Interfaces;

namespace DemoClean8.Application.Categories.Commands.UpdateCategory;
public record UpdateCategoryCommand : IRequest
{
    public int Id { get; init; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
}

public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand>
{
    private readonly IApplicationDbContext _context;

    public UpdateCategoryCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = await _context.Categories
            .FindAsync(new object[] { request.Id }, cancellationToken);

        Guard.Against.NotFound(request.Id, category);

        category.Name = request.Name;
        category.Description = request.Description;

        await _context.SaveChangesAsync(cancellationToken);
    }
}
