using DemoClean8.Application.Common.Interfaces;

namespace DemoClean8.Application.Categories.Commands.DeleteCategory;
public record DeleteCategoryCommand(int Id) : IRequest;

public class DeleteCategoryHandler : IRequestHandler<DeleteCategoryCommand>
{
    private readonly IApplicationDbContext _context;

    public DeleteCategoryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = await _context.Categories
            .Where(l => l.Id == request.Id)
            .SingleOrDefaultAsync(cancellationToken);

        Guard.Against.NotFound(request.Id, category);

        _context.Categories.Remove(category);

        await _context.SaveChangesAsync(cancellationToken);
    }
}
