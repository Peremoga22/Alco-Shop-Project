using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Interfacies;
using WebApplication1.Models;

namespace WebApplication1.Data.Repositories.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                      new Category{CategoryName="Alcoholic", Description="All alcoholic drink"},
                      new Category{CategoryName="Non-Alcohol",Description="All non-alcoholic drinks"}
                };
            }
        }
    }
}
