﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EFCategoryDal : EFEntityRepositoryBase<Category, PContext>, ICategoryDal
    {
     
    }
}
