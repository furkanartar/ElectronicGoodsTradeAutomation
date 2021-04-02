using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            IResult result = BusinessRules.Run(CheckIfCategoryNameExists(category.CategoryName));

            if (result != null)
            {
                return new ErrorResult();
            }

            _categoryDal.Add(category);
            return new SuccessResult(Messages.Categories.Add(category.CategoryName));
        }

        public IResult Update(Category category)
        {
            IResult result = BusinessRules.Run(CheckIfCategoryNameExists(category.CategoryName));

            if (result != null)
            {
                return result;
            }

            _categoryDal.Update(_categoryDal.Get(c => c.Id == category.Id));
            return new SuccessResult(Messages.Categories.Update(category.CategoryName));
        }

        public IResult Delete(Category category)
        {
            var result = _categoryDal.Get(c => c.Id == category.Id);
            _categoryDal.Delete(result);
            return new SuccessResult(Messages.Categories.Delete(category.CategoryName));
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<Category> GetById(int CategoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.Id == CategoryId));
        }

        public IResult CheckIfCategoryNameExists(string categoryName)
        {
            var result = _categoryDal.GetAll(category => category.CategoryName == categoryName).Any();
            if (result)
            {
                return new ErrorResult(Messages.ProductNameAlreadyExists);
            }

            return new SuccessResult();
        }
    }
}