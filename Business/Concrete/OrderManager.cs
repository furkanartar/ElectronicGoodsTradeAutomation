using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
        public IResult Add(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult(Messages.Added);
        }
        public IResult Update(Order order)
        {
            var result = _orderDal.Get(o => o.Id == order.Id);
            _orderDal.Update(result);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(Order order)
        {
            var result = _orderDal.Get(o => o.Id == order.Id);
            _orderDal.Delete(result);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Order> GetById(int OrderId)
        {
            return new SuccessDataResult<Order>(_orderDal.Get(c => c.Id == OrderId), Messages.Listed);
        }
    }
}