using Domain;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Application;

public interface IChoreRepository
{
  public ValueTask<Chore?> FindOne(Guid id);
  public IEnumerable<Chore> FindAll();
  public EntityEntry<Chore> Create(string title);
}