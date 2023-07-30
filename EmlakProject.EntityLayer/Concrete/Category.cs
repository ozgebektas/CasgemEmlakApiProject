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
        //public Category()
        //{
        //    this.AnnouncementId=new HashSet<string>();
        //    this.Announcements=new HashSet<Announcement>();
        //}
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryID { get; set; } =  ObjectId.GenerateNewId().ToString();

        [BsonElement("categoryname")]
        public string CategoryName { get; set; } 

        public ICollection<string>? AnnouncementId { get; set; }
        //public ICollection<Announcement>? Announcements { get; set; }

    }
}
