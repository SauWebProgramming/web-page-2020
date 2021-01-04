using DrinKing.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinKing.Data
{
    public class DbInitializer
    {
        public static void Seed(IServiceProvider applicationBuilder)
        {
            ApplicationDbContext context =
                applicationBuilder.GetRequiredService<ApplicationDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Drinks.Any())
            {
                context.AddRange
                (
                    new Drink
                    {
                        Name = "Coca-Cola Clear",
                        Price = 11.99M,
                        ShortDescription = "Tamamen renksiz, 0 kalori ve limon aroması.",
                        LongDescription = "...",
                        Category = Categories["Alkolsüz"],
                        ImageUrl = "/wwwroot/Images/clear.jpg",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "/wwwroot/Images/clear.jpg"
                    },
                    new Drink
                    {
                        Name = "Coca-Cola Clear Lime",
                        Price = 12.95M,
                        ShortDescription = "Özgün Clear tadı lime ferahlığı ile...",
                        LongDescription = "",
                        Category = Categories["Alkolsüz"],
                        ImageUrl = "/wwwroot/Images/clearlime.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/wwwroot/Images/clearlime.webp"
                    },
                    new Drink
                    {
                        Name = "Coca-Cola Frozen ",
                        Price = 14.95M,
                        ShortDescription = "Enfes Coca-Cola Tadı frozen ile birleşiyor.",
                        LongDescription = "",
                        Category = Categories["Alkolsüz"],
                        ImageUrl = "/wwwroot/Images/frozen.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/wwwroot/Images/frozen.jpg"
                    },
                    new Drink
                    {
                        Name = "Coca-Cola Cherry ",
                        Price = 12.95M,
                        ShortDescription = "Kiraz aşıklarını mest edecek Coca-Cola lezzeti.",
                        LongDescription = "",
                        Category = Categories["Alkolsüz"],
                        ImageUrl = "/wwwroot/Images/cherry.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/wwwroot/Images/cherry.jpg"
                    }

                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Alkollü", Description="Alkollü içecekler" },
                        new Category { CategoryName = "Alkolsüz", Description="Alkolsüz içecekler" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
