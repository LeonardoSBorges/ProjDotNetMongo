using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProjDotNetMongo.Model
{
    public class Physical : Person
    {
        public string Cpf { get; set; }
    }
}
