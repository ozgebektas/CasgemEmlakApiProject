using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.EntityLayer.Concrete
{
    public class Announcement
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string AnnouncementID { get; set; }
        public string AnnouncementName { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
