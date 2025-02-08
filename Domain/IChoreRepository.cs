namespace Domain;
public interface IChoreRepository
{
  public ValueTask<Chore?> FindOne(Guid id);
  public IEnumerable<Chore> FindAll();
  public ValueTask<Chore> Create(string title);
}