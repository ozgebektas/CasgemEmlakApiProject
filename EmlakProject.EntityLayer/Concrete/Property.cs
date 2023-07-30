using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.EntityLayer.Concrete
{
    public class Property
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string PropertyId { get; set; } = ObjectId.GenerateNewId().ToString();
        [BsonElement("propertyname")]
        public string PropertName { get; set; }
        [BsonElement("adress")]
        public string Adress { get; set; }
        [BsonElement("count")]
        public decimal Count { get; set; }
        [BsonElement("image")]
        public string Image { get; set; }
        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("bedcount")]
        public int BedCount { get; set; }
        [BsonElement("bathcount")]
        public int BathCount { get; set; }
        [BsonElement("description")]
        public string Description { get; set; }
    }
}
