using MongoDB.Driver;
using ProjDotNetMongo.Model;
using ProjDotNetMongo.Utils;
using System.Collections.Generic;

namespace ProjDotNetMongo.Service
{
    public class PersonPhysicalService
    {
        private readonly IMongoCollection<Physical> _people;

        public PersonPhysicalService(IProjMongoDotNetDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _people = database.GetCollection<Physical>(settings.PersonCollectionName);
        }

        public List<Physical> Get() =>
            _people.Find(person => true).ToList();

        public Physical Get(string id) =>
            _people.Find<Physical>(person => person.Id == id).FirstOrDefault();

        public Physical Create(Physical person)
        {
            _people.InsertOne(person);
            return person;
        }

        public void Update(string id, Physical personIn) =>
            _people.ReplaceOne(person => person.Id == id, personIn);

        public void Remove(Physical personIn) =>
            _people.DeleteOne(person => person.Id == personIn.Id);

        public void Remove(string id) =>
            _people.DeleteOne(person => person.Id == id);
        
    }
}
