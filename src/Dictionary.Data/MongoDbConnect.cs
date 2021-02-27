namespace Dictionary.Web.Configuration
{
    public interface IMongoDbConnect
    {
        string ConnectionString { get; set; }
        string Database { get; set; }
    }
    public class MongoDbConnect : IMongoDbConnect
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }
}
