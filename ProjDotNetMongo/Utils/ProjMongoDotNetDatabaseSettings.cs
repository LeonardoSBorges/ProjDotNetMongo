namespace ProjDotNetMongo.Utils
{
    public class ProjMongoDotNetDatabaseSettings : IProjMongoDotNetDatabaseSettings
    {
        public string PersonCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
