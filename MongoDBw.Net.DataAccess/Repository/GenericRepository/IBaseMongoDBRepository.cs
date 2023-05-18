using MongoDBw.Net.DataAccess.Entity.MongoDB;

namespace MongoDBw.Net.DataAccess.Repository.GenericRepository;

public interface IBaseMongoDBRepository<TDocument> where TDocument : IDocument
{
    IQueryable<TDocument> AsQueryable();
}