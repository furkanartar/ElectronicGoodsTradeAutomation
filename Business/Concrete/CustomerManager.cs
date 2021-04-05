using System;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Business;
using Core.Utilities.Helper;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.Customers.Add(customer.FirstName, customer.LastName));
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.Customers.Update(customer.FirstName, customer.LastName));
        }

        public IResult Delete(Customer customer)
        {
            customer.Enabled = false;
            _customerDal.Update(customer);
            return new SuccessResult("Başarıyla silindi.");
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll().Where(customer => customer.Enabled == true).ToList());
        }

        public IDataResult<Customer> GetById(int CustomerId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(customer => customer.Id == CustomerId && customer.Enabled == true));
        }
    }
}