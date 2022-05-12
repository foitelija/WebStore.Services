using BlazorShop.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorShop.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();
        Task<Category>GetCategoryByUrl(string categoryUrl);
    }
}
