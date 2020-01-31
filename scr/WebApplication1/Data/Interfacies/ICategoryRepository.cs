using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data.Interfacies
{
   public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
