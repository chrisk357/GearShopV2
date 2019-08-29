/*using GearShopV2.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GearShopV2.Models
{
    public class ShoppingCart
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private ShoppingCart(ApplicationDbContext appDbContext)
        {
            _applicationDbContext = appDbContext;
        }
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<ApplicationDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);
            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Helmet helmet, Pant pant, Jersey jersey, int amount)
        {
            var shoppingCartItem = _applicationDbContext.ShoppingCartItems.SingleOrDefault(
                s => s..HelmetId == helmet.Id || s.Jersey.)
        }

    }
}
*/