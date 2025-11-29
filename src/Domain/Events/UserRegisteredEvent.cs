namespace Domain.Events;

using Domain.Entities;

public class UserRegisteredEvent
{
  public User User { get; }

  public UserRegisteredEvent(User user)
  {
    User = user;
  }
}