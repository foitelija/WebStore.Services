using BlazorShop.Shared;
using System.Collections.Generic;

namespace BlazorShop.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>();

        public void LoadCategories()
        {
            Categories = new List<Category>
            {
                new Category
                {
                    Id = 1,
                    Name = "Action",
                    Url = "action-games",
                    Icon = "aperture",
                },
                new Category
                {
                    Id = 2,
                    Name ="Role play",
                    Url ="role-play-games",
                    Icon ="aperture",
                },
                new Category
                {
                    Id=3,
                    Name ="Fight",
                    Url="fighting-games",
                    Icon ="aperture",
                },
                new Category
                {
                    Id=4,
                    Name="Race",
                    Url="racing-games",
                    Icon="aperture",
                },
            };
        }
    }
}
