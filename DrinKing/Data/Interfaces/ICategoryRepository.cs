using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinKing.Data.Models;

namespace DrinKing.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
