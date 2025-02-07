using Domain;
using Mediator;

namespace Application.Requests;

public sealed record ReopenChoreRequest(Guid Id) : IRequest<Chore?>;

public sealed class ReopenChoreRequestHandler(IUnitOfWork unitOfWork) : IRequestHandler<ReopenChoreRequest, Chore?>
{

  private readonly IUnitOfWork _unitOfWork = unitOfWork;
  public async ValueTask<Chore?> Handle(ReopenChoreRequest request, CancellationToken cancellationToken)
  {
    var chore = await _unitOfWork.Chores.FindOne(request.Id);
    chore?.Reopen();
    await _unitOfWork.SaveChangesAsync(cancellationToken);
    return chore;
  }
}