using DemoClean8.Application.Common.Interfaces;

namespace DemoClean8.Application.Categories.Commands.CreateCategory;
public class CreateCategoryValidator : AbstractValidator<CreateCategoryCommand>
{
    private readonly IApplicationDbContext _context;

    public CreateCategoryValidator(IApplicationDbContext context)
    {
        _context = context;

        RuleFor(category => category.Name)
            .NotEmpty()
            .MaximumLength(200)
            .MustAsync(HaveUniqueName)
                .WithMessage("'{PropertyName}' must be unique.")
                .WithErrorCode("Unique");
    }

    public async Task<bool> HaveUniqueName(string name, CancellationToken cancellationToken)
    {
        return await _context.Categories
            .AllAsync(l => l.Name != name, cancellationToken);
    }
}
