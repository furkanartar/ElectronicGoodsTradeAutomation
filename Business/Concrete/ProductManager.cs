using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Business;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        //[CacheRemoveAspect("IProductService.Get")]
        public IResult Add(Product product)
        {
            IResult result = BusinessRules.Run();

            if (result != null)
            {
                return result;
            }

            product.Enabled = true;
            _productDal.Add(product);
            return new SuccessResult(Messages.Products.Add(product.ProductName));
        }

        //[CacheRemoveAspect("IProductService.Get")]
        public IResult Update(Product product)
        {
            product.Enabled = true;
            _productDal.Update(product);
            return new SuccessResult(Messages.Products.Update(product.ProductName));
        }

        //[CacheRemoveAspect("IProductService.Get")]
        public IResult Delete(Product product)
        {
            product.Enabled = false;
            _productDal.Update(product);
            return new SuccessResult(Messages.Products.Delete(product.ProductName));
        }

        //[CacheAspect]
        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll().Where(product =>product.Enabled == true).ToList(), "İşlem başarılı");
        }

        //[CacheAspect]
        public IDataResult<Product> GetById(int ProductId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.Id == ProductId && p.Enabled == true));
        }
    }
}