using MongoDBw.Net.DataAccess.Attribute;

namespace MongoDBw.Net.DataAccess.Entity.MongoDB;
[BsonCollection("car")]
public class Car
{
    public CarType Type { get; set; }
    public Plate Plate { get; set; }
    public int Year { get; set; }
}