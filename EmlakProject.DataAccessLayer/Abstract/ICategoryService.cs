using EmlakProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.DataAccessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();

        Category GetByIdCategory(string categoryId);
        Category AddCategory(Category category);
        void UpdateCategory(string id, Category category);
        void Delete(string id);
    }
}
