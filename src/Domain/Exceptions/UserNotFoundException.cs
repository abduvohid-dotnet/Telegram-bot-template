namespace Domain.Exceptions;

public class UserNotFoundException : Exception
{
    public UserNotFoundException(long id) : base($"User not found: {id}") { }
}
