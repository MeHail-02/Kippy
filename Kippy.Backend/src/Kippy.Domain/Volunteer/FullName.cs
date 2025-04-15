namespace Kippy.Domain.Volunteer;

public sealed class FullName
{
    public string FirstName { get; }
    
    public string LastName { get; }
    
    public string MiddleName { get; }
    
    public FullName(string lastName, string firstName, string middleName)
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
    }
}