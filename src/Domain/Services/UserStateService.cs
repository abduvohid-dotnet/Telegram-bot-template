namespace Domain.Services;

using Domain.Entities;
using Domain.Enums;

public class UserStateService
{
  public UserState NextState(UserState current)
  {
    return current switch
    {
      UserState.None => UserState.WaitingForPhone,
      UserState.WaitingForPhone => UserState.WaitingForFeedback,
      _ => UserState.None
    };
  }
}