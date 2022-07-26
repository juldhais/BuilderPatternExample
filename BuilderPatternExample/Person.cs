namespace BuilderPatternExample;

public class Person
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public int Age { get; set; }
    public Address? Address { get; set; }
    public List<Phone>? Phones { get; set; }
}

public class Address
{
    public string? Line { get; set; }
    public string? City { get; set; }
    public string? Province { get; set; }
    public string? PostCode { get; set; }
}

public class Phone
{
    public PhoneType PhoneType { get; set; }
    public string? PhoneNumber { get; set; }
}

public enum PhoneType
{
    Home,
    Mobile
}