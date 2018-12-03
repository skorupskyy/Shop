using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Interfaces
{
    public interface ICarRepository
    {
        IEnumerable<Car> Cars { get; }

        IEnumerable<Car> PreferredCars { get; }

        Car GetCarById(int CarId);
    }
}
