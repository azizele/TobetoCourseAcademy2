using Business.Abstracts;
using DataAccess.Abstracts;
using DataAccess.Concrete.EntityFramework;
using Entities.Concretes;
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
        public IList<Category> GetAll()
        {
           EfCategoryDal categoryDal = new EfCategoryDal(); 
            return categoryDal.GetList();
        }
    }
}
