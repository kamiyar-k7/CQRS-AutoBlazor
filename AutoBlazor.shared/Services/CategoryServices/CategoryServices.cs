using AutoBlazor.Shared.Services.Base.ClientServcies;

namespace AutoBlazor.Shared.Services.CategoryServices;


public class CategoryServices : ICategoryServices
{
    #region Ctor
    //private readonly HttpClient _httpClient;

    //public CategoryServices(HttpClient httpClient)
    //{
    //    _httpClient = httpClient;
    //}

    private readonly IClient _client;

    public CategoryServices(IClient client)
    {
        _client = client;
    }

    #endregion

    public async Task<List<CategoryDto>> GetCategories()
    {
        var cats = await _client.GetAllCategoriesAsync();

        return cats.ToList();
    }
}
