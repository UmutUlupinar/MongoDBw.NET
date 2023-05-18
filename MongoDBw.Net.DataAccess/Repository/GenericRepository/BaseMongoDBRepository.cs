using MongoDBw.Net.DataAccess.Entity.MongoDB;

namespace MongoDBw.Net.DataAccess.Repository.GenericRepository;

public class BaseMongoDBRepository<TDocument> : IBaseMongoDBRepository<TDocument> where TDocument : IDocument
{
    public IQueryable<TDocument> AsQueryable()
    {
        throw new NotImplementedException();
    }
}