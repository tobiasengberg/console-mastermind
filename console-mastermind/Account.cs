namespace console_mastermind;

public class Account
{
    

    public Person AccountHolder { get; set; }
    public int AccountNumber { get; set; }
    public DateTime RegistrationDate { get; set; }

    public Account()
    {
        RegistrationDate = DateTime.Now;
    }
    public Account(string name)
    {
        AccountHolder = new Person(name);
    }

    public Account(int accountNumber)
    {
        // this = instance of Account ... new Account()
        this.AccountNumber = accountNumber;
    }

    public Person ReturnHolder()
    {
        return AccountHolder;
    }
}