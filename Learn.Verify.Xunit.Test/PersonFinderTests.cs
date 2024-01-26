using Learn.Verify.Xunit.Person;

namespace Learn.Verify.Xunit.Test;

public class PersonFinderTests
{
    [Fact]
    public void FindPerson()
    {
        var person = PersonFinder.FindPerson();
        
        Assert.Equal("ebced679-45d3-4653-8791-3d969c4a986c", person.Id);
        Assert.Equal(Title.Mr, person.Title);
        Assert.Equal("John", person.GivenNames);
        Assert.Equal("Smith", person.FamilyName);
        Assert.Equal("Sam", person.Children[0]);
        Assert.Equal("Mary", person.Children[1]);
    }
}