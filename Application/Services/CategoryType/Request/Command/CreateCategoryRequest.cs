using Application.Dtos;
using MediatR;

namespace Application.Services.CategoryType.Request.Command;

public class CreateCategoryRequest : IRequest<Unit>
{

    public CategoryDto createCategoryDto { get; set; }

}
