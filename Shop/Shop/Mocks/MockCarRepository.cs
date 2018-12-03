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
                        ImageUrl = "https://www.cars.co.za/carimages_gen/Porsche-911/Porsche-911-Carrera-4-GTS_Pors9117fc14l.jpg",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "https://www.cars.co.za/carimages_gen/Porsche-911/Porsche-911-Carrera-4-GTS_Pors9117fc14l.jpg"
                    },
                    new Car {
                        Name = "911 Turbo",
                        Price = 4000000M,
                        ShortDescription = "911 Turbo",
                        LongDescription = "911 Turbo",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://i.ytimg.com/vi/I2Js7_BcBdY/maxresdefault.jpg",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "https://i.ytimg.com/vi/I2Js7_BcBdY/maxresdefault.jpg"
                    },
                    new Car {
                        Name = "911 GT2 RS",
                        Price = 4000000M,
                        ShortDescription = "911 GT2 RS",
                        LongDescription = "911 GT2 RS",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://images.hgmsites.net/hug/2018-porsche-911-carrera_100613414_h.jpg",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "https://images.hgmsites.net/hug/2018-porsche-911-carrera_100613414_h.jpg"
                    },
                     new Car {
                        Name = "Cayenne Turbo",
                        Price = 4000000M,
                        ShortDescription = "Cayenne Turbo",
                        LongDescription = "Cayenne Turbo",
                        Category = _categoryRepository.Categories.ElementAt(1),
                        ImageUrl = "http://ru.gpluxurycarhire.com/images/vehicule/Porsche-Cayenne_Turbo-2018-1280-46QN.jpg",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "http://ru.gpluxurycarhire.com/images/vehicule/Porsche-Cayenne_Turbo-2018-1280-46QN.jpg"
                    },
                    new Car {
                        Name = "Maсan Turbo",
                        Price = 4000000M,
                        ShortDescription = "Maсan Turbo",
                        LongDescription = "Maсan Turbo",
                        Category = _categoryRepository.Categories.ElementAt(2),
                        ImageUrl = "http://www.webaraba.com/wp-content/uploads/2014/10/techart_porsche_macan_turbo.png",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "http://www.webaraba.com/wp-content/uploads/2014/10/techart_porsche_macan_turbo.png"
                    },
                    new Car {
                        Name = "Macan GTS",
                        Price = 4000000M,
                        ShortDescription = "Macan GTS",
                        LongDescription = "Macan GTS",
                        Category = _categoryRepository.Categories.ElementAt(2),
                        ImageUrl = "http://cdn.autotrade.com.my/news/wp-content/uploads/2016/06/20122529/Porsche-Macan-GTS-Rear-Malaysia-2016.jpg",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "http://cdn.autotrade.com.my/news/wp-content/uploads/2016/06/20122529/Porsche-Macan-GTS-Rear-Malaysia-2016.jpg"
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
                        ImageUrl = "https://porschenewsroom.s3.amazonaws.com/porsche_newsroom/produkte/panamera/panamera-4-e-hybrid/b-p16_0786jpg/c1142fb2-f33c-428a-b61f-ddadfccfa1ba_teaser_original_720x1_5.jpg",
                        InStock = true,
                        IsPreferredCar = true,
                        ImageThumbnailUrl = "https://porschenewsroom.s3.amazonaws.com/porsche_newsroom/produkte/panamera/panamera-4-e-hybrid/b-p16_0786jpg/c1142fb2-f33c-428a-b61f-ddadfccfa1ba_teaser_original_720x1_5.jpg"
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
