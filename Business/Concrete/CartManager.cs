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
        public List<Cart> _carts { get; set; }

        public CartManager()
        {
            _carts = new List<Cart>();
        }

        public IResult AddToCartItem(Product product)
        {
            var item = _carts.Where(item => item.Product.Id == product.Id).FirstOrDefault();

            if (item != null)
            {
                item.Quantity++;
            }
            else
            {
                _carts.Add(new Cart() { Product = product, Quantity = 1 });
            }

            return new SuccessResult("Sepete eklendi");
        }

        public IResult RemoveToCartItem(Product product)
        {
            var item = _carts.Where(item => item.Product.Id == product.Id).First();
            _carts.Remove(item);
            return new SuccessResult("Sepetten çıkarıldı");
        }

        public IDataResult<List<Cart>> GetCart()
        {
            return new SuccessDataResult<List<Cart>>(_carts);
        }
    }
}