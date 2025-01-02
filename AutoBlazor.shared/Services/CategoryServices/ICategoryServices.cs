using AutoBlazor.Shared.Services.Base.ClientServcies;

namespace AutoBlazor.Shared.Services.CategoryServices;

public interface ICategoryServices
{
    Task<List<CategoryDto>> GetCategories();
}
