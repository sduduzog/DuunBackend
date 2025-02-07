using Application;
using Domain;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

public class ChoreRepository(ApplicationDbContext context) : IChoreRepository
{

  private readonly ApplicationDbContext _context = context;

  public Task<Chore?> FindOne()
  {
    return _context.Chores.FirstOrDefaultAsync();
  }

}