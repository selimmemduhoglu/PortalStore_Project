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
    public class AddressManager : IAddressService
    {
        IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public IResult Add(Address address)
        {
            _addressDal.Add(address);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Address address)
        {
            _addressDal.Delete(address);
            return new SuccessResult(Messages.Deleted);
        }
        public IResult Update(Address address)
        {
            _addressDal.Update(address);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<Address> GetById(int id)
        {
            var result = _addressDal.Get(c => c.Id == id);
            return new SuccessDataResult<Address>(result, Messages.Geted);
        }

        public IDataResult<List<Address>> GetAll()
        {
            var result = _addressDal.GetAll();
            return new SuccessDataResult<List<Address>>(result, Messages.Listed);
        }


    }
}
