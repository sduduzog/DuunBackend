using Domain;
using Mediator;

namespace Application.Requests;

public sealed record CreateChoreRequest(string Title) : IRequest<Chore?>;

public sealed class CreateChoreRequestHandler(IUnitOfWork unitOfWork) : IRequestHandler<CreateChoreRequest, Chore?>
{

  private readonly IUnitOfWork _unitOfWork = unitOfWork;
  public async ValueTask<Chore?> Handle(CreateChoreRequest request, CancellationToken cancellationToken)
  {
    var entityEntry = _unitOfWork.Chores.Create(request.Title);
    await _unitOfWork.SaveChangesAsync(cancellationToken);
    return await _unitOfWork.Chores.FindOne(entityEntry.Entity.Id);
  }
}