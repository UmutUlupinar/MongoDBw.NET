using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBw.Net.DataAccess.Entity.MongoDB;

public interface IDocument
{
    [BsonId]
    [BsonElement("id")]
    public Guid Id { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime UpdateDate { get; set; }
}