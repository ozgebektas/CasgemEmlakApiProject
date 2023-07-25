using EmlakProject.DataAccessLayer.Abstract;
using EmlakProject.EntityLayer.Concrete;
using EmlakProject.EntityLayer.DbSettings;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.DataAccessLayer.Concrete
{
    public class AdminService:IAdminService
    {
        private readonly IMongoCollection<Admin> _categories;
        public AdminService(IDbSetting dbSetting, IMongoClient mongoClient)
        {
            var db = mongoClient.GetDatabase(dbSetting.DatabaseName);
            _categories = db.GetCollection<Admin>(dbSetting.AdminCollectionName);
        }
        public Admin AddAdmin(Admin admin)
        {
            _categories.InsertOne(category);
            return category;
        }

        public void Delete(string id)
        {
            _categories.DeleteOne(x => x.CategoryID == id);
        }

        public Category GetByIdCategory(string categoryId)
        {
            return _categories.Find(x => x.CategoryID == categoryId).FirstOrDefault();
        }

        public List<Category> GetList()
        {
            return _categories.Find(x => true).ToList();
        }

        public void UpdateCategory(string id, Category category)
        {
            _categories.ReplaceOne(x => x.CategoryID == id, category);
        }
    }
}
}
