using System.Threading.Tasks;
using Dictionary.Web.Configuration;
using MongoDB.Driver;

namespace Dictionary.Data
{
    public class MongoDbContext
    {
        public readonly IMongoDatabase MongoDb;
        private readonly Task createIndex;

        public MongoDbContext(MongoDbConnect connect)
        {
            var client = new MongoClient(connect.ConnectionString);
            MongoDb = client.GetDatabase(connect.Database);

            //createIndex = CreateIndexForCalculators();
        }

        //private async Task CreateIndexForCalculators()
        //{
        //    await CreateIndexAsync<Tv7HourlyArchive>();
        //    await CreateIndexAsync<Tv7DailyArchive>();
        //    await CreateIndexAsync<Tv7TotalArchive>();

        //    await CreateIndexAsync<Vkt7HourlyArchive>();
        //    await CreateIndexAsync<Vkt7DailyArchive>();
        //    await CreateIndexAsync<Vkt7TotalArchive>();

        //    await CreateIndexAsync<Tem106HourlyArchive>();
        //    await CreateIndexAsync<Tem106DailyArchive>();

        //    await CreateIndexAsync<VisHourlyArchive>();

        //    await CreateIndexAsync<SonoHourlyArchive>();
        //    await CreateIndexAsync<SonoMonthArchive>();
        //}
    }
}
