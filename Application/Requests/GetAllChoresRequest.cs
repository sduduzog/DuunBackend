using System.Collections;
using Domain;
using Mediator;

namespace Application.Requests;
public sealed record GetAllChoresRequest : IRequest<IEnumerable<Chore>>;

public sealed class GetAllChoresRequestHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetAllChoresRequest, IEnumerable<Chore>>
{

  private readonly IUnitOfWork _unitOfWork = unitOfWork;
  public ValueTask<IEnumerable<Chore>> Handle(GetAllChoresRequest request, CancellationToken cancellationToken)
  {
    return ValueTask.FromResult(_unitOfWork.Chores.FindAll());
  }
}