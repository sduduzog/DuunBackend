using Application;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Infrastructure;

public class ChoreRepository(ApplicationDbContext context) : IChoreRepository
{

  private readonly ApplicationDbContext _context = context;

  public EntityEntry<Chore> Create(string title)
  {
    var newChore = new Chore(Guid.Empty, title);
    return _context.Chores.Add(newChore);
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