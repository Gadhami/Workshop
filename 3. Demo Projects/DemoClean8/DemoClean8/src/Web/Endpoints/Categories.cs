using DemoClean8.Application.Categories.Commands.CreateCategory;
using DemoClean8.Application.Categories.Commands.DeleteCategory;
using DemoClean8.Application.Categories.Commands.UpdateCategory;
using DemoClean8.Application.Categories.Queries.GetCategories;

namespace DemoClean8.Web.Endpoints;
public class Categories : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
           .RequireAuthorization()
           .MapGet(GetCategories)
           .MapPost(CreateCategory)
           .MapPut(UpdateCategory, "{id}")
           .MapDelete(DeleteCategory, "{id}");
    }

    public async Task<CategoriesVm> GetCategories(ISender sender)
    {
        return await sender.Send(new GetCategoriesQuery());
    }

    public async Task<int> CreateCategory(ISender sender, CreateCategoryCommand command)
    {
        return await sender.Send(command);
    }

    public async Task<IResult> UpdateCategory(ISender sender, int id, UpdateCategoryCommand command)
    {
        if (id != command.Id) return Results.BadRequest();
        await sender.Send(command);
        return Results.NoContent();
    }

    public async Task<IResult> DeleteCategory(ISender sender, int id)
    {
        await sender.Send(new DeleteCategoryCommand(id));
        return Results.NoContent();
    }
}
