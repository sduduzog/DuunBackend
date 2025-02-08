using Domain;
using Infrastructure;

public class UnitOfWork(ApplicationDbContext context) : IUnitOfWork
{
  private readonly ApplicationDbContext _context = context;
  private IChoreRepository? _chores;
  public IChoreRepository Chores => _chores ??= new ChoreRepository(_context);

  public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
  {
    return await _context.SaveChangesAsync(cancellationToken);
  }

  public void Dispose()
  {
    Dispose(true);
    GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing)
  {
    if (_disposedValue)
      return;

    if (disposing)
    {
      _context.Dispose();
    }

    _disposedValue = true;
  }
  private bool _disposedValue;
}