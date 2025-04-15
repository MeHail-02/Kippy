namespace Kippy.Domain.Volunteer;

public sealed class Address 
{
    private string City { get; }
    
    private string Street { get; }
    
    private string Building  { get; }
    
    private string Apartment { get; }

    public Address(string city, string street, string building, string apartment)
    {
        City = city;
        Street = street;
        Building = building;
        Apartment = apartment;
    }
    
}