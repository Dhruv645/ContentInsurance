using ContentInsurance.Models;
using System.Collections.Generic;

namespace ContentInsurance.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
