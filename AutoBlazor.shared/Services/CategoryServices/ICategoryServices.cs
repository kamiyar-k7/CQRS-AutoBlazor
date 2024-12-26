
using AutoBlazor.Shared.Services.Base.ClientServcies;

namespace AutoBlazor.shared.Services.CategoryServices;

public interface ICategoryServices
{

    Task<List<CategoryDto>> GetCategoryList();
}
