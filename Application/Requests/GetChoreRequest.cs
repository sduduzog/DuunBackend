using Domain;
using Mediator;

namespace Application.Requests;
public sealed record GetChoreRequest : IRequest<Chore?>;

public sealed class GetChoreRequestHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetChoreRequest, Chore?>
{

  private readonly IUnitOfWork _unitOfWork = unitOfWork;
  public async ValueTask<Chore?> Handle(GetChoreRequest request, CancellationToken cancellationToken)
  {
    return await _unitOfWork.Chores.FindOne(Guid.NewGuid());
  }
}