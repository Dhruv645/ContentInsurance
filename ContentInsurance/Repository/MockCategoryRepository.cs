using ContentInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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