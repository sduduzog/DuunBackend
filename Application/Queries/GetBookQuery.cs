using Domain;
using Mediator;

namespace Application;
public sealed record GetBookQuery : IQuery<Book>;

public sealed class GetBookQueryHandler : IQueryHandler<GetBookQuery, Book>
{
  public async ValueTask<Book> Handle(GetBookQuery query, CancellationToken cancellationToken)
  {
    return await ValueTask.FromResult(new Book("Tree", new Author("Charles")));
  }
}