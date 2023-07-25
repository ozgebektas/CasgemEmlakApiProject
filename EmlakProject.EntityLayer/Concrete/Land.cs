using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.EntityLayer.Concrete
{
    public class Land
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string LandID { get; set; }
        public string LandName { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public DateTime NoticeDate { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
