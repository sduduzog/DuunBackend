using Domain;
using Mediator;

namespace Application.Requests;

public sealed record CreateChoreRequest(string Title) : IRequest<Chore?>;

public sealed class CreateChoreRequestHandler(IUnitOfWork unitOfWork) : IRequestHandler<CreateChoreRequest, Chore?>
{

  private readonly IUnitOfWork _unitOfWork = unitOfWork;
  public async ValueTask<Chore?> Handle(CreateChoreRequest request, CancellationToken cancellationToken)
  {
    var newChore = await _unitOfWork.Chores.Create(request.Title);
    var count = await _unitOfWork.SaveChangesAsync(cancellationToken);
    if (count > 0)
      return newChore;
    return null;
  }
}