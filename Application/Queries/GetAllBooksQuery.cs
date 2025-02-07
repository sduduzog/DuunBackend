// using Mediator;
// using Microsoft.EntityFrameworkCore;

// namespace Application;

// public sealed record GetAllBooksQuery : IQuery<IEnumerable<Book>>;

// public sealed class GetAllBooksQueryHandler : IQueryHandler<GetAllBooksQuery, IEnumerable<Book>>
// {

//   private readonly IDbContextFactory<IApplicationDbContext> _dbContextfactory;
//   public GetAllBooksQueryHandler(IDbContextFactory<IApplicationDbContext> dbContextFactory)
//   {
//     _dbContextfactory = dbContextFactory;
//   }
//   public async ValueTask<IEnumerable<Book>> Handle(GetAllBooksQuery query, CancellationToken cancellationToken)
//   {
//     using var dbContext = _dbContextfactory.CreateDbContext();
//     return await ValueTask.FromResult(new List<Book>());
//   }
// }