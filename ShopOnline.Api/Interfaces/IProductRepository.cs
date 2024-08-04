using ShopOnline.Api.Entities;

namespace ShopOnline.Api.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProduct();

        Task<IEnumerable<Category>> GetAllCategories();

        Task<Product> GetProductById(int id);

        Task<Category> GetCategoryById(int id);
    }
}
