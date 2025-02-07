using Domain;

namespace Application;

public interface IChoreRepository
{
  public Task<Chore?> FindOne();
}