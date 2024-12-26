
using AutoBlazor.Shared.Services.Base.ClientServcies;

namespace AutoBlazor.shared.Services.CategoryServices;

public class CategoryServices : ICategoryServices
{
    #region Ctor
    private readonly IClient _client;

    public CategoryServices(IClient client)
    {
        _client = client;
    }
    #endregion


    public async Task<List<CategoryDto>> GetCategoryList()
    {
        var categoryList = await _client.GetAllCategoriesAsync();
        return categoryList.ToList();
    }
}
