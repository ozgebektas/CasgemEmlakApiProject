using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.EntityLayer.Concrete
{
    public class Service
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ServiceID { get; set; }
        public string ServiceIcon { get; set; }
        public string ServiceTitle { get; set; }
        public string Description { get; set; }
    }
}
