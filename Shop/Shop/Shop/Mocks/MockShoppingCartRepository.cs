using Shop.Models;
using Shop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Mocks
{
    public class MockShoppingCartRepository : IShoppingCartRepository
    {
        public IEnumerable<ShoppingCart> ShoppingCart
        {
            get;
        }
    }
}