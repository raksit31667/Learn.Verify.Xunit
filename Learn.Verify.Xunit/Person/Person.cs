namespace Learn.Verify.Xunit.Person;

public class Person
{
    public string Id { get; set; }
    public Title Title { get; set; }
    public string GivenNames { get; set; }
    public string FamilyName { get; set; }
    public string Spouse { get; set; }
    public string[] Children { get; set; }
    public Address Address { get; set; }
}

public class Address
{
    public string Street { get; set; }
    public string Country { get; set; }
}

public enum Title
{
    Mr,
    Mrs
}