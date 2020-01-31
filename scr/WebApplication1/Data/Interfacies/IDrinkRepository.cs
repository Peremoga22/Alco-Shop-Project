using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data.Interfacies
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get; }
        IEnumerable<Drink> PreferredDrinks { get; }
        Drink GetDrinkById(int drinkId);
    }
}
