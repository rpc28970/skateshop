
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Anti-Hero Flamingo Board",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "/images/products/sb-an1.png",
                    Brand = "Anti-Hero",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Anti-Hero Party Board",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 15000,
                    PictureUrl = "/images/products/sb-an2.png",
                    Brand = "Anti-Hero",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Zero 3 Skull Board",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/sb-zero1.png",
                    Brand = "Zero",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Zero Gray Skull Board",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 30000,
                    PictureUrl = "/images/products/sb-zero2.png",
                    Brand = "Zero",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Baker Original Board",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 25000,
                    PictureUrl = "/images/products/sb-baker1.png",
                    Brand = "Baker",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Toy Machine Scooter Board",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 12000,
                    PictureUrl = "/images/products/sb-toy1.png",
                    Brand = "Toy Machine",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Baker Baseball Hat",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1000,
                    PictureUrl = "/images/products/hat-baker1.png",
                    Brand = "Baker",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Vans Drink Hat",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 8000,
                    PictureUrl = "/images/products/hat-vans1.png",
                    Brand = "Vans",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Vans Skate Hat",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/hat-vans2.png",
                    Brand = "Vans",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Tensor Silver Trucks",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1800,
                    PictureUrl = "/images/products/truck-tensor1.png",
                    Brand = "Tensor",
                    Type = "Trucks",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Thunder Mid Trucks",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/truck-thunder1.png",
                    Brand = "Thunder",
                    Type = "Trucks",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Royal Premium Trucks",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1600,
                    PictureUrl = "/images/products/truck-royal1.png",
                    Brand = "Royal",
                    Type = "Trucks",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Royal High Trucks",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1400,
                    PictureUrl = "/images/products/truck-royal2.png",
                    Brand = "Royal",
                    Type = "Trucks",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Nike Air Shoes",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 25000,
                    PictureUrl = "/images/products/shoes-nike1.png",
                    Brand = "Nike",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Lakai Street Shoes",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 18999,
                    PictureUrl = "/images/products/shoes-lakai1.png",
                    Brand = "Lakai",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Lakai Blue Shoes",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 19999,
                    PictureUrl = "/images/products/shoes-lakai2.png",
                    Brand = "Lakai",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Vans Low Top Shoes",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Price = 15000,
                    PictureUrl = "/images/products/shoes-vans1.png",
                    Brand = "Vans",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Vans High Top Shoes",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/shoes-vans2.png",
                    Brand = "Vans",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}