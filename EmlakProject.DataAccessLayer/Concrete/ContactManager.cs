using EmlakProject.DataAccessLayer.Abstract;
using EmlakProject.EntityLayer.Concrete;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.DataAccessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private MongoClient _mongoClient = null;
        private IMongoDatabase _mongoDatabase = null;
        private IMongoCollection<Contact> _mongoCollection = null;

        public ContactManager()
        {
            _mongoClient = new MongoClient("mongodb://localhost:27017");
            _mongoDatabase = _mongoClient.GetDatabase("CasgemEstateProjectDb");
            _mongoCollection = _mongoDatabase.GetCollection<Contact>("Contacts");
        }
        public Contact AddContact(Contact contact)
        {
            _mongoCollection.InsertOne(contact);
            return contact;
        }

        public void DeleteContact(string id)
        {
            _mongoCollection.DeleteOne(x => x.ContactID == id);
        }
    

        public Contact GetById(string id)
        {
            return _mongoCollection.Find(x => x.ContactID == id).FirstOrDefault();
        }

        public List<Contact> GetList()
        {
            return _mongoCollection.Find(FilterDefinition<Contact>.Empty).ToList();
        }

        public void Update(string id, Contact contact)
        {
            _mongoCollection.ReplaceOne(x=>x.ContactID == id, contact);
        }
    }
}
