using BlazorShop.Shared;
using System.Collections.Generic;
namespace BlazorShop.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        public List<Category> Categories { get; set; }
        void LoadCategories();
    }
}
