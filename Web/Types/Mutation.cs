using Application.Requests;
using Domain;
using Mediator;

namespace Web.Types;

[MutationType]
public static class Mutation
{
  public static async Task<Chore?> CreateChore(CreateChoreRequest request, IMediator mediator) => await mediator.Send(request);

  public static async Task<Chore?> CompleteChore(CompleteChoreRequest request, IMediator mediator) => await mediator.Send(request);

  public static async Task<Chore?> ReopenChore(ReopenChoreRequest request, IMediator mediator) => await mediator.Send(request);

}