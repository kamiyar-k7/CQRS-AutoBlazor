
using Application.Dtos;
using MediatR;

namespace Application.Services.CategoryType.Request.Command;

public class DeleteCategoryRequest : IRequest<Unit>
{

    public CategoryDto CategoryDto { get; set; }
    
}
