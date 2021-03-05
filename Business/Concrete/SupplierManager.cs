using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class SupplierManager : ISupplierService
    {
        private ISupplierDal _supplierDal;

        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
        }

        public IResult Add(Supplier supplier)
        {
            _supplierDal.Add(supplier);
            return new SuccessResult(Messages.Added);
        }
        public IResult Update(Supplier supplier)
        {
            var result = _supplierDal.Get(s => s.Id == supplier.Id);
            _supplierDal.Update(result);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(Supplier supplier)
        {
            var result = _supplierDal.Get(s => s.Id == supplier.Id);
            _supplierDal.Delete(result);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Supplier>> GetAll()
        {
            return new SuccessDataResult<List<Supplier>>(_supplierDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Supplier> GetById(int SupplierId)
        {
            return new SuccessDataResult<Supplier>(_supplierDal.Get(s => s.Id == SupplierId), Messages.Listed);
        }
    }
}