using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Interfaces
{
    interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
