using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Mocks;
using Shop.Interfaces;
using Shop.Models;

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
        public ViewResult List()
        {
            var cars = _carRepository.Cars;
            return View(cars);
        }
    }
}