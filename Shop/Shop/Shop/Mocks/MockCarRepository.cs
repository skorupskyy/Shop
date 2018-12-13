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
                        ImageUrl = "http://dmi3w0goirzgw.cloudfront.net/gallery-images/1600/406000/900/406955.jpg",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "http://dmi3w0goirzgw.cloudfront.net/gallery-images/1600/406000/900/406955.jpg"
                    },
                    new Car {
                        Name = "718 Boxster",
                        Price = 4000000M,
                        ShortDescription = "718 Boxster",
                        LongDescription = "718 Boxster",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "https://d6d98d1a97a06f1a20df-623577c01afe81cb5c15b33bc0b64a21.ssl.cf1.rackcdn.com/WP0CB2A8XJS229038/6616d7248af28b0d34490d8f0e9dccbd.jpg",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "https://d6d98d1a97a06f1a20df-623577c01afe81cb5c15b33bc0b64a21.ssl.cf1.rackcdn.com/WP0CB2A8XJS229038/6616d7248af28b0d34490d8f0e9dccbd.jpg"
                    },
                    new Car {
                        Name = "911 Carrera",
                        Price = 4000000M,
                        ShortDescription = "911 Carrera",
                        LongDescription = "911 Carrera",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://www.porscheofocala.com/inventoryphotos/5463/wp0ah2a75jl144762/ip/1.jpg",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "https://www.porscheofocala.com/inventoryphotos/5463/wp0ah2a75jl144762/ip/1.jpg"
                    },
                    new Car {
                        Name = "911 Turbo",
                        Price = 4000000M,
                        ShortDescription = "911 Turbo",
                        LongDescription = "911 Turbo",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "http://dmi3w0goirzgw.cloudfront.net/gallery-images/1600/406000/900/406955.jpg",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "http://dmi3w0goirzgw.cloudfront.net/gallery-images/1600/406000/900/406955.jpg"
                    },
                    new Car {
                        Name = "911 GT2 RS",
                        Price = 4000000M,
                        ShortDescription = "911 GT2 RS",
                        LongDescription = "911 GT2 RS",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://d6d98d1a97a06f1a20df-623577c01afe81cb5c15b33bc0b64a21.ssl.cf1.rackcdn.com/WP0CB2A8XJS229038/6616d7248af28b0d34490d8f0e9dccbd.jpg",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "https://d6d98d1a97a06f1a20df-623577c01afe81cb5c15b33bc0b64a21.ssl.cf1.rackcdn.com/WP0CB2A8XJS229038/6616d7248af28b0d34490d8f0e9dccbd.jpg"
                    },
                     new Car {
                        Name = "Cayenne Turbo",
                        Price = 4000000M,
                        ShortDescription = "Cayenne Turbo",
                        LongDescription = "Cayenne Turbo",
                        Category = _categoryRepository.Categories.ElementAt(1),
                        ImageUrl = "https://www.porscheofocala.com/inventoryphotos/5463/wp0ah2a75jl144762/ip/1.jpg",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "https://www.porscheofocala.com/inventoryphotos/5463/wp0ah2a75jl144762/ip/1.jpg"
                    },
                    new Car {
                        Name = "Maсan Turbo",
                        Price = 4000000M,
                        ShortDescription = "Maсan Turbo",
                        LongDescription = "Maсan Turbo",
                        Category = _categoryRepository.Categories.ElementAt(2),
                        ImageUrl = "http://dmi3w0goirzgw.cloudfront.net/gallery-images/1600/406000/900/406955.jpg",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "http://dmi3w0goirzgw.cloudfront.net/gallery-images/1600/406000/900/406955.jpg"
                    },
                    new Car {
                        Name = "Macan GTS",
                        Price = 4000000M,
                        ShortDescription = "Macan GTS",
                        LongDescription = "Macan GTS",
                        Category = _categoryRepository.Categories.ElementAt(2),
                        ImageUrl = "https://d6d98d1a97a06f1a20df-623577c01afe81cb5c15b33bc0b64a21.ssl.cf1.rackcdn.com/WP0CB2A8XJS229038/6616d7248af28b0d34490d8f0e9dccbd.jpg",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "https://d6d98d1a97a06f1a20df-623577c01afe81cb5c15b33bc0b64a21.ssl.cf1.rackcdn.com/WP0CB2A8XJS229038/6616d7248af28b0d34490d8f0e9dccbd.jpg"
                    },
                    new Car {
                        Name = "Panamera Turbo",
                        Price = 4000000M,
                        ShortDescription = "Panamera Turbo",
                        LongDescription = "Panamera Turbo",
                        Category = _categoryRepository.Categories.ElementAt(3),
                        ImageUrl = "https://www.porscheofocala.com/inventoryphotos/5463/wp0ah2a75jl144762/ip/1.jpg",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "https://www.porscheofocala.com/inventoryphotos/5463/wp0ah2a75jl144762/ip/1.jpg"
                    },
                    new Car {
                        Name = "Panamera E-Hybrid",
                        Price = 4000000M,
                        ShortDescription = "Panamera E-Hybrid",
                        LongDescription = "Panamera E-Hybrid",
                        Category = _categoryRepository.Categories.ElementAt(3),
                        ImageUrl = "http://dmi3w0goirzgw.cloudfront.net/gallery-images/1600/406000/900/406955.jpg",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "http://dmi3w0goirzgw.cloudfront.net/gallery-images/1600/406000/900/406955.jpg"
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