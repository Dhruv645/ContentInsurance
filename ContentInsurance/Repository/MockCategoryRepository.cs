using ContentInsurance.Models;
using System.Collections.Generic;

namespace ContentInsurance.Repository
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category{CategoryId=1,Name="Electronics"},
            new Category{CategoryId=2,Name="Clothing" },
            new Category{CategoryId=3,Name="Kitchen" }
        };
    }
}