using BlazorShop.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>
        {
            new Category { Id = 1, Name = "Action", Url ="action-games", Icon ="aperture"},
            new Category { Id = 2, Name = "Role-play", Url ="role-play-games", Icon ="aperture"},
            new Category { Id = 3, Name = "Fight", Url ="fighting-games", Icon ="aperture"},
            new Category { Id = 4, Name = "Race", Url ="racing-games", Icon ="aperture"},
        };
        public async Task<List<Category>> GetCategories()
        {
            
            return Categories;
        }

        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            return Categories.FirstOrDefault(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}
