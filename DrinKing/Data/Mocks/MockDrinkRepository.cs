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
        public IEnumerable<Drink> Drinks => throw new NotImplementedException();

        public IEnumerable<Drink> PreferredDrinks => throw new NotImplementedException();

        public Drink GetDrinkById(int drinkId)
        {
            throw new NotImplementedException();
        }
    }
}
