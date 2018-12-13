using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Mocks;
using Shop.Interfaces;
using Shop.Models;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class CarController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICarRepository _carRepository;

        public CarController(ICategoryRepository categoryRepository, ICarRepository carRepository)
        {
            _categoryRepository = categoryRepository;
            _carRepository = carRepository;
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars;
            string currentCategory = string.Empty;
            if (string.IsNullOrEmpty(category))
            {
                cars = _carRepository.Cars.OrderBy(n=>n.CarId);
                currentCategory = "All cars";
            }
            else
            {
                if (string.Equals("718", _category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _carRepository.Cars.Where(c => c.Category.CategoryName.Equals("718")).OrderBy(n => n.CarId);
                } else if (string.Equals("Panamera", _category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _carRepository.Cars.Where(c => c.Category.CategoryName.Equals("Panamera")).OrderBy(n => n.CarId);
                } else if (string.Equals("Macan", _category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _carRepository.Cars.Where(c => c.Category.CategoryName.Equals("Macan")).OrderBy(n => n.CarId);
                } else if (string.Equals("Cayenne", _category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _carRepository.Cars.Where(c => c.Category.CategoryName.Equals("Cayenne")).OrderBy(n => n.CarId);
                } else
                {
                    cars = _carRepository.Cars.Where(c => c.Category.CategoryName.Equals("911")).OrderBy(n => n.CarId);
                }
                
                currentCategory = _category;
            }
            ViewBag.Name = "CC";

            CarListViewModel vm = new CarListViewModel();
            vm.Cars = cars;
            vm.CurrentCategory = currentCategory;

            return View(vm);
        }
    }
}