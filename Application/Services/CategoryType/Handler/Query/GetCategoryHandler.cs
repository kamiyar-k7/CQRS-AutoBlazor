
using Application.Dtos;
using Application.Services.CategoryType.Request.Query;
using Domain.IRepository.ICategory;
using MediatR;

namespace Application.Services.CategoryType.Handler.Query;

public class GetCategoryHandler : IRequestHandler<GetCategoryRequest, CategoryDto>
{


    #region Ctoe
    private readonly ICategoryRepository _categoryRepository;

    public GetCategoryHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    #endregion


    public async Task<CategoryDto> Handle(GetCategoryRequest request, CancellationToken cancellationToken)
    {
        var category = await _categoryRepository.Get(request.Id);

        CategoryDto categoryDto = new CategoryDto()
        {
            Description = category.Description,
            Id = category.Id,
            Title = category.Title,
        };
        return categoryDto;

    }
}
