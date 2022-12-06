using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderItemService
    {
        IResult Add(OrderItem orderItem);
        IResult Update(OrderItem orderItem);
        IResult Delete(OrderItem orderItem);
        IDataResult<OrderItem> GetById(int id);
        IDataResult<List<OrderItem>> GetAll();
    }
}
