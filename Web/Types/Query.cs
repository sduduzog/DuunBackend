using Domain;
using Mediator;
using Application.Requests;

namespace Web.Types;

[QueryType]
public static class Query
{
    public static async Task<Chore?> GetChore(IMediator mediator, CancellationToken cancellationToken) =>
        await mediator.Send(new GetChoreRequest(), cancellationToken);

    public static async ValueTask<IEnumerable<Chore>> GetChores(IMediator mediator, CancellationToken cancellationToken) =>
             await mediator.Send(new GetAllChoresRequest(), cancellationToken);

}
