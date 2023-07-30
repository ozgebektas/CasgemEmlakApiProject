using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.EntityLayer.Concrete
{

    //[BsonIgnoreExtraElements]
    public class Announcement
    {
     
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string AnnouncementID { get; set; } = ObjectId.GenerateNewId().ToString();
        [BsonElement("Announcementname")]
        public string AnnouncementName { get; set; }
        [BsonElement("Price")]
        public int Price { get; set; }
        [BsonElement("date")]
        public DateTime Date { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("adress")]
        public string Adress { get; set; }


        //[BsonRepresentation(BsonType.ObjectId)]
        //public string? CategoryId { get; set; }
    }
}
