using Application.Services.CategoryType.Request.Command;
using Domain.Entities;
using Domain.IRepository.ICategory;
using MediatR;

namespace Application.Services.CategoryType.Handler.Command;

public class CreateCategoryHandler : IRequestHandler<CreateCategoryRequest, Unit>
{

    private readonly ICategoryRepository _categoryRepository;

    public CreateCategoryHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<Unit> Handle(CreateCategoryRequest request, CancellationToken cancellationToken)
    {
        Category category = new Category()
        {
            Description = request.createCategoryDto.Description,
            CreateDate = request.createCategoryDto.CreateDate,
            Title = request.createCategoryDto.Title,
        };


        await _categoryRepository.CreateAsync(category);

        return Unit.Value;
    }
}
