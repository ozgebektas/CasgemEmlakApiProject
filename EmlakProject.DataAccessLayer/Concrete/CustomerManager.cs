using EmlakProject.DataAccessLayer.Abstract;
using EmlakProject.EntityLayer.Concrete;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.DataAccessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private MongoClient _mongoClient = null;
        private IMongoDatabase _mongoDatabase = null;
        private IMongoCollection<Customer> _mongoCollection = null;

        public CustomerManager()
        {
            _mongoClient=new MongoClient("mongodb://localhost:27017");
            _mongoDatabase = _mongoClient.GetDatabase("CasgemEstateProjectDb");
            _mongoCollection = _mongoDatabase.GetCollection<Customer>("Customers");
        }
        public void Delete(string customerId)
        {
           _mongoCollection.DeleteOne(x=>x.CustomerID==customerId);
          
        }

        public List<Customer> GetAll()
        {
           return _mongoCollection.Find(FilterDefinition<Customer>.Empty).ToList();
        }

        public Customer GetCustomer(string customerId)
        {
            return _mongoCollection.Find(x => x.CustomerID == customerId).FirstOrDefault();
        }

        public Customer Save(Customer customer)
        {
           var value=_mongoCollection.Find(x=>x.CustomerID== customer.CustomerID).FirstOrDefault();
           if(value==null) 
            {
                _mongoCollection.InsertOne(customer);
            }
            else
            {
                _mongoCollection.ReplaceOne(x=>x.CustomerID==customer.CustomerID, customer);
            }
           return customer;
        }
    }
}
