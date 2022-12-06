﻿using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAddressService
    {
        IResult Add(Address address);
        IResult Update(Address address);
        IResult Delete(Address address);
        IDataResult<Address> GetById(int id);
        IDataResult<List<Address>> GetAll();

    }
}
