using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Dictionary.Data.Models
{
    public abstract record BaseEntry
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}
