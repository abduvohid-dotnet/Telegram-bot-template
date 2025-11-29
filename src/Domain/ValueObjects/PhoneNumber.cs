namespace Domain.ValueObjects;

public record PhoneNumber
{
  public string Value { get; }

  public PhoneNumber(string value)
  {
    if (string.IsNullOrWhiteSpace(value))
      throw new ArgumentException("Phone number is invalid");

    Value = value;
  }
}