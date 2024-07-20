using System.Linq.Expressions;

namespace WebStore.DataAccess.Repositories.Contracts;

public interface IRepository<T> where T : class
{
    IEnumerable<T> GetAllRecords(string? includeProperties);
    T GetFirstOrDefaultRecord(Expression<Func<T, bool>> filter, string? includeProperties = null);
    void AddRecord(T entity);
    void RemoveRecord(T entity);
    void RemoveRangeRecords(IEnumerable<T> entities);
}
