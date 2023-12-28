using DemoClean8.Application.Common.Interfaces;

namespace DemoClean8.Application.Categories.Commands.UpdateCategory;
public class UpdateCategoryValidator : AbstractValidator<UpdateCategoryCommand>
{
    private readonly IApplicationDbContext _context;

    public UpdateCategoryValidator(IApplicationDbContext context)
    {
        _context = context;

        RuleFor(category => category.Name)
            .NotEmpty()
            .MaximumLength(200)
            .MustAsync(HaveUniqueName)
                .WithMessage("'{PropertyName}' must be unique.")
                .WithErrorCode("Unique");

        RuleFor(category => category.Description)
            .MaximumLength(300)
            .MustAsync(HaveUniqueDescription)
                .WithMessage("'{PropertyName}' must be unique.")
                .WithErrorCode("Unique");
    }

    public async Task<bool> HaveUniqueName(UpdateCategoryCommand model, string name, CancellationToken cancellationToken)
    {
        return await _context.Categories
            .Where(l => l.Id != model.Id)
            .AllAsync(l => l.Name != name, cancellationToken);
    }

    public async Task<bool> HaveUniqueDescription(UpdateCategoryCommand model, string description, CancellationToken cancellationToken)
    {
        return await _context.Categories
            .Where(l => l.Id != model.Id)
            .AllAsync(l => l.Description != description, cancellationToken);
    }
}
