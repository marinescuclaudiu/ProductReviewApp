namespace ProductReviewApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<ProductOwner> ProductOwners { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }

    }
}
