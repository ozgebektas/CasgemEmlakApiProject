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
    public class PropertyManager : IPropertyService
    {
        private MongoClient _mongoClient = null;
        private IMongoDatabase _mongoDatabase = null;
        private IMongoCollection<Property> _mongoCollection = null;

        public PropertyManager()
        {
            _mongoClient = new MongoClient("mongodb://localhost:27017");
            _mongoDatabase = _mongoClient.GetDatabase("CasgemEstateProjectDb");
            _mongoCollection = _mongoDatabase.GetCollection<Property>("Properties");
        }
        public Property AddProperty(Property property)
        {
            _mongoCollection.InsertOne(property);
            return property;
        }

        public void DeleteProperty(string id)
        {
            _mongoCollection.DeleteOne(x=>x.PropertyId== id); 
        }

        public Property GetById(string id)
        {
            return _mongoCollection.Find(x=>x.PropertyId== id).FirstOrDefault();
        }

        public List<Property> GetProperties()
        {
           return _mongoCollection.Find(FilterDefinition<Property>.Empty).ToList();
        }

        public void Update(string id, Property property)
        {
            _mongoCollection.ReplaceOne(x => x.PropertyId ==id, property);
        }
    }
}
