using Application.Dtos;
using MediatR;

namespace Application.Services.CategoryType.Request.Command;

public class UpdateCategoryRequest : IRequest<Unit>
{
    public CategoryDto updateCategoryDto { get; set; }
}
