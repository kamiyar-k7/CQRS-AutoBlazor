
using Application.Services.CategoryType.Request.Command;
using Domain.IRepository.ICategory;
using MediatR;

namespace Application.Services.CategoryType.Handler.Command;

public class DeleteCategoryHandler : IRequestHandler<DeleteCategoryRequest, Unit>
{

    #region Ctor
     private readonly ICategoryRepository _categoryRepository;

    public DeleteCategoryHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    #endregion

    public async Task<Unit> Handle(DeleteCategoryRequest request, CancellationToken cancellationToken)
    {
        var entity = await _categoryRepository.Get(request.CategoryDto.Id);

        entity.Id = request.CategoryDto.Id;
        entity.Title = request.CategoryDto.Title;
        entity.Description = request.CategoryDto.Description;
       

        await _categoryRepository.DeleteAsync(entity);


        return Unit.Value;
    }
}
