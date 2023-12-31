﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.EntityLayer.Concrete
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CustomerID { get; set; } = ObjectId.GenerateNewId().ToString();
        [BsonElement("namesurname")]
        public string NameSurname { get; set; }
        [BsonElement("description")]
        public string Description { get; set; }
    }
}
