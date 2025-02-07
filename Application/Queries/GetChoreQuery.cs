using Domain;
using Mediator;

public sealed record GetChoreQuery : IQuery<Chore?>;

public sealed class GetChoreQueryHandler(IUnitOfWork unitOfWork) : IQueryHandler<GetChoreQuery, Chore?>
{

  private readonly IUnitOfWork _unitOfWork = unitOfWork;
  public async ValueTask<Chore?> Handle(GetChoreQuery query, CancellationToken cancellationToken)
  {
    return await _unitOfWork.Chores.FindOne();
  }
}