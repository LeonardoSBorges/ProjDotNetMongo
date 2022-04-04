﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProjDotNetMongo.Model
{
    public abstract class Person 
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
    }
}
