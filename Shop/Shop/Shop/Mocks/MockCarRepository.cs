using Shop.Models;
using Shop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Mocks
{
    public class MockCarRepository : ICarRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car {
                        Name = "718 Cayman",
                        Price = 4000000M,
                        ShortDescription = "718 Cayman",
                        LongDescription = "718 Cayman",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "http://porsche.ua/images/doc/d/4/d499c9a-porsche-model.png",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "http://porsche.ua/images/doc/d/4/d499c9a-porsche-model.png"
                    },
                    new Car {
                        Name = "718 Boxster",
                        Price = 4000000M,
                        ShortDescription = "718 Boxster",
                        LongDescription = "718 Boxster",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "http://porsche.ua/images/doc/7/2/72ca0c0-porsche-model--28-.png",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "http://porsche.ua/images/doc/7/2/72ca0c0-porsche-model--28-.png"
                    },
                    new Car {
                        Name = "911 Carrera",
                        Price = 4000000M,
                        ShortDescription = "911 Carrera",
                        LongDescription = "911 Carrera",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "http://porsche.ua/images/doc/e/9/e918801-porsche-model.png",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "http://porsche.ua/images/doc/e/9/e918801-porsche-model.png"
                    },
                    new Car {
                        Name = "911 Turbo",
                        Price = 4000000M,
                        ShortDescription = "911 Turbo",
                        LongDescription = "911 Turbo",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "http://porsche.ua/images/doc/d/8/d815cb0-porsche-model.png",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "http://porsche.ua/images/doc/d/8/d815cb0-porsche-model.png"
                    },
                    new Car {
                        Name = "911 GT2 RS",
                        Price = 4000000M,
                        ShortDescription = "911 GT2 RS",
                        LongDescription = "911 GT2 RS",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "http://porsche.ua/images/doc/a/9/a952179-porsche-model--1-.png",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "http://porsche.ua/images/doc/a/9/a952179-porsche-model--1-.png"
                    },
                     new Car {
                        Name = "Cayenne Turbo",
                        Price = 4000000M,
                        ShortDescription = "Cayenne Turbo",
                        LongDescription = "Cayenne Turbo",
                        Category = _categoryRepository.Categories.ElementAt(1),
                        ImageUrl = "http://porsche.ua/images/doc/6/f/6f1ab79-ct.png",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "http://porsche.ua/images/doc/6/f/6f1ab79-ct.png"
                    },
                    new Car {
                        Name = "Maсan Turbo",
                        Price = 4000000M,
                        ShortDescription = "Maсan Turbo",
                        LongDescription = "Maсan Turbo",
                        Category = _categoryRepository.Categories.ElementAt(2),
                        ImageUrl = "http://porsche.ua/images/doc/2/1/21b1499-porsche-model--31-.png",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "http://porsche.ua/images/doc/2/1/21b1499-porsche-model--31-.png"
                    },
                    new Car {
                        Name = "Macan GTS",
                        Price = 4000000M,
                        ShortDescription = "Macan GTS",
                        LongDescription = "Macan GTS",
                        Category = _categoryRepository.Categories.ElementAt(2),
                        ImageUrl = "http://porsche.ua/images/doc/a/3/a32555f-porsche-model--30-.png",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "http://porsche.ua/images/doc/a/3/a32555f-porsche-model--30-.png"
                    },
                    new Car {
                        Name = "Panamera Turbo",
                        Price = 4000000M,
                        ShortDescription = "Panamera Turbo",
                        LongDescription = "Panamera Turbo",
                        Category = _categoryRepository.Categories.ElementAt(3),
                        ImageUrl = "http://porsche.ua/images/doc/9/8/98b924b-porsche-model--24-.png",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "http://porsche.ua/images/doc/9/8/98b924b-porsche-model--24-.png"
                    },
                    new Car {
                        Name = "Panamera E-Hybrid",
                        Price = 4000000M,
                        ShortDescription = "Panamera E-Hybrid",
                        LongDescription = "Panamera E-Hybrid",
                        Category = _categoryRepository.Categories.ElementAt(3),
                        ImageUrl = "http://porsche.ua/images/doc/6/8/680e25a-porsche-model--19-.png",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "http://porsche.ua/images/doc/6/8/680e25a-porsche-model--19-.png"
                    },
                };
            }
        }

        public IEnumerable<Car> PreferredCars { get; }

        Car ICarRepository.GetCarById(int CarId)
        {
            throw new NotImplementedException();
        }
    }
}