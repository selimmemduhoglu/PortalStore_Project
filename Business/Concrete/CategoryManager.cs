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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }


        public IResult Add(Category categoryDal)
        {
            _categoryDal.Add(categoryDal);
            return new SuccessResult(Messages.Added);
        }


        public IResult Delete(Category categoryDal)
        {
            _categoryDal.Delete(categoryDal);
            return new SuccessResult(Messages.Deleted);
        }
        public IResult Update(Category categoryDal)
        {
            _categoryDal.Update(categoryDal);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<Category> GetById(int id)
        {
            var result = _categoryDal.Get(c => c.Id == id);
            return new SuccessDataResult<Category>(result, Messages.Geted);
        }

        public IDataResult<List<Category>> GetAll()
        {
            var result = _categoryDal.GetAll();
            return new SuccessDataResult<List<Category>>(result, Messages.Listed);
        }

    }
}
