using EmlakProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.DataAccessLayer.Abstract
{
    public interface IPropertyService
    {
        List<Property> GetProperties();

        Property GetById(string id);
        Property AddProperty(Property property);

        void DeleteProperty(string id);
        void Update(string id,Property property);
    }
}
