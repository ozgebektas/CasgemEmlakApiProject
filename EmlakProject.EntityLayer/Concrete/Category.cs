using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.EntityLayer.Concrete
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryID { get; set; }=string.Empty;

        [BsonElement("categoryname")]
        public string CategoryName { get; set; } = string.Empty;
        //public List<Building>? Buildings { get; set; } 
        //public List<Land>? Lands { get; set; }
        //public List<Announcement>? Announcements { get; set; }
    }
}
