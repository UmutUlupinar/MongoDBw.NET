namespace MongoDBw.Net.DataAccess.Attribute;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class BsonCollectionAttribute : System.Attribute
{
    public string? CollectionName { get; }

    public BsonCollectionAttribute(string? collectionName)
    {
        CollectionName = collectionName;
    }
}