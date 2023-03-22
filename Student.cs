class Students
{
    public string FirstName {get;set;}
    public string LastName {get;set;}
    public string Email {get;set;}
    public Students()
    {
        Console.Write("Enter the Student's First Name: ");
        FirstName = Console.ReadLine();
        Console.Write("Enter the Student's Last Name: ");
        LastName = Console.ReadLine();
        Console.Write("Enter the Student's Email Address: ");
        Email = Console.ReadLine();
    }
    public Students(string firstName, string lastName, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }
    public override string ToString()
    {
        return $"{FirstName} {LastName} | {Email}";
    }
}