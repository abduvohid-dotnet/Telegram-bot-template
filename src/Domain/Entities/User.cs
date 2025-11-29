namespace Domain.Entities;

public class User
{
  public long Id { get; private set; }
  public string? Username { get; private set; }
  public DateTime CreatedAt { get; private set; }

  public User(long id, string? username)
  {
    Id = id;
    Username = username;
    CreatedAt = DateTime.UtcNow;
  }
}
