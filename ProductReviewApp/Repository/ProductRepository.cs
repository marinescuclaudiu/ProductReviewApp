using ProductReviewApp.Data;
using ProductReviewApp.Interfaces;
using ProductReviewApp.Models;

namespace ProductReviewApp.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateProduct(int ownerId, int categoryId, Product product)
        {
            var productOwnerEntity = _context.Owners.Where(o => o.Id == ownerId).FirstOrDefault();
            var category = _context.Categories.Where(c  => c.Id == categoryId).FirstOrDefault();

            var productOwner = new ProductOwner()
            {
                Owner = productOwnerEntity,
                Product = product
            };

            _context.ProductOwners.Add(productOwner);

            var productCategory = new ProductCategory()
            {
                Category = category,
                Product = product
            };

            _context.ProductCategories.Add(productCategory);

            _context.Add(product);

            return Save();
        }

        public bool DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
            return Save();
        }

        public Product GetProduct(int productId)
        {
            return _context.Products.Where(p => p.Id == productId).FirstOrDefault();
        }

        public Product GetProduct(string name)
        {
            return _context.Products.Where(p => p.Name == name).FirstOrDefault();
        }

        public decimal GetProductRating(int productId)
        {
            var review = _context.Reviews.Where(p => p.Product.Id == productId);

            if(review.Count() <= 0)
                return 0;

            return (decimal)review.Sum(r => r.Rating) / review.Count();
        }

        public ICollection<Product> GetProducts()
        {
            return _context.Products.OrderBy(p => p.Id).ToList();
        }

        public bool ProductExists(int productId)
        {
            return _context.Products.Any(p => p.Id == productId);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            return Save();
        }
    }
}
