using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }


        public IResult Add(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult(Messages.Added);
        }


        public IResult Delete(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult(Messages.Deleted);
        }
        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<Order> GetById(int id)
        {
            var result = _orderDal.Get(c => c.Id == id);
            return new SuccessDataResult<Order>(result, Messages.Geted);
        }

        public IDataResult<List<Order>> GetAll()
        {
            var result = _orderDal.GetAll();
            return new SuccessDataResult<List<Order>>(result, Messages.Listed);
        }

    }
}
