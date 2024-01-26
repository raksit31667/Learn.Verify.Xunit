using Learn.Verify.Xunit.Person;

namespace Learn.Verify.Xunit.Test;

[UsesVerify]
public class PersonFinderVerifyTests
{
    [Fact]
    public Task FindPerson()
    {
        var person = PersonFinder.FindPerson();

        return Verifier.Verify(person);
    }
}