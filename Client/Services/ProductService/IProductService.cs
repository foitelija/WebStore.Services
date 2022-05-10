using BlazorShop.Shared;
using System.Collections.Generic;

namespace BlazorShop.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }

        void LoadProducts();
    }
}
