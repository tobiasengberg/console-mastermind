namespace console_mastermind;

public class Registration
{
    public int Id { get; set; }
    public DateTime ClaimsDate { get; set; }

    public Registration()
    {
        
    }
    public Registration(int id)
    {
        Id = id;
    }
}