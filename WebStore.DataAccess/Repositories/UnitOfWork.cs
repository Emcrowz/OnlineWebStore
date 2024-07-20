using WebStore.DataAccess.Repositories.Contracts;

namespace WebStore.DataAccess.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _dbContextEFCore;
    public UnitOfWork(ApplicationDbContext dbContext)   
    {
        _dbContextEFCore = dbContext;
    }

    public void Save()
    {
        _dbContextEFCore.SaveChanges();
    }
}
