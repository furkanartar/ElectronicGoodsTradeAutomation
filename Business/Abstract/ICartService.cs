using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using FormUI.Shared;

namespace Business.Abstract
{
    public interface ICartService
    {
        public IResult AddToCartItem(Product product);
        public IResult RemoveToCartItem(Product product);
        public IDataResult<List<Cart>> GetCart();
    }
}