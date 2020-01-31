using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data.Interfacies;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IDrinkRepository drinkRepository;

        public DrinkController(ICategoryRepository repoCategory, IDrinkRepository repoDrink)
        {
            this.categoryRepository = repoCategory;
            this.drinkRepository = repoDrink;
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Drink> drinks;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                drinks = drinkRepository.Drinks.OrderBy(n => n.DrinkId);
                currentCategory = "All drinks";
            }
            else
            {
                if (string.Equals("Alcoholic", _category, StringComparison.OrdinalIgnoreCase))
                {
                    drinks = drinkRepository.Drinks.Where(p => p.Category.CategoryName.Equals("Alcoholic")).OrderBy(p => p.Name);
                }
                else
                {
                    drinks = drinkRepository.Drinks.Where(p => p.Category.CategoryName.Equals("Non-Alcohol")).OrderBy(p => p.Name);

                    currentCategory = _category;
                }

            }
            var drinkListViewModel = new DrinkListViewModel
            {
                Drinks = drinks,
                CurrentCategory = currentCategory
            };
            return View(drinkListViewModel);
        }
    }
}