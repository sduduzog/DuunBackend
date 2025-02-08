namespace Domain;
public interface IUnitOfWork : IDisposable
{
  IChoreRepository Chores { get; }

  Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}