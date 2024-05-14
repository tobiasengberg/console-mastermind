namespace console_mastermind.Tests;

public class PersonTests
{
    [Fact]
    public void GetNameInListFormTest()
    {
        Person testPerson = new Person();
        testPerson.FirstName = "Dorothy";
        testPerson.LastName = "Hollingsworth";

        string expected = "Hollingsworth, Dorothy";
        string actual = testPerson.GetNameInListForm();
        
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("Sid", "Read", "Read, Sid")]
    [InlineData("Tommy", "Smith", "Smith, Tommy")]
    public void GetNameInListFormTheoryTest(string firstName, string lastName, string expected)
    {
        Person testPerson = new Person();
        testPerson.FirstName = firstName;
        testPerson.LastName = lastName;
        
        string actual = testPerson.GetNameInListForm();
        
        Assert.Equal(expected, actual);
    }
    
}