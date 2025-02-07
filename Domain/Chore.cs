using System.Data.Common;
using Microsoft.VisualBasic;

namespace Domain;

public class Chore(Guid Id, string Title, bool Completed = false)
{
  public Guid Id { get; private set; } = Id;
  public string Title { get; private set; } = Title;
  public bool Completed { get; private set; } = Completed;
  public void Complete()
  {
    Completed = true;
  }
  public void Reopen()
  {
    Completed = false;
  }
}
