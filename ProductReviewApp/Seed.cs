using ProductReviewApp.Data;
using ProductReviewApp.Models;

namespace ProductReviewApp
{
    public class Seed
    {
        private readonly DataContext _context;
        public Seed(DataContext context)
        {
            _context = context;
        }
        public void SeedDataContext()
        {
            if (!_context.ProductOwners.Any())
            {
                var electronicsCategory = _context.Categories.FirstOrDefault(c => c.Name == "Electronics");

                if (electronicsCategory == null)
                {
                    electronicsCategory = new Category() { Name = "Electronics" };
                }

                var productOwners = new List<ProductOwner>()
                {
                    new ProductOwner()
                    {
                        Product = new Product()
                        {
                            Name = "Apple iPhone 13 Pro",
                            Description = "The Apple iPhone 13 Pro is the latest flagship smartphone from Apple, offering cutting-edge technology, exceptional performance, and an elegant design. Packed with features like the A15 Bionic chip, ProMotion display, and an impressive camera system, this phone sets new standards for excellence.",
                            ProductCategories = new List<ProductCategory>()
                            {
                                new ProductCategory { Category = electronicsCategory},
                                new ProductCategory { Category = new Category() { Name = "Mobile Phones"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Love it",Text = "The iPhone 13 Pro is a masterpiece. The camera quality is outstanding, and the ProMotion display is a game-changer. It's fast, sleek, and everything you'd expect from Apple. I love it!", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Sarah", LastName = "Kindell" } },
                                new Review { Title="Worth every penny", Text = "The iPhone 13 Pro is a fantastic device. The battery life is notably improved, and the camera system produces stunning photos. The only drawback is the price, but if you can afford it, it's worth every penny.", Rating = 4,
                                Reviewer = new Reviewer(){ FirstName = "John", LastName = "Jones" } },
                                new Review { Title="A joy to use",Text = "This phone is a powerhouse. The performance is top-notch, and the ProMotion display makes scrolling through apps and websites incredibly smooth. The build quality is premium, and it's a joy to use.", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Alex", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "David",
                            LastName = "Shelton",
                            PhoneNumber = "01110-555555",
                            Country = new Country()
                            {
                                Name = "Ireland"
                            }
                        }
                    },
                     new ProductOwner()
                    {
                        Product = new Product()
                        {
                            Name = "Sony WH-1000XM4 Wireless Headphones",
                            Description = "The Sony WH-1000XM4 Wireless Headphones are the pinnacle of audio technology, offering industry-leading noise cancellation, exceptional sound quality, and a comfortable design. These headphones are perfect for audiophiles and travelers seeking an immersive audio experience.",
                            ProductCategories = new List<ProductCategory>()
                            {
                                new ProductCategory { Category = electronicsCategory},
                                new ProductCategory { Category = new Category() { Name = "Headphones"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Can't imagine my life without them",Text = " I'm in love with the Sony WH-1000XM4 headphones. The noise cancellation is next-level, and the sound quality is incredibly crisp. They're comfortable for long listening sessions, and I can't imagine my life without them.", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Emily", LastName = "Johnson" } },
                                new Review { Title="Easy to use", Text = "These headphones are amazing. The noise-canceling feature is perfect for my daily commute. The battery life is impressive, and the sound quality is exceptional. The touch controls make them easy to use.", Rating = 4,
                                Reviewer = new Reviewer(){ FirstName = "David", LastName = "Jones" } },
                                new Review { Title="Quality is exceptional",Text = "These headphones are a dream come true for music lovers. The sound is rich and detailed, and they're comfortable to wear for hours. The touchpad controls are intuitive, and the build quality is exceptional.", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "John", LastName = "Brown" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Sarah",
                            LastName = "Davis",
                            PhoneNumber = "02220-333333",
                            Country = new Country()
                            {
                                Name = "UK"
                            }
                        }
                    },
                     new ProductOwner()
                    {
                        Product = new Product()
                        {
                            Name = "Bosch Serie 6 Dishwasher",
                            Description = "The Bosch Serie 6 Dishwasher is a reliable and efficient appliance that makes dishwashing a breeze. With advanced features, multiple wash programs, and a sleek design, it's a perfect addition to any modern kitchen.",
                            ProductCategories = new List<ProductCategory>()
                            {
                                new ProductCategory { Category = new Category() { Name = "Appliances"}},
                                new ProductCategory { Category = new Category() { Name = "Dishwashers"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="The Bosch Serie 6 is great!",Text = "The dishwasher's energy efficiency is impressive, and it saves on water too. The quick wash cycle is perfect for when you need clean dishes in a hurry.", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Katrin", LastName = "Schmidt" } },
                                new Review { Title="I love this dishwasher!", Text = "It's so quiet that I hardly notice it's running. The dishes come out sparkling clean every time. The extra space inside is a bonus for larger loads.", Rating = 4,
                                Reviewer = new Reviewer(){ FirstName = "Felix", LastName = "Becker" } },
                                new Review { Title="The Bosch Serie 6 has improved my life!",Text = "I appreciate the quality of this dishwasher. It's durable and effective. The adjustable racks are handy for different dish sizes.", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Lena", LastName = "Wagner" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Max",
                            LastName = "Fischer",
                            PhoneNumber = "06226364439",
                            Country = new Country()
                            {
                                Name = "Germany"
                            }
                        }
                    }
                };
                _context.ProductOwners.AddRange(productOwners);
                _context.SaveChanges();
            }
        }
    }
}
