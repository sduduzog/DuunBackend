using Domain;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Infrastructure;

public class ChoreRepository(ApplicationDbContext context) : IChoreRepository
{

  private readonly ApplicationDbContext _context = context;

  public async ValueTask<Chore> Create(string title)
  {
    var newChore = new Chore(Guid.Empty, title);
    await _context.Chores.AddAsync(newChore);
    return newChore;
  }

  public IEnumerable<Chore> FindAll()
  {
    return _context.Chores.AsEnumerable();
  }

  public async ValueTask<Chore?> FindOne(Guid id)
  {
    return await _context.Chores.FindAsync(id);
  }
}