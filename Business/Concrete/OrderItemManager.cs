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
    public class OrderItemManager : IOrderItemService
    {
        IOrderItemDal _orderItemDal;

        public OrderItemManager(IOrderItemDal orderItemDal)
        {
            _orderItemDal = orderItemDal;
        }


        public IResult Add(OrderItem orderItemDal)
        {
            _orderItemDal.Add(orderItemDal);
            return new SuccessResult(Messages.Added);
        }


        public IResult Delete(OrderItem orderItemDal)
        {
            _orderItemDal.Delete(orderItemDal);
            return new SuccessResult(Messages.Deleted);
        }
        public IResult Update(OrderItem orderItemDal)
        {
            _orderItemDal.Update(orderItemDal);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<OrderItem> GetById(int id)
        {
            var result = _orderItemDal.Get(c => c.Id == id);
            return new SuccessDataResult<OrderItem>(result, Messages.Geted);
        }

        public IDataResult<List<OrderItem>> GetAll()
        {
            var result = _orderItemDal.GetAll();
            return new SuccessDataResult<List<OrderItem>>(result, Messages.Listed);
        }

    }
}
