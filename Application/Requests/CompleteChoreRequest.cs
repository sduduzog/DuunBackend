using Domain;
using Mediator;

namespace Application.Requests;

public sealed record CompleteChoreRequest(Guid Id) : IRequest<Chore?>;

public sealed class CompleteChoreRequestHandler(IUnitOfWork unitOfWork) : IRequestHandler<CompleteChoreRequest, Chore?>
{

  private readonly IUnitOfWork _unitOfWork = unitOfWork;
  public async ValueTask<Chore?> Handle(CompleteChoreRequest request, CancellationToken cancellationToken)
  {
    var chore = await _unitOfWork.Chores.FindOne(request.Id);
    chore?.Complete();
    await _unitOfWork.SaveChangesAsync(cancellationToken);
    return chore;
  }
}