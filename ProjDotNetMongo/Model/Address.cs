using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProjDotNetMongo.Model
{
    public class Address
    {
        public string Street { get; set; }
        public string Number { get; set; }

    }
}
