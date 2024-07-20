using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;
using WebStore.DataAccess.Repositories.Contracts;

namespace WebStore.DataAccess.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly ApplicationDbContext _dbContextEFCore;
    internal DbSet<T> _dbSet;

    public Repository(ApplicationDbContext dbContext)
    {
        _dbContextEFCore = dbContext;
        _dbSet = _dbContextEFCore.Set<T>();
    }

    // Get
    public IEnumerable<T> GetAllRecords(string? includeProperties)
    {
        IQueryable<T> query = _dbSet;

        if (!string.IsNullOrEmpty(includeProperties))
        {
            foreach (string includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProp);
            };
        }

        return query.ToList();
    }

    public T GetFirstOrDefaultRecord(Expression<Func<T, bool>> filter, string? includeProperties = null)
    {
        IQueryable<T> query = _dbSet;
        query = query.Where(filter);

        if (!string.IsNullOrEmpty(includeProperties))
        {
            foreach (string includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProp);
            };
        }

        return query.FirstOrDefault();
    }

    // Create
    public void AddRecord(T entity)
    {
        _dbSet.Add(entity);
    }

    // Remove
    public void RemoveRecord(T entity)
    {
        _dbSet.Remove(entity);
    }

    public void RemoveRangeRecords(IEnumerable<T> entities)
    {
        _dbSet.RemoveRange(entities);
    }
}
