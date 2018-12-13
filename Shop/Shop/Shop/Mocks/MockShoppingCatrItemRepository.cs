using Shop.Models;
using Shop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Mocks
{
    public class MockShoppingCartItemRepository : IShoppingCartItemRepository
    {
        public IEnumerable<ShoppingCartItem> ShoppingCartItem
        {
            get;
        }
    }
}