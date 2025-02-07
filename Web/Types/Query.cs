using Domain;
using Application;
using Mediator;

namespace Web.Types;

[QueryType]
public static class Query
{
    public static async Task<Book> GetBook(IMediator mediator, CancellationToken cancellationToken)
    {
        return await mediator.Send(new GetBookQuery(), cancellationToken);
    }

    public static async Task<Chore?> GetChore(IMediator mediator, CancellationToken cancellationToken)
    {
        return await mediator.Send(new GetChoreQuery(), cancellationToken);
    }
}
