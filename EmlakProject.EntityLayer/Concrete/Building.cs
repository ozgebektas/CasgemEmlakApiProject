using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.EntityLayer.Concrete
{
    public class Building
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BuildingID { get; set; }
        public string BuildingName { get; set; }
        public string BuildingLayer { get; set; }
        public string BuildingAge { get; set; }
        public int Price { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public DateTime NoticeDate { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
