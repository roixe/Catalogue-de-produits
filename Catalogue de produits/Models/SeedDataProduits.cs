using Catalogue_de_produits.Models;
using Microsoft.EntityFrameworkCore;
using Catalogue_de_produits.Data;

namespace RazorPagesMovie.Models;

public static class SeedDataProduits
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new Catalogue_de_produitsContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<Catalogue_de_produitsContext>>()))
        {
            if (context == null || context.Produit == null)
            {
                throw new ArgumentNullException("Null Catalogue_de_produitsContext");
            }

            // Look for any movies.
            if (context.Produit.Any())
            {
                return;   // DB has been seeded
            }

            context.Produit.AddRange(
               
    new Produit
    {
        Name = "Apple iPhone 13",
        Description = "Latest model with A15 Bionic chip",
        Stock = 50,
        Price = 999.99M,
        ImageUrl = "/Assets/iphone13.webp"
    },
    new Produit
    {
        Name = "Samsung Galaxy S21",
        Description = "Flagship phone with Exynos 2100",
        Stock = 40,
        Price = 799.99M,
        ImageUrl = "/Assets/Samsung Galaxy S21.webp"
    },
    new Produit
    {
        Name = "Sony WH-1000XM4",
        Description = "Noise-cancelling wireless headphones",
        Stock = 30,
        Price = 349.99M,
        ImageUrl = "/Assets/Sony WH-1000XM4.webp"
    },
    new Produit
    {
        Name = "Dell XPS 13",
        Description = "Compact and powerful laptop",
        Stock = 20,
        Price = 1199.99M,
        ImageUrl = "/Assets/Dell XPS 13.webp"
    },
    new Produit
    {
        Name = "Apple MacBook Pro",
        Description = "16-inch laptop with M1 chip",
        Stock = 15,
        Price = 2399.99M,
        ImageUrl = "/Assets/Apple MacBook Pro.webp"
    },
    new Produit
    {
        Name = "Amazon Echo Dot",
        Description = "Smart speaker with Alexa",
        Stock = 100,
        Price = 49.99M,
        ImageUrl = "/Assets/Amazon Echo Dot.webp"
    },
    new Produit
    {
        Name = "Google Nest Hub",
        Description = "Smart display with Google Assistant",
        Stock = 60,
        Price = 89.99M,
        ImageUrl = "/Assets/Google Nest Hub.webp"
    },
    new Produit
    {
        Name = "Fitbit Charge 5",
        Description = "Advanced fitness tracker",
        Stock = 70,
        Price = 149.99M,
        ImageUrl = "/Assets/Fitbit Charge 5.webp"
    },
    new Produit
    {
        Name = "GoPro HERO9",
        Description = "Waterproof action camera",
        Stock = 25,
        Price = 399.99M,
        ImageUrl = "/Assets/GoPro HERO9.webp"
    },
    new Produit
    {
        Name = "Canon EOS R5",
        Description = "Full-frame mirrorless camera",
        Stock = 10,
        Price = 3899.99M,
        ImageUrl = "/Assets/Canon EOS R5.webp"
    },
    new Produit
    {
        Name = "Microsoft Surface Pro 7",
        Description = "2-in-1 laptop with detachable keyboard",
        Stock = 35,
        Price = 899.99M,
        ImageUrl = "/Assets/Microsoft Surface Pro 7.webp"
    },
    new Produit
    {
        Name = "Bose QuietComfort 35 II",
        Description = "Wireless noise-cancelling headphones",
        Stock = 45,
        Price = 299.99M,
        ImageUrl = "/Assets/Bose QuietComfort 35 II.webp"
    },
    new Produit
    {
        Name = "Nikon Z6 II",
        Description = "Full-frame mirrorless camera",
        Stock = 12,
        Price = 1999.99M,
        ImageUrl = "/Assets/Nikon Z6 II.webp"
    },
    new Produit
    {
        Name = "Apple Watch Series 7",
        Description = "Smartwatch with advanced health features",
        Stock = 55,
        Price = 429.99M,
        ImageUrl = "/Assets/Apple Watch Series 7.webp"
    },
    new Produit
    {
        Name = "Dyson V11",
        Description = "Cordless vacuum cleaner",
        Stock = 20,
        Price = 599.99M,
        ImageUrl = "/Assets/Dyson V11.webp"
    },
    new Produit
    {
        Name = "Samsung QLED TV",
        Description = "65-inch 4K UHD smart TV",
        Stock = 10,
        Price = 1499.99M,
        ImageUrl = "/Assets/Samsung QLED TV.webp"
    },
    new Produit
    {
        Name = "Apple AirPods Pro",
        Description = "Wireless earbuds with noise cancellation",
        Stock = 80,
        Price = 249.99M,
        ImageUrl = "/Assets/Apple AirPods Pro.webp"
    },
    new Produit
    {
        Name = "JBL Flip 5",
        Description = "Portable Bluetooth speaker",
        Stock = 100,
        Price = 119.99M,
        ImageUrl = "/Assets/JBL Flip 5.webp"
    },
    new Produit
    {
        Name = "Oculus Quest 2",
        Description = "All-in-one VR headset",
        Stock = 25,
        Price = 299.99M,
        ImageUrl = "/Assets/Oculus Quest 2.webp"
    },
    new Produit
    {
        Name = "Logitech MX Master 3",
        Description = "Advanced wireless mouse",
        Stock = 40,
        Price = 99.99M,
        ImageUrl = "/Assets/Logitech MX Master 3.webp"
    }
            );
            context.SaveChanges();
        }
    }
}