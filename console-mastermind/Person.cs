namespace console_mastermind;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person()
    {
        
    }


    public Person(string name)
    {
        FirstName = name;
    }

    public string GetNameInListForm()
    {
        return $"{LastName}, {FirstName}";
    }
}