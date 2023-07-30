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
    public class AnnouncementManager : IAnnouncementService
    {
        private MongoClient _mongoClient = null;
        private IMongoDatabase _mongoDatabase = null;
        private IMongoCollection<Announcement> _mongoCollection = null;
        public AnnouncementManager()
        {
            _mongoClient = new MongoClient("mongodb://localhost:27017");
            _mongoDatabase = _mongoClient.GetDatabase("CasgemEstateProjectDb");
            _mongoCollection = _mongoDatabase.GetCollection<Announcement>("Announcements");
        }
        public Announcement AddAnnouncement(Announcement announcement)
        {
            _mongoCollection.InsertOne(announcement);
            return announcement;
        }

        public void DeleteAnnouncement(string id)
        {
            _mongoCollection.DeleteOne(x => x.AnnouncementID == id);
        }

        public Announcement GetById(string id)
        {
            return _mongoCollection.Find(x => x.AnnouncementID == id).FirstOrDefault();
        }

        public List<Announcement> GetList()
        {
            return _mongoCollection.Find(FilterDefinition<Announcement>.Empty).ToList();
        }

        public void UpdateAnnouncement(string id, Announcement announcement)
        {
            _mongoCollection.ReplaceOne(x => x.AnnouncementID == id, announcement);
        }
    }
}
