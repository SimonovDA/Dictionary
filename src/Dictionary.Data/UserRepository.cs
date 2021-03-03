using System.Threading.Tasks;
using Dictionary.Data.Models;
using MongoDB.Driver;

namespace Dictionary.Data
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(MongoDbContext context) : base(context)
        {

        }

        public override async Task<User> Create(User value)
        {
            var collection = Context.MongoDb.GetCollection<User>(nameof(User));

            var filterBuilder = Builders<User>.Filter;
            var filter = filterBuilder.Eq(x => x.Name, value.Name) & filterBuilder.Eq(x => x.Age, value.Age);

            var user = collection.Find(filter).ToList();
            if (user.Count != 0)
                return value;

            await collection.InsertOneAsync(value);
            return value;
        }
    }
}
