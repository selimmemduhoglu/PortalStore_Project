using Castle.Core.Resource;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.DTOs;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EFCustomerDal : EFEntityRepositoryBase<Customer, PContext>, ICustomerDal
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
