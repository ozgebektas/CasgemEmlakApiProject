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
        Category GetById(string id);
        Category Add(Category category);

        void Delete(string id);
        void Update(string id, Category category);

    }
}
