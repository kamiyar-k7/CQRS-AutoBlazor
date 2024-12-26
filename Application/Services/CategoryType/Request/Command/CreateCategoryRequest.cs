using Application.Dtos;
using MediatR;

namespace Application.Services.CategoryType.Request.Command;

public class CreateCategoryRequest : IRequest<Unit>
{

    public CreateCategoryRequest(CategoryDto createCategoryDto)
    {
        CreateCategoryDto = createCategoryDto;
    }

    public CategoryDto CreateCategoryDto { get; }

}
