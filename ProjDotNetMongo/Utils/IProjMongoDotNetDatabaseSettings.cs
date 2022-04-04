namespace ProjDotNetMongo.Utils
{
    public interface IProjMongoDotNetDatabaseSettings
    {
        string PersonCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }

    }
}
