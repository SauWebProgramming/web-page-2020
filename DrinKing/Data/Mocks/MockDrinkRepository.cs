using DrinKing.Data.Interfaces;
using DrinKing.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinKing.Data.Mocks
{
    public class MockDrinkRepository : IDrinkRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Drink> Drinks
        {
            get
            {
                return new List<Drink>
                {
                    new Drink {
                        Name = "Coca-Cola Clear",
                        Price = 11.99M, ShortDescription = "Tamamen renksiz, 0 kalori ve limon aroması.",
                        LongDescription = "...",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "/wwwroot/Images/clear.jpg",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "/wwwroot/Images/clear.jpg"
                    },
                    new Drink {
                        Name = "Coca-Cola Clear Lime",
                        Price = 12.95M, ShortDescription = "Özgün Clear tadı lime ferahlığı ile...",
                        LongDescription = "",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "/wwwroot/Images/clearlime.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/wwwroot/Images/clearlime.webp"
                    },
                    new Drink {
                        Name = "Coca-Cola Frozen ",
                        Price = 14.95M, ShortDescription = "Enfes Coca-Cola Tadı frozen ile birleşiyor.",
                        LongDescription = "",
                        Category =  _categoryRepository.Categories.First(),
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
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "/wwwroot/Images/cherry.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "/wwwroot/Images/cherry.jpg"
                    }
                };
            }
        }
        public IEnumerable<Drink> PreferredDrinks { get; }
        public Drink GetDrinkById(int drinkId)
        {
            throw new NotImplementedException();
        }
    }
}
