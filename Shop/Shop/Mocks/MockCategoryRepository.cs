using Shop.Data.Models;
using Shop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "911", Description = "The advantage can not be explained in words. " +
                    "But sometimes one look is enough. " +
                    "This is exactly the case with the 911 Turbo at the Paris Motor Show in 1974. " +
                    "The powerful appearance of this car has become a sensation." },

                    new Category { CategoryName = "Cayenne", Description = "The usual distinctive features immediately glare: " +
                    "the relief front wings, the long, " +
                    "canopy line of the bonnet with a powerful protrusion " +
                    "and the characteristic three-section air intakes " +
                    "that have become even bigger and more impressive." },

                    new Category { CategoryName = "Macan", Description = "A five-door luxury crossover utility vehicle " +
                    "(CUV) produced by Porsche from 2014. " +
                    "It is built in Leipzig, Germany. " +
                    "The Macan range includes many variants, " +
                    "including the Macan, Macan S, Macan S Diesel, Macan GTS and the Macan Turbo." },

                    new Category { CategoryName = "Panamera", Description = "The Panamera is an executive car manufactured by Porsche. " +
                    "It is front-engined and has a rear-wheel-drive layout, " +
                    "with all-wheel drive versions also available." },

                    new Category { CategoryName = "718", Description = "The new Boxster and the new Cayman continue the era of 718. " +
                    "In their 4-cylinder turbocharged turbocharged engines, " +
                    "the heart of a true wrestler struggling with many victories is struck. " +
                    "They seek to avoid standards and make a great impression. " +
                    "So it's not surprising that the names of these cars include three well-known figures " +
                    "that allow you to continue the story of the legendary model 718." }
                };
            }
        }
    }
}