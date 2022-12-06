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
    public class SKUManager : ISKUService
    {
        ISKUDal _skuDal;

        public SKUManager(ISKUDal skuDal)
        {
            _skuDal = skuDal;
        }


        public IResult Add(SKU sku)
        {
            _skuDal.Add(sku);
            return new SuccessResult(Messages.Added);
        }


        public IResult Delete(SKU sku)
        {
            _skuDal.Delete(sku);
            return new SuccessResult(Messages.Deleted);
        }
        public IResult Update(SKU sku)
        {
            _skuDal.Update(sku);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<SKU> GetById(int id)
        {
            var result = _skuDal.Get(c => c.Id == id);
            return new SuccessDataResult<SKU>(result, Messages.Geted);
        }

        public IDataResult<List<SKU>> GetAll()
        {
            var result = _skuDal.GetAll();
            return new SuccessDataResult<List<SKU>>(result, Messages.Listed);
        }
      
    }
}
