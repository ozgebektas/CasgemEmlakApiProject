using EmlakProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.DataAccessLayer.Abstract
{
    public interface ICustomerService
    {
        Customer Save(Customer customer);
        Customer GetCustomer(string customerId);

        List<Customer> GetAll();
        void Delete (string customerId);
    }
}
