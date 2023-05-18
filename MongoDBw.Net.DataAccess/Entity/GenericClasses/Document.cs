using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBw.Net.DataAccess.Entity.MongoDB;

public abstract class Document : IDocument
{
    [BsonElement("id")]
    [BsonRepresentation(BsonType.String)]
    public Guid Id { get; set; }

    public DateTime CreateDate { get; set; }
    public DateTime UpdateDate { get; set; }
}