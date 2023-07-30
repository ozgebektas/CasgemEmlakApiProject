using EmlakProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.DataAccessLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> GetList();

        Contact GetById(string id);
        Contact AddContact(Contact contact);

        void DeleteContact(string id);
        void Update(string id, Contact contact);
    }
}
