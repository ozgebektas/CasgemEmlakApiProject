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
    public class CategoryManager : ICategoryService
    {
        private MongoClient _mongoClient = null;
        private IMongoDatabase _mongoDatabase = null;
        private IMongoCollection<Category> _mongoCollection = null;

        public CategoryManager()
        {
            _mongoClient = new MongoClient("mongodb://localhost:27017");
            _mongoDatabase = _mongoClient.GetDatabase("CasgemEstateProjectDb");
            _mongoCollection = _mongoDatabase.GetCollection<Category>("Categories");
        }
        public Category Add(Category category)
        {
            _mongoCollection.InsertOne(category);
            return category;
        }

        public void Delete(string id)
        {
            _mongoCollection.DeleteOne(x => x.CategoryID == id);
        }

        public Category GetById(string id)
        {
            return _mongoCollection.Find(x => x.CategoryID == id).FirstOrDefault();
        }

        public List<Category> GetList()
        {
            return _mongoCollection.Find(FilterDefinition<Category>.Empty).ToList();
        }

        public void Update(string id, Category category)
        {
            _mongoCollection.ReplaceOne(x => x.CategoryID == id, category);
        }
    }
}
