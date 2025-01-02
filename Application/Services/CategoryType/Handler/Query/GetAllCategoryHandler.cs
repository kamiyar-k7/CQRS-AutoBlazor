
using Application.Dtos;
using Application.Services.CategoryType.Request.Query;
using Domain.IRepository.ICategory;
using MediatR;

namespace Application.Services.CategoryType.Handler.Query;

public class GetAllCategoryHandler : IRequestHandler<GetAllCategoryRequest, List<CategoryDto>>
{

    #region Ctor
    private readonly ICategoryRepository _categoryRepository;

    public GetAllCategoryHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    #endregion

    public async Task<List<CategoryDto>> Handle(GetAllCategoryRequest request, CancellationToken cancellationToken)
    {

        var categories = await _categoryRepository.GetAll();

        List<CategoryDto> listOfCategory = new List<CategoryDto>();

        foreach (var category in categories)
        {

            CategoryDto categoryDto = new CategoryDto()
            {
                Description = category.Description,
                Id = category.Id,
                Title = category.Title,
                CreateDate = category.CreateDate    
            };
            listOfCategory.Add(categoryDto);

        }


        return listOfCategory;
    }
}
