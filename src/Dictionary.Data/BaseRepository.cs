using System;
using System.Linq;
using System.Threading.Tasks;
using Dictionary.Data.Abstraction;
using Dictionary.Data.Models;
using MongoDB.Driver;

namespace Dictionary.Data
{
    public abstract class BaseRepository<T> : IRepository<T>
        where T : BaseEntry
    {
        protected readonly MongoDbContext Context;

        protected BaseRepository(MongoDbContext context)
        {
            Context = context;
        }
        public virtual async Task<T> Get(string id)
        {
            var collection = Context.MongoDb.GetCollection<T>(typeof(T).Name);
            T user;
            try
            {
                user = collection.AsQueryable().FirstOrDefault(x => x.Id == id);
            }
            catch
            {
                return null;
            }


            return user;
        }

        public virtual Task<T> Create(T value)
        {
            throw new NotImplementedException();
        }

        public virtual Task Delete(T value)
        {
            throw new NotImplementedException();
        }

        public virtual Task Update(T value)
        {
            throw new NotImplementedException();
        }
    }
}
