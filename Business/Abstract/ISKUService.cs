using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISKUService
    {
        IResult Add(SKU sku);
        IResult Update(SKU sku);
        IResult Delete(SKU sku);
        IDataResult<SKU> GetById(int id);
        IDataResult<List<SKU>> GetAll();

    }
}
