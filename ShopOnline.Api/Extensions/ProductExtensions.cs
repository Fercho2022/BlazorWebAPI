using ShopOnline.Api.Entities;
using ShopOnline.Models.Dtos;
namespace ShopOnline.Api.Extensions
{
    public static class ProductExtensions
    {
        public static IEnumerable<ProductDto> ToProductDtos(this IEnumerable<Product> products, IEnumerable<Category> categories)
        {

            // Mapear productos a ProductDto incluyendo el nombre de la categoría
            return products.Select(product => new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                ImageURL = product.ImageURL,
                Price = product.Price,
                Qty = product.Qty,
                CategoryId = product.CategoryId,
                CategoryName = categories.FirstOrDefault(category => category.Id == product.CategoryId)?.Name
            }).ToList();

        }
    }
}
