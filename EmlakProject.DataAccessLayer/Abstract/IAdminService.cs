using EmlakProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.DataAccessLayer.Abstract
{
    public interface IAdminService
    {
        List<Admin> GetList();

        Admin GetByIdAdmin(string categoryId);
        Admin AddAdmin(Category category);
        void UpdateAdmin(string id, Category category);
        void Delete(string id);
    }
}
