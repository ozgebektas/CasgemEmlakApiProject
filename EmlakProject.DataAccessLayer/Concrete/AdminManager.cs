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
	public class AdminManager : IAdminService
	{
		private MongoClient _mongoClient = null;
		private IMongoDatabase _mongoDatabase = null;
		private IMongoCollection<Admin> _mongoCollection = null;

		public AdminManager()
		{
			_mongoClient = new MongoClient("mongodb://localhost:27017");
			_mongoDatabase = _mongoClient.GetDatabase("CasgemEstateProjectDb");
			_mongoCollection = _mongoDatabase.GetCollection<Admin>("Admins");
		}
		public Admin Add(Admin admin)
		{
			_mongoCollection.InsertOne(admin);
			return admin;
		}

		public void Deletet(string id)
		{
			_mongoCollection.DeleteOne(x => x.AdminID == id);
		}

		public Admin GetById(string id)
		{
			return _mongoCollection.Find(x => x.AdminID == id).FirstOrDefault();
		}

		public List<Admin> GetList()
		{
			return _mongoCollection.Find(FilterDefinition<Admin>.Empty).ToList();
		}

		public void Update(string id, Admin admin)
		{
			_mongoCollection.ReplaceOne(x => x.AdminID == id, admin);
		}
	}
}
