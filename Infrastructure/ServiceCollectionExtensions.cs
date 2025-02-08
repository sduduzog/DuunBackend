using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ServiceCollectionExtensions
{
  public static IServiceCollection AddInfrastructure(this IServiceCollection services)
  {
    return services
    .AddDbContextFactory<ApplicationDbContext>(options => options.UseInMemoryDatabase("db"))
    .AddTransient<IChoreRepository, ChoreRepository>()
    .AddTransient<IUnitOfWork, UnitOfWork>();
  }
}