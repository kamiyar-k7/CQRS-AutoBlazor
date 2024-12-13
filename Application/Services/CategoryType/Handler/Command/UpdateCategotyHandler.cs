
using Application.Services.CategoryType.Request.Command;
using Domain.IRepository.ICategory;
using MediatR;

namespace Application.Services.CategoryType.Handler.Command;

public class UpdateCategotyHandler : IRequestHandler<UpdateCategoryRequest, Unit>
{

    private readonly ICategoryRepository _categoryRepository;

    public UpdateCategotyHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<Unit> Handle(UpdateCategoryRequest request, CancellationToken cancellationToken)
    {
        var entity = await _categoryRepository.Get(request.updateCategoryDto.Id);

        if (entity == null) 
        {

            entity.Title = request.updateCategoryDto.Title;
            entity.Description = request.updateCategoryDto.Description;
          

            await _categoryRepository.UpdateAsync(entity);
        }
        else
        {
            throw new DirectoryNotFoundException();
        }
        return Unit.Value;
    }
}
