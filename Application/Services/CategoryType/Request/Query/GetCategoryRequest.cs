

using Application.Dtos;
using MediatR;

namespace Application.Services.CategoryType.Request.Query;

public class GetCategoryRequest : IRequest<CategoryDto>
{

    public int Id { get; set; }
}
