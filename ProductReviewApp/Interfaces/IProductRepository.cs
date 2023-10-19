using ProductReviewApp.Models;

namespace ProductReviewApp.Interfaces
{
    public interface IProductRepository
    {
        ICollection<Product> GetProducts(); 
        Product GetProduct(int productId);
        Product GetProduct(string name);
        decimal GetProductRating(int productId);
        bool ProductExists(int productId);
        bool CreateProduct(int ownerId, int categoryId, Product product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(Product product);
        bool Save();
    }
}
