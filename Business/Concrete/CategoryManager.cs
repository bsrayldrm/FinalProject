using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        //iş kodları
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {

            _categoryDal = categoryDal;
        }
        public List<Category> GelAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c =>c.CategoryId == categoryId);
        }

        
    }
}
