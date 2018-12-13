using Microsoft.EntityFrameworkCore;
using Shop.Interfaces;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repositories
{
    public class CarRepository : ICarRepository
    {

        private readonly AppDbContext appDbContext;

        public CarRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Car> Cars => appDbContext.Cars.Include(c => c.Category);

        public IEnumerable<Car> PreferredCars => appDbContext.Cars.Where(p => p.IsPreferredCar).Include(c => c.Category);

        public Car GetCarById(int carId) => appDbContext.Cars.FirstOrDefault(p => p.CarId == carId);
    }
}
