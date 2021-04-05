using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using FormUI.Shared;
using System.Collections.Generic;
using System.Linq;
using FluentValidation.Internal;

namespace Business.Concrete
{
    public class CartManager : ICartService
    {
        //private List<Cart> _cart;

        private List<Cart> _cart = new List<Cart>
        {
            new Cart
            {
                Product = new Product() {Id = 5, ProductName = "Tset"},
                Quantity = 1
            }

        };

        public IResult AddToCartItem(Product product)
        {
            var item = _cart.Where(item => item.Product.Id == product.Id).FirstOrDefault();

            if (item != null)
            {
                item.Quantity++;
            }
            else
            {
                _cart.Add(new Cart() { Product = product, Quantity = 1 });
            }

            return new SuccessResult("Sepete eklendi");
        }

        public IResult RemoveToCartItem(Product product)
        {
            var item = _cart.Where(item => item.Product.Id == product.Id).First();
            _cart.Remove(item);
            return new SuccessResult("Sepetten çıkarıldı");
        }

        public IDataResult<List<Cart>> GetCart()
        {
            var cart = _cart;
            return new SuccessDataResult<List<Cart>>(cart);
        }
    }
}